using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;

namespace Clinique.Store
{
    public class VaccinStore
    {
        #region Singleton pattern
        private static VaccinStore _instance = null;
        
        public static VaccinStore Instance { 
            get {
                return null == _instance ? _instance = new VaccinStore() : _instance;
            }
        }

        private VaccinStore()
        {

        }
        #endregion
        public Vaccin Ajouter(string nomVaccin, int quantiteStock, byte periodeValidite, bool archive)
        {
            Vaccin vaccin = new Vaccin(Guid.NewGuid(), nomVaccin, quantiteStock, periodeValidite, archive);
            Database.Instance.insert(vaccin);
            
            return vaccin;
        }

        public void Modifier(Vaccin vaccin, string nomVaccin, int quantiteStock, byte periodeValidite, bool archive)
        {
            vaccin.NomVaccin = nomVaccin;
            vaccin.QuantiteStock = quantiteStock;
            vaccin.PeriodeValidite = periodeValidite;
            vaccin.Archive = archive;
            Database.Instance.update(vaccin);
        }

        public bool Supprimer(Vaccin vaccin)
        {
            return Database.Instance.delete(vaccin);
        }
    }
}
