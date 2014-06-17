using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;

namespace Clinique.Store
{
    public class LigneFactureStore
    {
        #region Singleton pattern
        private static LigneFactureStore _instance = null;
        
        public static LigneFactureStore Instance { 
            get {
                return null == _instance ? _instance = new LigneFactureStore() : _instance;
            }
        }

        private LigneFactureStore()
        {

        }
        #endregion
        public LigneFacture Ajouter(Facture facture, Bareme bareme, decimal prix, bool archive)
        {
            LigneFacture ligneFacture = new LigneFacture(Guid.NewGuid(), facture, bareme, prix, archive);
            Database.Instance.insert(ligneFacture);

            return ligneFacture;
        }

        public void Modifier(LigneFacture ligneFacture, Facture facture, Bareme bareme, decimal prix, bool archive)
        {
            ligneFacture.Archive = archive;
            ligneFacture.Bareme = bareme;
            ligneFacture.Facture = facture;
            ligneFacture.Prix = prix;

            Database.Instance.update(ligneFacture);
        }

        public bool Supprimer(LigneFacture ligneFacture)
        {
            return Database.Instance.delete(ligneFacture);
        }

    }
}
