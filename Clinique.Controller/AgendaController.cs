using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;
using Clinique.Model;
namespace Clinique.Controller
{
    public class AgendaController
    {
         #region Singleton pattern
        private static AgendaController _instance = null;
        
        public static AgendaController Instance { 
            get {
                return null == _instance ? _instance = new AgendaController() : _instance;
            }
        }

        private AgendaController()
        {

        }
        #endregion

        public Agenda AjouterAgenda(Veterinaire veto, Animal animal, DateTime dateRdv)
        {
            return AgendaStore.Instance.Ajouter(veto, animal, dateRdv);
        }

        public bool SupprimerAgenda(Agenda agenda)
        {
            return AgendaStore.Instance.Supprimer(agenda);
        }
    }
}
