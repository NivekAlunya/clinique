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

        /// <summary>
        /// Constructeur Client
        /// </summary>
        /// <param name="codeClient"></param>
        /// <param name="nomClient"></param>
        /// <param name="prenomClient"></param>
        /// <param name="adresse1"></param>
        /// <param name="adresse2"></param>
        /// <param name="codePostal"></param>
        /// <param name="ville"></param>
        /// <param name="numTel"></param>
        /// <param name="assurance"></param>
        /// <param name="email"></param>
        /// <param name="remarque"></param>
        /// <param name="archive"></param>
        /// <exception cref="Exception">raise exception on exception properties</exception>
        public Client(Guid codeClient, string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
            try
            {
                CodeClient = codeClient;
                NomClient = nomClient;
                PrenomClient = prenomClient;
                Adresse1 = adresse1;
                Adresse2 = adresse2;
                CodePostal = codePostal;
                Ville = ville;
                NumTel = numTel;
                Assurance = assurance;
                Email = email;
                Remarque = remarque;
                Archive = archive;
            }
            catch (Exception e)
            {
                throw new Exception("Ce client ne peut être cree avec ces valeurs.\n" + e.Message,e);
            }
        }
        

        private Guid _codeClient;
        [Persist(System.Data.SqlDbType.UniqueIdentifier, Persist.FieldBehaviour.pk)]
        public Guid CodeClient
        {
            get { return _codeClient; }
            private set { _codeClient = value; }
        }

        private string _nomClient;
        /// <summary>
        /// Property NomClient
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string NomClient
        {
            get { return _nomClient; }
            set {
                if (null != value && value.Trim().isEmptyOrGreaterThan(20)) throw new Exception("Le nom du client ne peut être vide ou ne contenir que des espace et ne doit pas depasser 20 caracteres.");
                _nomClient = value.Trim(); 
            }
        }

        private string _prenomClient;
        /// <summary>
        /// Property PrenomClient
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string PrenomClient
        {
            get { return _prenomClient; }
            set {
                if (null != value && value.Trim().isEmptyOrGreaterThan(20)) throw new Exception("Le prenom du client ne peut être vide ou ne contenir que des espace et ne doit pas depasser 20 caracteres.");
                _prenomClient = value.Trim(); 
            }
        }

        private string _adresse1;
        /// <summary>
        /// Property Adresse1
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string Adresse1
        {
            get { return _adresse1; }
            set {
                if (null != value && value.isGreaterThan(30)) throw new Exception("L'adresse du client ne peut avoir plus de 30 caracteres");
                _adresse1 = value; 
            }
        }

        private string _adresse2;
        /// <summary>
        /// Property Adresse2
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string Adresse2
        {
            get { return _adresse2; }
            set {
                if (null != value && value.isGreaterThan(30)) throw new Exception("L'adresse du client ne peut avoir plus de 30 caracteres");
                _adresse2 = value;
            }
        }

        private string _codePostal;
        /// <summary>
        /// Property CodePostal
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string CodePostal
        {
            get { return _codePostal; }
            set {
                if (null != value && value.Trim().isGreaterThan(30)) throw new Exception("Le code postal du client ne peut avoir plus de 6 caracteres");
                _codePostal = value.Trim(); 
            }
        }

        private string _ville;
        /// <summary>
        /// Property Ville
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string Ville
        {
            get { return _ville; }
            set {
                if (null != value && value.Trim().isGreaterThan(25)) throw new Exception("La ville du client ne peut avoir plus de 25 caracteres");
                _ville = value;
                
            }
        }

        private string _numTel;
        /// <summary>
        /// Property NumTel
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string NumTel
        {
            get { return _numTel; }
            set {
                if (null != value && value.Trim().isGreaterThan(15)) throw new Exception("Le numero de telephone  du client ne peut avoir plus de 15 caracteres");
                _numTel = value; 
            }
        }

        private string _assurance;
        /// <summary>
        /// Property Assurance
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string Assurance
        {
            get { return _assurance; }
            set {
                if (null != value && value.Trim().isGreaterThan(30)) throw new Exception("L'assurance du client ne peut avoir plus de 30 caracteres");
                _assurance = value; 
            }
        }

        private string _email;
        /// <summary>
        /// Property Email
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string Email
        {
            get { return _email; }
            set {
                if (null != value && value.Trim().isGreaterThan(20)) throw new Exception("L'email du client ne peut avoir plus de 20 caracteres");
                _email = value; 
            }
        }

        private string _remarque;
        /// <summary>
        /// Property Remarque
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string Remarque
        {
            get { return _remarque; }
            set {
                if (null != value && value.isGreaterThan(8000)) throw new Exception("Les remarques du client ne peut avoir plus de 8000 caracteres");
                _remarque = value; 
            }
        }

        private Boolean _archive;
        [Persist(SqlDbType.Bit)]
        public Boolean Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }
    }
}
