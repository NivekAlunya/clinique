using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Clinique.Store
{
    public static class ConnexionStore
    {

        public static bool ExistsConnexion(string login, string password)
        {
            Boolean autorisation = false;
            IDbConnection cnx = Database.Instance.getConnection();
            

            //TODO retirer les cote du '1'
            string req = "SELECT '1' FROM Connexions WHERE login=@login AND password=@password";

            IDbCommand cmd = cnx.CreateCommand();
            cmd.CommandText = req;
            cmd.CommandType = System.Data.CommandType.Text;

            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@login";
            param.Value = login;
            param.DbType = System.Data.DbType.String;
            param.Direction = System.Data.ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@Password";
            param.Value = password;
            param.DbType = System.Data.DbType.String;
            cmd.Parameters.Add(param);

            cnx.Open();
            int reponse = Convert.ToInt32(cmd.ExecuteScalar());
            cnx.Close();
            if (reponse == 1) autorisation = true;
            return autorisation; 
        }

    }
}
