using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Connection
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        
        private string _login;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        
    }
}
