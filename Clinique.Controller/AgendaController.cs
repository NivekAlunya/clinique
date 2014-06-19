using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;
using Clinique.Model;
using System.ComponentModel;
namespace Clinique.Controller
{
    public class AgendaController
    {
        #region attributes
        private BindingList<Agenda> _agendas;
        #endregion
        #region properties
        public BindingList<Agenda> Agendas
        {
            get
            {
                return _agendas;
            }
            private set
            {
                _agendas = value;
            }
        }
        #endregion
        #region Singleton pattern
        private static AgendaController _instance = null;
        
        public static AgendaController Instance { 
            get {
                return null == _instance ? _instance = new AgendaController() : _instance;
            }
        }
        
        private AgendaController()
        {
            Agendas = new BindingList<Agenda>(AgendaStore.Instance.Agendas);
        }
        #endregion
        #region methods
        /// <summary>
        /// Ajoute un rendez vous
        /// </summary>
        /// <param name="veto"></param>
        /// <param name="animal"></param>
        /// <param name="dateRdv"></param>
        /// <returns>un objet agenda</returns>
        /// <exception cref="Exception"></exception>
        public Agenda AjouterAgenda(Veterinaire veto, Animal animal, DateTime dateRdv)
        {
            try
            {
                Agenda agenda = AgendaStore.Instance.Ajouter(veto, animal, dateRdv);
                return agenda;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Supprime un rendez vous
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns>vrai ou faux</returns>
        /// <exception cref="Exception"></exception>
        public bool SupprimerAgenda(Agenda agenda)
        {
            this.Agendas.Remove(agenda);
            return AgendaStore.Instance.Supprimer(agenda);
        }
        public List<Object> getAgendasDuJourPourVeto(Veterinaire veto,DateTime dt)
        {
            var linq = from Agenda ag in AgendaStore.Instance.Agendas
                       where ag.Veto.Equals(veto) & ag.DateRdv.ToShortDateString() == dt.ToShortDateString()
                       orderby ag.DateRdv ascending
                       select new { ag, hour = ag.DateRdv.ToShortTimeString(), Nom = ag.Animal.Client.NomClient + ' ' + ag.Animal.Client.PrenomClient, animal = ag.Animal.NomAnimal, race = ag.Animal.Race.Espece }; ;

            return new List<Object>(linq);
        }
        #endregion
    }
}
