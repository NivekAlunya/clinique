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
    public class ClientControler
    {
        #region attributes
        private BindingList<Client> _clients;
        #endregion
        #region properties
        public BindingList<Client> Clients
        {
            get
            {
                return _clients;
            }
            private set
            {
                _clients = value;
            }
        }
        #endregion
        #region Singleton Pattern
        private static ClientControler _instance = null;
	    public static ClientControler  Instance
	    {
		    get { return _instance == null ? _instance = new ClientControler() : _instance;}
	    }

        private ClientControler()
        {
            Clients = new BindingList<Client>(
                ClientStore.Clients.FindAll((Client c) => c.Archive == false)
            );
        }
        #endregion

        #region methods
        public Client AjouterClient (string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
            return ClientStore.Ajouter (nomClient, prenomClient, adresse1, adresse2, codePostal,
             ville, numTel, assurance, email, remarque, archive);
        }

        public void ModifierClient(Client client, string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
             ClientStore.Modifier(client, nomClient, prenomClient, adresse1, adresse2, codePostal,
             ville, numTel, assurance, email, remarque, archive);
        }

        public bool SupprimerClient(Client client)
        {
            if (ClientStore.Supprimer(client))
            {
                this.Clients.Remove(client);
                return true;
            }
            return false;
        }
        #endregion
    }
}
