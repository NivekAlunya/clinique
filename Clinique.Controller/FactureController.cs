using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;
using Clinique.Model;

namespace Clinique.Controller
{
    public class FactureController
    {

        #region Singleton Pattern
        private static FactureController _instance = null;
        public static FactureController  Instance
	    {
		    get { return _instance == null ? _instance = new FactureController() : _instance;}
		}
        private FactureController()
        {
        }
	
        #endregion

        public static Facture AjouterFacture(Guid numFacture, Client client, DateTime dateFacture, Facture.eFactureEtats etat, decimal totalFacture, DateTime rappelEnvoye, bool archive)
        {
            return FactureStore.Instance.Ajouter(client, dateFacture, etat, totalFacture, rappelEnvoye, archive);

        }

        public static void ModifierFacture(Facture facture, Client client, DateTime dateFacture, Facture.eFactureEtats etat, decimal totalFacture, DateTime rappelEnvoye, bool archive)
        {
            FactureStore.Instance.Modifier(facture, client, dateFacture, etat, totalFacture, rappelEnvoye, archive);
        }

        public static bool SupprimerFacture(Facture facture)
        {
            return FactureStore.Instance.Supprimer(facture);
        }
        
    }
}
