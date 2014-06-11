using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Client
    {
        
        public Client( int codeClient, string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
           CodeClient = codeClient;
           NomClient = nomClient;
           PrenomClient=prenomClient;
           Adresse1 = adresse1;
           Adresse2=adresse2;
           CodePostal=codePostal;
           Ville = ville;
           NumTel = numTel;
           Assurance = assurance;
           Email = email;
           Remarque = remarque;
            Archive = archive;
        }
        

        private int _codeClient;
        
        public int CodeClient
        {
            get { return _codeClient; }
            private set {_codeClient = value; }
        }

       

        private string _nomClient;

        public string NomClient
        {
            get { return _nomClient; }
            set { _nomClient = value; }
        }

        private string _prenomClient;

        public string PrenomClient
        {
            get { return _prenomClient; }
            set { _prenomClient = value; }
        }

        private string _adresse1;

        public string Adresse1
        {
            get { return _adresse1; }
            set { _adresse1 = value; }
        }

        private string _adresse2;

        public string Adresse2
        {
            get { return _adresse2; }
            set { _adresse2 = value; }
        }

        private string _codePostal;

        public string CodePostal
        {
            get { return _codePostal; }
            set { _codePostal = value; }
        }

        private string _ville;

        public string Ville
        {
            get { return _ville; }
            set { _ville = value; }
        }

        
        private string _numTel;

        public string NumTel
        {
            get { return _numTel; }
            set { _numTel = value; }
        }

        private string _assurance;

        public string Assurance
        {
            get { return _assurance; }
            set { _assurance = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _remarque;

        public string Remarque
        {
            get { return _remarque; }
            set { _remarque = value; }
        }

        private Boolean _archive;

        public Boolean Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

    }
}
