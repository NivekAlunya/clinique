using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
namespace Clinique.Store
{
    public class AgendaStore
    {
        #region Singleton pattern
        private static AgendaStore _instance = null;
        
        public static AgendaStore Instance { 
            get {
                return null == _instance ? _instance = new AgendaStore() : _instance;
            }
        }

        private AgendaStore()
        {

        }
        #endregion
        #region attributes

        public Agenda Ajouter(Veterinaire veto, Animal animal, DateTime dateRdv)
        {
            Agenda agenda = new Agenda(veto, animal, dateRdv);
            Database.Instance.insert(agenda);

            return agenda;
        }

        public void Modifier(Agenda agenda, Veterinaire veto, Animal animal, DateTime dateRdv)
        {
            agenda.Veto = veto;
            agenda.DateRdv = dateRdv;
            agenda.Animal = animal;
            Database.Instance.update(agenda);
        }

        public bool Supprimer(Agenda agenda)
        {
            return Database.Instance.delete(agenda);
        }
        #endregion
    }
}
