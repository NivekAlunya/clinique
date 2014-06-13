using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using System.Data;
using Clinique.Store;

namespace Clinique.Controller
{
    public class ClientControler
    {
# region Singleton Pattern
        private static ClientControler _instance = null;
     

	public static ClientControler  Instance
	{
		get { return _instance == null ? _instance = new ClientControler() : _instance;}
		
	}

        private ClientControler()
        {
        }
	
# endregion

        public static Client AjouterClient (string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
            return ClientStore.Ajouter (nomClient, prenomClient, adresse1, adresse2, codePostal,
             ville, numTel, assurance, email, remarque, archive);
        }

        public static void ModifierClient(Client client, string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
             ClientStore.Modifier(client, nomClient, prenomClient, adresse1, adresse2, codePostal,
             ville, numTel, assurance, email, remarque, archive);
        }

        public static bool SupprimerClient(Client client)
        {
            return ClientStore.Supprimer(client);
        }
    }
    }
