using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Animal
    {
        private int _codeAnimal;

        public int CodeAnimal
        {
            get { return _codeAnimal; }
            set { _codeAnimal = value; }
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

        private string _race;

        public string Race
        {
            get { return _race; }
            set { _race = value; }
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
        

    }
}
