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
namespace Clinique.Store
{
    public class Database
    {
        #region attributes
        IDbConnection _connection;
        #endregion
        #region Singleton immplementation
        private Database _instance;
        public Database Instance
        {
            get { return null == _instance ? _instance = new Database() : _instance; }
        }
        private Database()
            :base()
        {

        }
        #endregion

        public IDbConnection getConnection()
        { 
            if(null == _connection) {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["SqlServer"];
                _connection = DbProviderFactories.GetFactory(settings.ProviderName).CreateConnection();
                _connection.ConnectionString = settings.ConnectionString;
            }
            return _connection;
        }

        public bool save<T>(T c)
        {
            foreach (PropertyInfo p in c.GetType().GetProperties())
            {
                System.Attribute[] attrs = System.Attribute.GetCustomAttributes(p);
                foreach (System.Attribute att in attrs)
                {
                    Console.WriteLine(((Persist)att).DbType);
                }
            }
            return true;
        }
        

    }
}
