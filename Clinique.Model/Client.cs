using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Clinique.Tools;

namespace Clinique.Model
{
    [Persist("Clients")]
    public class Client
    {
        public Client()
        { 
        
        }


        public Client( Guid codeClient, string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
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
        

        private Guid _codeClient;
        [Persist(System.Data.SqlDbType.UniqueIdentifier, Persist.FieldBehaviour.pk)]
        public Guid CodeClient
        {
            get { return _codeClient; }
            private set {_codeClient = value; }
        }

       

        private string _nomClient;
        [Persist(SqlDbType.VarChar)]
        public string NomClient
        {
            get { return _nomClient; }
            set { _nomClient = value; }
        }

        private string _prenomClient;
        [Persist(SqlDbType.VarChar)]
        public string PrenomClient
        {
            get { return _prenomClient; }
            set { _prenomClient = value; }
        }

        private string _adresse1;
        [Persist(SqlDbType.VarChar)]
        public string Adresse1
        {
            get { return _adresse1; }
            set { _adresse1 = value; }
        }

        private string _adresse2;
        [Persist(SqlDbType.VarChar)]
        public string Adresse2
        {
            get { return _adresse2; }
            set { _adresse2 = value; }
        }

        private string _codePostal;
        [Persist(SqlDbType.VarChar)]
        public string CodePostal
        {
            get { return _codePostal; }
            set { _codePostal = value; }
        }

        private string _ville;
        [Persist(SqlDbType.VarChar)]
        public string Ville
        {
            get { return _ville; }
            set { _ville = value; }
        }

        
        private string _numTel;
        [Persist(SqlDbType.VarChar)]
        public string NumTel
        {
            get { return _numTel; }
            set { _numTel = value; }
        }

        private string _assurance;
        [Persist(SqlDbType.VarChar)]
        public string Assurance
        {
            get { return _assurance; }
            set { _assurance = value; }
        }

        private string _email;
        [Persist(SqlDbType.VarChar)]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _remarque;
        [Persist(SqlDbType.VarChar)]
        public string Remarque
        {
            get { return _remarque; }
            set { _remarque = value; }
        }

        private Boolean _archive;
        [Persist(SqlDbType.Bit)]
        public Boolean Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        /// <summary>
        /// Tri par défaut
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public int CompareTo(Client client)
        {
            return CompareParNom(this, client);
        }

        public static int CompareParNom(Client client1, Client client2)
        {
            int functionReturnValue = 0;
            functionReturnValue = client1.NomClient.CompareTo(client2.NomClient);

            return functionReturnValue;

        }


    }
}
