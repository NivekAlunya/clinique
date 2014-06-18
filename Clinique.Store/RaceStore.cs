using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using System.Data;
namespace Clinique.Store
{
    public class RaceStore
    {


        #region attributes
        private List<Race> _races;
        #endregion
        #region properties
        /// <summary>
        /// Recupere les données en base à chaque consultation de cette propriete
        /// </summary>
        public List<Race> Races
        {
            get
            {
                return _races;
            }
            set { _races = value; }
        }
        #endregion

        #region Singleton pattern
        private static RaceStore _instance = null;

        public static RaceStore Instance
        {
            get
            {
                return null == _instance ? _instance = new RaceStore() : _instance;
            }
        }

        private RaceStore()
        {
            _races = new List<Race>();
            _loadRaces();
        }
        #endregion

        #region methods
        private void _loadRaces()
        {
            string sql = "select * from Races";
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
                    _races.Add(new Race(
                        Database.read<string>(reader, "Race"),
                        Database.read<string>(reader, "Espece")
                    ));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Database.close(cn);
            }
        }

        public List<Race> getAll()
        {
            return this.Races;
        }

        public Race RecupererRace(string race_, string espece)
        {
            if (null == _races) _loadRaces();
            return _races.Find( r => r.Race_ == race_ & r.Espece == espece);
        }

        public Race Ajouter(string race_, string espece)
        {
            Race race = new Race(race_,espece);
            Database.Instance.insert(race);

            return race;
        }

        public bool Supprimer(Race race)
        {
            return Database.Instance.delete(race);
        }
        #endregion
    }
}
