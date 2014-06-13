using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using Clinique.Store;
namespace Clinique.Controller
{
    public class VaccinController
    {
        #region Singleton pattern
        private static VaccinController _instance = null;
        public static VaccinController Instance { 
            get {
                return null == _instance ? _instance = new VaccinController() : _instance;
            }
        }
        private VaccinController()
        {
                
        }
        #endregion
        
        public Vaccin AjouterVaccin(string nomVaccin, int quantiteStock, byte periodeValidite, bool archive)
        {
            return VaccinStore.Ajouter(nomVaccin, quantiteStock, periodeValidite, archive);
        }

        public void ModifierVaccin(Vaccin vaccin, string nomVaccin, int quantiteStock, byte periodeValidite, bool archive)
        {
            VaccinStore.Modifier(vaccin, nomVaccin, quantiteStock, periodeValidite, archive);
        }

        public bool SupprimerVaccin(Vaccin vaccin)
        {
            return VaccinStore.Supprimer(vaccin);
        }
    }
}
