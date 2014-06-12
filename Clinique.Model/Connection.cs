using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Tools;
using System.Data;

namespace Clinique.Model
{
    [Persist("Connexions")]
    public class Connection
    {
        private int _id;
        [Persist(SqlDbType.Int, Persist.FieldBehaviour.pk|Persist.FieldBehaviour.autoincrement)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        
        private string _login;
        [Persist(SqlDbType.VarChar)]
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        private string _password;
        [Persist(SqlDbType.VarChar)]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        
    }
}
