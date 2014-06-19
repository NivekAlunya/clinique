using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using Clinique.Store;
using Clinique.Model;
namespace Clinique.Controller
{
    public class ClientController
    {
        #region attributes
        private BindingList<Client> _clients;
        #endregion
        #region properties
        public BindingList<Client> Clients
        {
            get
            {
                _clients = new BindingList<Client>(
                    ClientStore.Instance.Clients.FindAll((Client c) => c.Archive == false)
                );
                return _clients;
            }
            private set
            {
                _clients = value;
            }
        }
        #endregion
        #region Singleton Pattern
        private static ClientController _instance = null;
	    public static ClientController  Instance
	    {
		    get { return _instance == null ? _instance = new ClientController() : _instance;}
	    }

        private ClientController()
        {

        }
        #endregion

        #region methods
        public Client AjouterClient (string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
            Client c = ClientStore.Instance.Ajouter(nomClient, prenomClient, adresse1, adresse2, codePostal,
             ville, numTel, assurance, email, remarque, archive);
            _clients.Add(c);
            return c;
        }

        public void ModifierClient(Client client, string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
            ClientStore.Instance.Modifier(client, nomClient, prenomClient, adresse1, adresse2, codePostal,
             ville, numTel, assurance, email, remarque, archive);
        }

        public bool SupprimerClient(Client client)
        {
            if (ClientStore.Instance.Supprimer(client))
            {
                _clients.Remove(client);
                return true;
            }
            return false;
        }
        #endregion
    }
}
