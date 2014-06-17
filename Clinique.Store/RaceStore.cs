using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using System.Data;
namespace Clinique.Store
{
    public static class RaceStore
    {

        #region attributes
        static private List<Race> _races;
        #endregion
        #region properties
        /// <summary>
        /// Recupere les données en base à chaque consultation de cette propriete
        /// </summary>
        static public List<Race> Races
        {
            get
            {
                _loadRaces();
                return _races;
            }
            set { _races = value; }
        }
        #endregion
        #region methods
        private static void _loadRaces()
        {
            _races = new List<Race>();
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

        public static Race RecupererRace(string race_, string espece)
        {
            return _races.Find( r => r.Race_ == race_ & r.Espece == espece);
        }

        public static Race Ajouter(string race_, string espece)
        {
            Race race = new Race(race_,espece);
            Database.Instance.insert(race);

            return race;
        }

        public static bool Supprimer(Race race)
        {
            return Database.Instance.delete(race);
        }
        #endregion
    }
}
