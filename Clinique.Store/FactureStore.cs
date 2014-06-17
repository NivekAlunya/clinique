using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;

namespace Clinique.Store
{
    public class FactureStore
    {
        #region Singleton pattern
        private static FactureStore _instance = null;
        
        public static FactureStore Instance { 
            get {
                return null == _instance ? _instance = new FactureStore() : _instance;
            }
        }

        private FactureStore()
        {

        }
        #endregion
        public Facture Ajouter(Client client, DateTime dateFacture, Facture.eFactureEtats etat, decimal totalFacture, DateTime rappelEnvoye, bool archive)
        {
            Facture facture = new Facture(Guid.NewGuid(), client, dateFacture, etat, totalFacture, rappelEnvoye, archive);
            Database.Instance.insert(facture);
            return facture;
       }

        public void Modifier(Facture facture ,Client client, DateTime dateFacture, Facture.eFactureEtats etat, decimal totalFacture, DateTime rappelEnvoye, bool archive)
        {
            facture.Archive = archive;
            facture.Client = client;
            facture.DateFacture = dateFacture;
            facture.Etat = etat;
            facture.RappelEnvoye = rappelEnvoye;
            facture.TotalFacture = totalFacture;

            Database.Instance.update(facture);
        }

        public bool Supprimer(Facture facture)
        {
            return Database.Instance.delete(facture);
        }

        
    }
}
