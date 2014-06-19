using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Clinique.Model;
namespace Clinique.Store
{
    public class AgendaStore
    {
        #region attributes
        private List<Agenda> _agendas;
        #endregion
        #region properties
        /// <summary>
        /// Recupere les données en base à chaque consultation de cette propriete
        /// </summary>
        public List<Agenda> Agendas
        {
            get
            {
                return _agendas;
            }
            set { _agendas = value; }
        }
        #endregion

        #region Singleton pattern
        private static AgendaStore _instance = null;
        
        public static AgendaStore Instance { 
            get {
                return null == _instance ? _instance = new AgendaStore() : _instance;
            }
        }
        /// <summary>
        /// Constructeur AgendaStore
        /// </summary>
        /// <exception cref="Exception"></exception>
        private AgendaStore()
        {
            Agendas = new List<Agenda>();
            try
            {
                _loadAgendas();
            }
            catch (Exception e)
            {
                
                throw e;
            }
            
        }
        #endregion
        #region methods

        private void _loadAgendas()
        {
            string sql = "select * from Agendas";
            IDbConnection cn = Database.Instance.getConnection();
            IDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cn.Open();
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Veterinaire veto = VeterinaireStore.Instance.RecupererVeterinaire(Database.read<Guid>(reader, "CodeVeto"));
                    Animal animal = AnimalStore.Instance.RecupererAnimal(Database.read<Guid>(reader, "CodeAnimal"));
                    this.Agendas.Add(new Agenda(veto, animal, Database.read<DateTime>(reader, "DateRdv")));
                }

            }
            catch (Exception e)
            {
                throw new Exception("Erreur sur chargement de la liste des agendas.\n" + e.Message, e);
            }
            finally
            {
                Database.close(cn);
            }
        }

        /// <summary>
        /// Ajoute un rendez vous
        /// </summary>
        /// <param name="veto"></param>
        /// <param name="animal"></param>
        /// <param name="dateRdv"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Agenda Ajouter(Veterinaire veto, Animal animal, DateTime dateRdv)
        {
            try
            {
                if( default(Agenda) != Agendas.Find( ag => ag.DateRdv == dateRdv && ag.Veto == veto))
                    throw new Exception("Ce veterinaire a deja un rendez vous a cette date!!!");
                if (default(Agenda) != Agendas.Find(ag => ag.DateRdv == dateRdv && ag.Animal == animal))
                    throw new Exception("Cet animal a deja un rendez vous a cette date!!!");
                Agenda agenda = new Agenda(veto, animal, dateRdv);
                Database.Instance.insert(agenda);
                this.Agendas.Add(agenda);
                return agenda;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// modifie un rendez vous
        /// </summary>
        /// <param name="agenda"></param>
        /// <param name="veto"></param>
        /// <param name="animal"></param>
        /// <param name="dateRdv"></param>
        /// <exception cref="Exception"></exception>
        public void Modifier(Agenda agenda, Veterinaire veto, Animal animal, DateTime dateRdv)
        {
            try
            {
                agenda.Veto = veto;
                agenda.DateRdv = dateRdv;
                agenda.Animal = animal;
                Database.Instance.update(agenda);
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns></returns>
        public bool Supprimer(Agenda agenda)
        {
            try
            {
                Database.Instance.delete(agenda);
                this.Agendas.Remove(agenda);
            }
            catch (Exception e)
            {
                throw new Exception("Erreur sur Suppression de l'agenda.\n" + e.Message, e);
            }
            return true;
        }
        #endregion
    }
}
