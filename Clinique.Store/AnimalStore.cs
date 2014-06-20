using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using System.Data;

namespace Clinique.Store
{   
    
    /// <summary>
    /// Data Access Layer pour la classe Animal
    /// </summary>
    public class AnimalStore
    {
        #region attributes
        private List<Animal> _animaux;
        #endregion
        #region properties
        /// <summary>
        /// Recupere les données en base à chaque consultation de cette propriete
        /// </summary>
        public List<Animal> Animaux
        {
            get
            {
                //@todo synchroniser avec BD
                return _animaux;
            }
            set { _animaux = value; }
        }
        #endregion

        #region Singleton pattern
        private static AnimalStore _instance = null;
        
        public static AnimalStore Instance { 
            get {
                return null == _instance ? _instance = new AnimalStore() : _instance;
            }
        }
        /// <summary>
        /// constructeur AnimalStore
        /// </summary>
        private AnimalStore()
        {
            Animaux = new List<Animal>();
            try
            {
                _loadAnimaux();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion
        #region methods
        private void _loadAnimaux()
        {
            string sql = "select * from Animaux";
            IDbConnection cn = Database.Instance.getConnection();
            IDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cn.Open();
                IDataReader reader = cmd.ExecuteReader();
                object tatouage, couleur, antecedent;
                while (reader.Read())
                {
                    tatouage = Database.read(reader, "Tatouage");
                    couleur = Database.read(reader, "Couleur");
                    antecedent = Database.read(reader, "Antecedents");
                    Client client = ClientStore.Instance.RecupererClient(Database.read<Guid>(reader, "CodeClient"));
                    Race race = RaceStore.Instance.RecupererRace(Database.read<string>(reader, "Race"), Database.read<string>(reader, "Espece"));
                    Animal.eSexe sexe = (Animal.eSexe)(Database.read<string>(reader, "Sexe")[0]);
                    this.Animaux.Add(new Animal(
                        Database.read<Guid>(reader,"CodeAnimal"),
                        Database.read<string>(reader,"NomAnimal"),
                        sexe,
                        couleur == null? null : (String) couleur,
                        race,
                        tatouage == null? null:(string) tatouage,
                        antecedent == null ? null:(string) antecedent,
                        Database.read<bool>(reader, "Archive"),
                        client 
                       )
                    );
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
        /// <summary>
        /// Creer un animal
        /// </summary>
        /// <param name="nomAnimal"></param>
        /// <param name="sexe"></param>
        /// <param name="couleur"></param>
        /// <param name="race"></param>
        /// <param name="tatouage"></param>
        /// <param name="antecedant"></param>
        /// <param name="archive"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Animal Ajouter(string nomAnimal, Animal.eSexe sexe, string couleur, Race race,
             string tatouage, string antecedant, bool archive, Client client)
        {
            Animal animal = new Animal(Guid.NewGuid(), nomAnimal, sexe, couleur, race, tatouage, antecedant, archive, client);
            try
            {
                Database.Instance.insert(animal);
                this.Animaux.Add(animal);
            }
            catch (Exception e)
            {
                throw new Exception("Erreur sur Ajout.\n" + e.Message, e);
            }
            return animal;
        }
        /// <summary>
        /// Modifie l'animal
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="nomAnimal"></param>
        /// <param name="sexe"></param>
        /// <param name="couleur"></param>
        /// <param name="race"></param>
        /// <param name="tatouage"></param>
        /// <param name="antecedents"></param>
        /// <param name="archive"></param>
        /// <param name="client"></param>
        /// <exception cref="Exception"></exception>
        public void Modifier(Animal animal, string nomAnimal, Animal.eSexe sexe, string couleur, Race race,
             string tatouage, string antecedents, bool archive, Client client)
        {
            animal.Antecedents = antecedents;
            animal.Archive = archive;
            animal.Client = client;
            animal.Couleur = couleur;
            animal.NomAnimal = nomAnimal;
            animal.Sexe = sexe;
            animal.Tatouage = tatouage;
            animal.Race = race;
            try
            {
                Database.Instance.update(animal);
            }
            catch (Exception e)
            {
                throw new Exception("Erreur sur Modification.\n" + e.Message,e);
            }
        }

        /// <summary>
        /// archive l'animal
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>boolean</returns>
        /// <exception cref="Exception"></exception>
        public bool Supprimer(Animal animal)
        {
            //@todo get facture.
            //@todo archiver animaux du client
            animal.Archive = true;
            try
            {
                Database.Instance.update(animal);
            }
            catch (Exception e)
            {
                throw new Exception("Erreur sur Archivage.\n" + e.Message, e);
            }
            return true;
        }

        public Animal RecupererAnimal(Guid codeAnimal)
        {
            return this.Animaux.Find(a => a.CodeAnimal == codeAnimal);
        }

        #endregion
    }
}
