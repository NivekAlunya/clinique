using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;
using Clinique.Model;

namespace Clinique.Controller
{
    public class LigneFactureController
    {
        #region Singleton Pattern
        private static LigneFactureController _instance = null;
	    public static LigneFactureController  Instance
	    {
		    get { return _instance == null ? _instance = new LigneFactureController() : _instance;}
	    }

        private LigneFactureController()
        {
        }
	    #endregion

        public static LigneFacture AjouterLignesFacture(Facture facture, Bareme bareme, decimal prix, bool archive)
        {
            return LigneFactureStore.Instance.Ajouter(facture, bareme, prix, archive);
        }

        public static void ModifierLignesFacture(LigneFacture lignesFacture, Facture facture, Bareme bareme, decimal prix, bool archive)
        {
            LigneFactureStore.Instance.Modifier(lignesFacture, facture, bareme, prix, archive);
        }

        public static bool SupprimerLignesFacture(LigneFacture lignesFacture)
        {
            return LigneFactureStore.Instance.Supprimer(lignesFacture);
        }

        //public static bool SupprimerFacture(Facture facture)
        //{
        //    return FactureStore.Supprimer(facture);
        //}

    }
}
