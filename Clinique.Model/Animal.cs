using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Clinique.Tools;
using System.ComponentModel;
namespace Clinique.Model
{
    [Persist("Animaux")]
    public class Animal : INotifyPropertyChanged
    {

        /// <summary>
        /// Construteur Animal
        /// </summary>
        /// <param name="codeAnimal"></param>
        /// <param name="nomAnimal"></param>
        /// <param name="sexe"></param>
        /// <param name="couleur"></param>
        /// <param name="race"></param>
        /// <param name="tatouage"></param>
        /// <param name="antecedents"></param>
        /// <param name="archive"></param>
        /// <param name="client"></param>
        /// <exception cref="Exception"></exception>
        public Animal(Guid codeAnimal, string nomAnimal, eSexe sexe, string couleur, Race race,
             string tatouage, string antecedents, Boolean archive, Client client)
        {
            try
            {
                CodeAnimal = codeAnimal;
                NomAnimal = nomAnimal;
                Sexe = sexe;
                Couleur = couleur;
                Race = race;
                Tatouage = tatouage;
                Antecedents = antecedents;
                Archive = archive;
                Client = client;
            }
            catch (Exception e)
            {
                throw new Exception("Cet animal ne peut être cree avec ces valeurs\n" + e.Message, e);
            }

        }
        
        private Guid _codeAnimal;
        [Persist(System.Data.SqlDbType.UniqueIdentifier, Persist.FieldBehaviour.pk)]
        public Guid CodeAnimal
        {
            get { return _codeAnimal; }
            private set { _codeAnimal = value; }
        }

        private string _nomAnimal;
        /// <summary>
        /// Property NomAnimal
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string NomAnimal
        {
            get { return _nomAnimal; }
            set {
                if (null != value && value.Trim().isEmptyOrGreaterThan(30)) throw new Exception("Le nom de l'animal ne peut être vide ou ne contenir que des espace et ne doit pas depasser 30 caracteres.");
                _nomAnimal = value;
            }
        }

        public enum eSexe
	    {
            M = 'M', 
            F = 'F',
            H = 'H'
        }

        private eSexe _sexe;
        /// <summary>
        /// Property Sexe
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.Char)]
        public eSexe Sexe
        {
            get { return _sexe; }
            set {
                if(value != eSexe.F && value != eSexe.H && value != eSexe.M) throw new Exception("Le sexe de l'animal ne peut être différent de 'H' ou 'F' ou 'M'");    
                _sexe = value;
            }
        }

        private string _couleur;
        /// <summary>
        /// Property Couleur
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string Couleur
        {
            get { return _couleur; }
            set {
                if (null != value && value.Trim().isGreaterThan(20)) throw new Exception("La couleur de l'animal ne doit pas depasser 20 caracteres.");
                _couleur = value; }
        }

        private string _race_;
        [Persist(SqlDbType.VarChar,Persist.FieldBehaviour.common,"Race")]
        public string Race_
        {
            get { return _race_; }
            private set {
                _race_ = value;
            }
        }

        private string _espece;
        [Persist(SqlDbType.VarChar)]
        public string Espece
        {
            get { return _espece; }
            set {
                _espece = value;
            }
        }

        private Guid _codeClient;
        [Persist(SqlDbType.UniqueIdentifier)]
        public Guid CodeClient
        {
            get { return _codeClient; }
            set {
                
                _codeClient = value; }
        }

        private string _tatouage;
        /// <summary>
        /// Property Tatouage
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string Tatouage
        {
            get { return _tatouage; }
            set {
                if (null != value && value.Trim().isGreaterThan(10)) throw new Exception("Le tatouage ne doit pas depasser 10 caracteres.");   
                _tatouage = value; }
        }

        private string _antecedents;
        /// <summary>
        /// Property Antecedents
        /// </summary>
        /// <exception cref="Exception"></exception>
        [Persist(SqlDbType.VarChar)]
        public string Antecedents
        {
            get { return _antecedents; }
            set
            {
                if (null != value && value.Trim().isGreaterThan(8000)) throw new Exception("Les antecedents ne peuvent depasser 8000 caracteres.");
                _antecedents = value; }
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

            set { 
                _client = value;
                CodeClient = _client.CodeClient;
            }
        }

        private Race _race;
        /// <summary>
        /// Affect un object Race a l'animal
        /// </summary>
        /// <exception cref="Exception"></exception>
        public Race Race
        {
            get { return _race; }
            set {
                    if (value == null) throw new Exception("Une race et espece doivent etre fournis");
                    _race = value;
                    Race_ = _race.Race_;
                    Espece = _race.Espece;
                }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
