using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Clinique.Store;

namespace Clinique.Model
{
    [Persist("Animaux")]
    public class Animal
    {

        public Animal(Guid codeAnimal, string nomAnimal, eSexe sexe, string couleur, Race race,
             string tatouage, string antecedant, Boolean archive, Client client)
        {
        CodeAnimal = codeAnimal;
        NomAnimal = nomAnimal;
        Sexe = sexe;
        Couleur = couleur;
        Race = race;
        Tatouage = tatouage;
        Antecedant = antecedant;
        Archive = archive;
        Client = client;
        }
        
        
        private Guid _codeAnimal;
        [Persist(System.Data.SqlDbType.UniqueIdentifier, Persist.FieldBehaviour.pk)]
        public Guid CodeAnimal
        {
            get { return _codeAnimal; }
            private set { _codeAnimal = value; }
        }

        private string _nomAnimal;
        [Persist(SqlDbType.VarChar)]
        public string NomAnimal
        {
            get { return _nomAnimal; }
            set { _nomAnimal = value; }
        }

        public enum eSexe
	{M, F, H }

        private eSexe _sexe;
        [Persist(SqlDbType.Char)]
        public eSexe Sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }

        private string _couleur;
        [Persist(SqlDbType.VarChar)]
        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        


        private string _race_;
        [Persist(SqlDbType.VarChar)]
        public string Race_
        {
            get { return _race_; }
            private set { _race_ = value; }
        }

        private string _espece;
        [Persist(SqlDbType.VarChar)]
        public string Espece
        {
            get { return _espece; }
            set { _espece = value; }
        }

        private ulong _codeClient;
        [Persist(SqlDbType.UniqueIdentifier)]
        public ulong CodeClient
        {
            get { return _codeClient; }
            set { _codeClient = value; }
        }

        private string _tatouage;
        [Persist(SqlDbType.VarChar)]
        public string Tatouage
        {
            get { return _tatouage; }
            set { _tatouage = value; }
        }

        private string _antecedant;
        [Persist(SqlDbType.VarChar)]
        public string Antecedant
        {
            get { return _antecedant; }
            set { _antecedant = value; }
        }

        private Boolean _archive;
        [Persist(SqlDbType.Bit)]
        public Boolean Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        private Client _client;
        
        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }


        private Race _race;

        public Race Race
        {
            get { return _race; }
            set { 
                    _race = value;
                    Race_ = _race.Race_;
                    Espece = _race.Espece;
                }
        }


    }
}
