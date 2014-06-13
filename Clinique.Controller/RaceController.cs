using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using Clinique.Store;

namespace Clinique.Controller
{
    public class RaceController
    {
        #region Singleton pattern
        private static RaceController _instance = null;
        public static RaceController Instance { 
            get {
                return null == _instance ? _instance = new RaceController() : _instance;
            }
        }
        private RaceController()
        {
                
        }
        #endregion

        public Race AjouterRace(string race, string espece)
        {
            return RaceStore.Ajouter(race,espece);
        }

        public bool SupprimerRace(Race race)
        {
            return RaceStore.Supprimer(race);
        }

    }
}
