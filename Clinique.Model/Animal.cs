using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Animal
    {

        public Animal(int codeAnimal, string nomAnimal, eSexe sexe, string couleur, string race, string espece,
            ulong codeClient, string tatouage, string antecedant, Boolean archive, Client client)
        {
        CodeAnimal = codeAnimal;
        NomAnimal = nomAnimal;
        Sexe = sexe;
        Couleur = couleur;
        Race_ = race;
        Espece = espece;
        CodeClient = codeClient;
        Tatouage = tatouage;
        Antecedant = antecedant;
        Archive = archive;
        Client = client;
        }
        
        
        private int _codeAnimal;

        public int CodeAnimal
        {
            get { return _codeAnimal; }
            private set { _codeAnimal = value; }
        }

        private string _nomAnimal;

        public string NomAnimal
        {
            get { return _nomAnimal; }
            set { _nomAnimal = value; }
        }

        public enum eSexe
	{M, F, H }

        private eSexe _sexe;

        public eSexe Sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }

        private string _couleur;

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        


        private string _race_;

        public string Race_
        {
            get { return _race_; }
            set { _race_ = value; }
        }

        private string _espece;

        public string Espece
        {
            get { return _espece; }
            set { _espece = value; }
        }

        private ulong _codeClient;

        public ulong CodeClient
        {
            get { return _codeClient; }
            set { _codeClient = value; }
        }

        private string _tatouage;

        public string Tatouage
        {
            get { return _tatouage; }
            set { _tatouage = value; }
        }

        private string _antecedant;

        public string Antecedant
        {
            get { return _antecedant; }
            set { _antecedant = value; }
        }

        private Boolean _archive;

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
            set { _race = value;}
        }


    }
}
