using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;

namespace Clinique.Store
{
    public class BaremeStore
    {        
        #region Singleton pattern
        private static BaremeStore _instance = null;
        
        public static BaremeStore Instance { 
            get {
                return null == _instance ? _instance = new BaremeStore() : _instance;
            }
        }

        private BaremeStore()
        {

        }
        #endregion
        #region attributes

        public Bareme Ajouter(string codeGroupement, string dateVigueur, string typeActe, string libelle,
            decimal tarifFixe, decimal tarifMini, decimal tarifMaxi, Vaccin vaccin, bool archive)
        {
            Bareme bareme = new Bareme(codeGroupement, dateVigueur, typeActe, libelle,
             tarifFixe, tarifMini, tarifMaxi, vaccin, archive);
            Database.Instance.insert(bareme);

                return bareme;
        }

        public void Modifier(Bareme bareme, string typeActe, string libelle,
            decimal tarifFixe, decimal tarifMini, decimal tarifMaxi, Vaccin vaccin)
        {
        
            bareme.TypeActe = typeActe;
            bareme.Libelle = libelle;
            bareme.TarifFixe = tarifFixe;
            bareme.TarifMini = tarifMini;
            bareme.TarifMaxi = tarifMaxi;
            
            Database.Instance.update(bareme);
            
        }

        public bool Supprimer(Bareme bareme)
        {
            return Database.Instance.delete(bareme);
        }
        #endregion
    }
}
