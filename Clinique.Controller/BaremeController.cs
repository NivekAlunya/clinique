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
    public class BaremeController
    {
        # region Singleton Pattern
        private static BaremeController _instance = null;
     

	public static BaremeController  Instance
	{
		get { return _instance == null ? _instance = new BaremeController() : _instance;}
		
	}

        private BaremeController()
        {
        }
	
# endregion

        public static Bareme AjouterBareme(string codeGroupement, string dateVigueur, string typeActe, string libelle,
            decimal tarifFixe, decimal tarifMini, decimal tarifMaxi, Vaccin vaccin, bool archive)
        {
            return BaremeStore.Ajouter(codeGroupement, dateVigueur, typeActe, libelle,
             tarifFixe, tarifMini, tarifMaxi, vaccin, archive) ;
        }

        public static void ModifierBareme (Bareme bareme, string typeActe, string libelle,
            decimal tarifFixe, decimal tarifMini, decimal tarifMaxi, Vaccin vaccin)
        {
        BaremeStore.Modifier(bareme, typeActe, libelle, tarifFixe, tarifMini, tarifMaxi, vaccin);
        }

        public static void SupprimerBareme(Bareme bareme)
        {
            BaremeStore.Supprimer(bareme);
        }
    }
}
