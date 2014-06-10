using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    class Clients
    {
        private int _CodeClient;

        public int CodeClient
        {
            get { return _CodeClient; }
            set { _CodeClient = value; }
        }

        private string _NomClient;

        public string NomClient
        {
            get { return _NomClient; }
            set { _NomClient = value; }
        }

        private string _PrenomClient;

        public string PrenomClient
        {
            get { return _PrenomClient; }
            set { _PrenomClient = value; }
        }

        private string _Adresse1;

        public string Adresse1
        {
            get { return _Adresse1; }
            set { _Adresse1 = value; }
        }

        private string _Adresse2;

        public string Adresse2
        {
            get { return _Adresse2; }
            set { _Adresse2 = value; }
        }

        private string _CodePostal;

        public string CodePostal
        {
            get { return _CodePostal; }
            set { _CodePostal = value; }
        }

        private string _Ville;

        public string Ville
        {
            get { return _Ville; }
            set { _Ville = value; }
        }

        
        private string _NumTel;

        public string NumTel
        {
            get { return _NumTel; }
            set { _NumTel = value; }
        }

        private string _Assurance;

        public string Assurance
        {
            get { return _Assurance; }
            set { _Assurance = value; }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _Remarque;

        public string Remarque
        {
            get { return _Remarque; }
            set { _Remarque = value; }
        }

        private Boolean _Archive;

        public Boolean Archive
        {
            get { return _Archive; }
            set { Boolean _Archive = value; }
        }
        


    }
}
