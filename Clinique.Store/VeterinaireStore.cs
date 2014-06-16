using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Clinique.Model;
namespace Clinique.Store
{
    /// <summary>
    /// Data Access Layer pour la classe Veterinaire
    /// </summary>
    public static class VeterinaireStore
    {
        #region attributes
        static private List<Veterinaire> _veterinaires;
        #endregion
        #region properties
        /// <summary>
        /// Recupere les données en base à chaque consultation de cette propriete
        /// </summary>
        static public List<Veterinaire> Veterinaires
        {
            get {
                _loadVeterinaires();
                return _veterinaires; 
            }
            set { _veterinaires = value; }
        }
        #endregion
        #region methods
        private static void _loadVeterinaires()
        {
            _veterinaires = new List<Veterinaire>();
            string sql = "select * from Veterinaires";
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
                    _veterinaires.Add(new Veterinaire(
                        Database.read<Guid>(reader, "CodeVeto"),
                        Database.read<string>(reader, "NomVeto"),
                        Database.read<string>(reader, "MotPasse"),
                        Database.read<bool>(reader, "Archive")
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
        
        public static Veterinaire Ajouter(string nomVeto, string motDePasse, bool archive)
        {
            Veterinaire veto = new Veterinaire(Guid.NewGuid(), nomVeto, motDePasse, archive);
            Database.Instance.insert(veto);
            Veterinaires.Add(veto);
            return veto;
        }

        public static void Modifier(Veterinaire veterinaire, string nomVeto, string motDePasse, bool archive)
        {
            veterinaire.MotDePasse = motDePasse;
            veterinaire.NomVeto = nomVeto;
            veterinaire.Archive = archive;
            Database.Instance.update(veterinaire);
        }

        public static bool Supprimer(Veterinaire veterinaire)
        {
            //@todo get consultation.
            veterinaire.Archive = true;
            Database.Instance.update(veterinaire);
            //Veterinaires.Remove(veterinaire);
            return true;
        }
        #endregion
    }
}
