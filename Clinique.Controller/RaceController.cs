using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using Clinique.Store;
using System.ComponentModel;
namespace Clinique.Controller
{
    public class RaceController
    {
        #region attributes
        private BindingList<Race> _races;
        #endregion
        #region properties
        public BindingList<Race> Races
        {
            get
            {
                return _races;
            }
            private set
            {
                _races = value;
            }
        }
        #endregion
        #region Singleton pattern
        private static RaceController _instance = null;
        public static RaceController Instance { 
            get {
                return null == _instance ? _instance = new RaceController() : _instance;
            }
        }
        private RaceController()
        {
            Races = new BindingList<Race>(RaceStore.Instance.getAll());
        }
        #endregion

        public Race AjouterRace(string race, string espece)
        {
            return RaceStore.Instance.Ajouter(race, espece);
        }

        public bool SupprimerRace(Race race)
        {
            return RaceStore.Instance.Supprimer(race);
        }

    }
}
