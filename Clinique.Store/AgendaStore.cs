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
                    //Veterinaire veto = VeterinaireStore.Instance.RecupererVeterinaire(Database.read<Guid>(reader, "CodeVeto"));
                    //Animal animal = AnimalStore.Instance.RecupererAnimal(Database.read<Guid>(reader, "Animal"), Database.read<string>(reader, "Espece"));
                    this.Agendas.Add(new Agenda(null, null, Database.read<DateTime>(reader, "DateRdv")));
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
