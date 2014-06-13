using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;

namespace Clinique.Controller
{
    public class ConnexionController
    {

        #region "Pattern de singleton"
        private static ConnexionController _instance;
        private ConnexionController()
        {
        
        }

        public static ConnexionController GetInstance()
        {
            if (_instance == null) { _instance = new ConnexionController(); }
            return _instance;
        }
        
        #endregion
        
        
        public Boolean Connect (string login, string password)
        {
           return ConnexionStore.ExistsConnexion(login, password);

        }
        
    }
}
