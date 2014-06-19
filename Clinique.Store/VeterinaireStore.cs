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
    public class VeterinaireStore
    {
        #region attributes
        private List<Veterinaire> _veterinaires;
        #endregion
        #region properties
        /// <summary>
        /// Recupere les données en base à chaque consultation de cette propriete
        /// </summary>
        public List<Veterinaire> Veterinaires
        {
            get {
                
                return _veterinaires; 
            }
            set { _veterinaires = value; }
        }
        #endregion
        #region Singleton pattern
        private static  VeterinaireStore _instance = null;
        
        public static VeterinaireStore Instance { 
            get {
                return null == _instance ? _instance = new VeterinaireStore() : _instance;
            }
        }

        private VeterinaireStore()
        {
            Veterinaires = new List<Veterinaire>();
            _loadVeterinaires();
        }
        #endregion
        #region methods
        private void _loadVeterinaires()
        {
            
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
                    this.Veterinaires.Add(new Veterinaire(
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

        public List<Veterinaire> getAll()
        {
            return this.Veterinaires.FindAll((Veterinaire v) => v.Archive == false);
        }
        

        public Veterinaire Ajouter(string nomVeto, string motDePasse, bool archive)
        {
            Veterinaire veto = new Veterinaire(Guid.NewGuid(), nomVeto, motDePasse, archive);
            Database.Instance.insert(veto);
            this.Veterinaires.Add(veto);
            return veto;
        }

        public void Modifier(Veterinaire veterinaire, string nomVeto, string motDePasse, bool archive)
        {
            veterinaire.MotDePasse = motDePasse;
            veterinaire.NomVeto = nomVeto;
            veterinaire.Archive = archive;
            Database.Instance.update(veterinaire);
        }

        public bool Supprimer(Veterinaire veterinaire)
        {
            //@todo get consultation.
            veterinaire.Archive = true;
            Database.Instance.update(veterinaire);
            //Veterinaires.Remove(veterinaire);
            return true;
        }

        public Veterinaire RecupererVeterinaire(Guid codeVeto)
        {
            return this.Veterinaires.Find(v => v.CodeVeto == codeVeto);
        }


        #endregion
    }
}
