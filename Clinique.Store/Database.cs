using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Common;
using System.Reflection;
using Clinique.Tools;

namespace Clinique.Store
{
    public class Database
    {
        #region attributes
        IDbConnection _connection;
        #endregion
        #region Singleton immplementation
        static private Database _instance;
        static public Database Instance
        {
            get { return null == _instance ? _instance = new Database() : _instance; }
        }
        private Database()
            :base()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["SqlServer"];
            _connection = DbProviderFactories.GetFactory(settings.ProviderName).CreateConnection();
            _connection.ConnectionString = settings.ConnectionString;
        }
        #endregion

        public static T read<T>(IDataReader reader,string field)
        {
            return (T)reader.GetValue(reader.GetOrdinal(field));
        }

        public static void close(IDbConnection cn) {
            if(cn.State == ConnectionState.Open) cn.Close();
        }
        public IDbConnection getConnection()
        { 
            return _connection;
        }

        private string _getTable(object targetObject)
        {
            string table = "";

            foreach (System.Attribute att in System.Attribute.GetCustomAttributes(targetObject.GetType()))
            {
                if (att is Persist)
                    table = (att as Persist).Table;
            }

            if (string.Empty == table)
                table = targetObject.GetType().Name;

            return table;
        }

        private Dictionary<string,Persist.FieldBehaviour> _buildParamaters(object targetObject, IDbCommand cmd, out PropertyInfo pIdentity,Persist.FieldBehaviour filter = Persist.FieldBehaviour.common)
        {
            IDbDataParameter param;
            Dictionary<string, Persist.FieldBehaviour> parameters = new Dictionary<string, Persist.FieldBehaviour>();
            pIdentity = null;
            
            foreach (PropertyInfo p in targetObject.GetType().GetProperties())
            {
                System.Attribute[] attrs = System.Attribute.GetCustomAttributes(p);
                foreach (System.Attribute att in attrs)
                {
                    if (att is Persist)
                    {
                        Persist prop = (Persist)att;
                        if (filter != Persist.FieldBehaviour.common && filter != (filter & prop.Behaviour))
                            continue;
                        //Recuperer la valeur de la propriete
                        string name = string.Empty == prop.Field ? p.Name : prop.Field;
                        object value = null;
                        value = p.GetGetMethod().Invoke(targetObject, null);
                        if (SqlDbType.UniqueIdentifier == prop.DbType && (Guid)value == Guid.Empty)
                            value = DBNull.Value ;
                        else
                        {
                            //Tester si enumeration et cast via le sqldbtype
                            if (value.GetType().IsEnum)
                            {
                                switch (prop.DbType)
                                {
                                    case SqlDbType.Bit:
                                    case SqlDbType.Int:
                                    case SqlDbType.TinyInt:
                                    case SqlDbType.Timestamp:
                                    case SqlDbType.SmallInt:
                                    case SqlDbType.BigInt:
                                    case SqlDbType.Binary:
                                        break;
                                    case SqlDbType.Char:
                                    case SqlDbType.NChar:
                                        value = (char)((int)value);
                                        break;
                                    case SqlDbType.VarBinary:
                                    case SqlDbType.Decimal:
                                    case SqlDbType.Float:
                                    case SqlDbType.Money:
                                    case SqlDbType.Real:
                                    case SqlDbType.SmallMoney:
                                    case SqlDbType.Date:
                                    case SqlDbType.SmallDateTime:
                                    case SqlDbType.DateTime:
                                    case SqlDbType.DateTime2:
                                    case SqlDbType.DateTimeOffset:
                                    case SqlDbType.NText:
                                    case SqlDbType.NVarChar:
                                    case SqlDbType.VarChar:
                                    case SqlDbType.Text:
                                    case SqlDbType.Time:
                                    case SqlDbType.UniqueIdentifier:
                                    default:
                                        throw new Exception("Can't convert enum value to database value");
                                }
                            }
                        }
                        //Recuperer la valeur de la propriete
                        parameters.Add(name, prop.Behaviour);
                        param = cmd.CreateParameter();
                        param.ParameterName = "@" + name;
                        param.Value = value;
                        //Patch for non generic  sql type
                        if (SqlDbType.SmallDateTime == prop.DbType) param.DbType = DbType.String;
                        //param.DbType = (DbType)prop.DbType;
                        cmd.Parameters.Add(param);

                        if (Persist.FieldBehaviour.autoincrement != (prop.Behaviour & Persist.FieldBehaviour.autoincrement))
                        {
                        }
                        else
                        {
                            pIdentity = p;
                        }
                    }
                }
            }
            return parameters;
        }
        
        
        private bool _executeCommand(IDbCommand cmd, string commandText, PropertyInfo pID =  null, object targetObject = null)
        {
            try
            {
                cmd.CommandText = commandText;
                _connection.Open();
                if (null != pID)
                {
                    object[] returnedValue = { Convert.ToInt32( cmd.ExecuteScalar()) };
                    pID.GetSetMethod().Invoke(targetObject, returnedValue);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (ConnectionState.Open == _connection.State) _connection.Close();
            }
            return true;
        }

        private IDbCommand getCommand(CommandType tp)
        {
            IDbCommand cmd = _connection.CreateCommand();
            cmd.CommandType = tp;
            return cmd;
        }

        public bool insert<T>(T targetObject)
        {
            string command = "", fields = "", values = "";
            IDbCommand cmd = getCommand(CommandType.Text);
            PropertyInfo pID = null;
            command = "insert into " + _getTable(targetObject) + " ({0}) values ({1});{2}";


            foreach (KeyValuePair<string, Persist.FieldBehaviour> field in _buildParamaters(targetObject, cmd, out pID))
            {
                if ((Persist.FieldBehaviour.autoincrement & field.Value) != Persist.FieldBehaviour.autoincrement)
                {
                    fields += field.Key + ",";
                    values += "@" + field.Key + ",";
                }
            }
            string txtcmd = string.Format(command, fields.Substring(0, fields.Length - 1), values.Substring(0, values.Length - 1), null != pID ? "SELECT SCOPE_IDENTITY();" : "");
            
            return _executeCommand(cmd,txtcmd,pID,targetObject);
        }
        

        public bool update<T>(T targetObject)
        {
            string command = "", updates = "", where = "";
            IDbCommand cmd = getCommand(CommandType.Text);
            PropertyInfo pID = null;
            command = "update " + _getTable(targetObject) + " set  {0} where {1};";

            foreach (KeyValuePair<string, Persist.FieldBehaviour> field in _buildParamaters(targetObject, cmd, out pID))
            {
                if(Persist.FieldBehaviour.pk ==   (field.Value & Persist.FieldBehaviour.pk))
                    where += field.Key + "=@" + field.Key + " and ";
                else
                    updates += field.Key + "=@" + field.Key + ",";
            }

            if (string.Empty != updates)
            {
                string txtcmd = string.Format(command, updates.Substring(0, updates.Length - 1), where.Substring(0, where.Length - 5));

                return _executeCommand(cmd, txtcmd);
            }
            else
                return false;
        }

        public bool delete<T>(T targetObject)
        {
            string command = "", where = "";
            IDbCommand cmd = getCommand(CommandType.Text);
            PropertyInfo pID = null;
            command = "delete from " + _getTable(targetObject) + " where {0};";

            foreach (KeyValuePair<string, Persist.FieldBehaviour> field in _buildParamaters(targetObject, cmd, out pID,Persist.FieldBehaviour.pk))
            {
                if (Persist.FieldBehaviour.pk == (field.Value & Persist.FieldBehaviour.pk))
                    where += field.Key + "=@" + field.Key + " and ";
            }

            if (string.Empty != where)
            {
                string txtcmd = string.Format(command, where.Substring(0, where.Length - 5));

                return _executeCommand(cmd, txtcmd);
            }
            else
                return false;
        }

    }
}
