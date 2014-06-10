using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    class Animaux
    {
        private int _CodeAnimal;

        public int CodeAnimal
        {
            get { return _CodeAnimal; }
            set { _CodeAnimal = value; }
        }

        private string _NomAnimal;

        public string NomAnimal
        {
            get { return _NomAnimal; }
            set { _NomAnimal = value; }
        }

        enum eSexe
	{M, F, H }

        private eSexe _Sexe;

        public eSexe Sexe
        {
            get { return _Sexe; }
            set { _Sexe = value; }
        }

        private string _Couleur;

        public string Couleur
        {
            get { return _Couleur; }
            set { string _Couleur = value; }
        }

        private string _Race;

        public string Race
        {
            get { return _Race; }
            set { string _Race = value; }
        }

        private string _Espece;

        public string Espece
        {
            get { return _Espece; }
            set { _Espece = value; }
        }

        private ulong _CodeClient;

        public ulong CodeClient
        {
            get { return _CodeClient; }
            set { _CodeClient = value; }
        }

        private string _Tatouage;

        public string Tatouage
        {
            get { return _Tatouage; }
            set { _Tatouage = value; }
        }

        private string _Antecedant;

        public string Antecedant
        {
            get { return _Antecedant; }
            set { _Antecedant = value; }
        }

        private Boolean _Archive;

        public Boolean Archive
        {
            get { return _Archive; }
            set { _Archive = value; }
        }
        

    }
}
