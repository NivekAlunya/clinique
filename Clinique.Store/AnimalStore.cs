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
    public static class AnimalStore
    { 
        #region attributes
        static private List<Animal> _animaux;
        #endregion
        #region properties
        /// <summary>
        /// Recupere les données en base à chaque consultation de cette propriete
        /// </summary>
        static public List<Animal> Animaux
        {
            get {
                _loadAnimaux();
                return _animaux;
            }
            set { _animaux = value; }
        }
        #endregion
        #region methods
        private static void _loadAnimaux()
        {
            _animaux = new List<Animal>();
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
                    Client client = ClientStore.RecupererClient(Database.read<Guid>(reader, "CodeClient"));
                    Race race = RaceStore.RecupererRace(Database.read<string>(reader, "Race"), Database.read<string>(reader, "Espece"));
                    Animal.eSexe sexe = (Animal.eSexe)(Database.read<string>(reader, "Sexe")[0]);
                    _animaux.Add(new Animal(
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



        public static Animal Ajouter(string nomAnimal, Animal.eSexe sexe, string couleur, Race race,
             string tatouage, string antecedant, bool archive, Client client)
        {
            Animal animal = new Animal(Guid.NewGuid(), nomAnimal, sexe, couleur, race, tatouage, antecedant, archive, client);
            Database.Instance.insert(animal);
            return animal;
        }

        public static void Modifier(Animal animal, string nomAnimal, Animal.eSexe sexe, string couleur, Race race,
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

            Database.Instance.update(animal);
        }

        public static bool Supprimer(Animal animal)
        {
            return Database.Instance.delete(animal);
        }

        #endregion
    }
}
