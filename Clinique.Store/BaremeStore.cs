using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;

namespace Clinique.Store
{
    public static class BaremeStore
    {
        public static Bareme Ajouter(string codeGroupement, string dateVigueur, string typeActe, string libelle,
            decimal tarifFixe, decimal tarifMini, decimal tarifMaxi, Vaccin vaccin, bool archive)
        {
            Bareme bareme = new Bareme(codeGroupement, dateVigueur, typeActe, libelle,
             tarifFixe, tarifMini, tarifMaxi, vaccin, archive);
            Database.Instance.insert(bareme);

                return bareme;
        }

        public static void Modifier(Bareme bareme, string typeActe, string libelle,
            decimal tarifFixe, decimal tarifMini, decimal tarifMaxi, Vaccin vaccin)
        {
        
            bareme.TypeActe = typeActe;
            bareme.Libelle = libelle;
            bareme.TarifFixe = tarifFixe;
            bareme.TarifMini = tarifMini;
            bareme.TarifMaxi = tarifMaxi;
            
            Database.Instance.update(bareme);
            
        }

        public static bool Supprimer(Bareme bareme)
        {
            return Database.Instance.delete(bareme);
        }
    }
}
