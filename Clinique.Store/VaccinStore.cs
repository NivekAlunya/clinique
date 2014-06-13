using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;

namespace Clinique.Store
{
    public static class VaccinStore
    {
        public static Vaccin Ajouter(string nomVaccin, int quantiteStock, byte periodeValidite, bool archive)
        {
            Vaccin vaccin = new Vaccin(Guid.NewGuid(), nomVaccin, quantiteStock, periodeValidite, archive);
            Database.Instance.insert(vaccin);
            
            return vaccin;
        }

        public static void Modifier(Vaccin vaccin, string nomVaccin, int quantiteStock, byte periodeValidite, bool archive)
        {
            vaccin.NomVaccin = nomVaccin;
            vaccin.QuantiteStock = quantiteStock;
            vaccin.PeriodeValidite = periodeValidite;
            vaccin.Archive = archive;
            Database.Instance.update(vaccin);
        }

        public static bool Supprimer(Vaccin vaccin)
        {
            return Database.Instance.delete(vaccin);
        }
    }
}
