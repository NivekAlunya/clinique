using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Tools;
using System.Data;

namespace Clinique.Model
{
    [Persist("Veterinaires")]
    public class Veterinaire
    {
        #region attributes 
        private Guid _codeVeto;
        private string _nomVeto;
        private string _motPasse;
        private bool _archive;
        #endregion

        #region properties
        [Persist(System.Data.SqlDbType.UniqueIdentifier, Persist.FieldBehaviour.pk)]
        public Guid CodeVeto
        {
            get { return _codeVeto; }
            set { _codeVeto = value; }
        }

        /// <summary>
        /// Propriete NomVeto
        /// </summary>
        /// <exception cref="[Exception] Le mot de passe ne peut être nul ou contenir que des espaces"></exception>
        [Persist(System.Data.SqlDbType.VarChar)]
        public string  NomVeto
        {
            get { return _nomVeto; }
            set {
                if (null != value && value.Trim().isEmptyOrGreaterThan(30)) throw new Exception("Le nom du veterinaire ne peut être vide ou ne contenir que des espace et ne doit pas depasser 30 caracteres.");
                _nomVeto = value; 
            }
        }

        /// <summary>
        /// Propriete MotDePasse
        /// </summary>
        /// <exception cref="[Exception] Le mot de passe ne peut être nul ou contenir que des espaces"></exception>
        [Persist(System.Data.SqlDbType.VarChar,Persist.FieldBehaviour.common,"MotPasse")]
        public string MotDePasse
        {
            get { return _motPasse; }
            set {
                if (null != value && value.Trim().isEmptyOrGreaterThan(10)) throw new Exception("Le mot de passe ne peut être vide ou ne contenir que des espace et ne doit pas depasser 10 caracteres.");
                _motPasse = value; 
            }
        }

        /// <summary>
        /// Propriete Archive
        /// </summary>
        /// <exception cref="[Exception] Le mot de passe ne peut être nul ou contenir que des espaces"></exception>
        [Persist(System.Data.SqlDbType.Bit)]
        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }
        #endregion
        #region constructors
        /// <summary>
        /// Constructeur Veterinaire
        /// </summary>
        /// <param name="codeVeto"></param>
        /// <param name="nomVeto"></param>
        /// <param name="motDePasse"></param>
        /// <param name="archive"></param>
        /// <exception cref="[Exception] probleme sur affectation de valeur sur les proprietes"
        public Veterinaire(Guid codeVeto, string nomVeto, string motDePasse, bool archive = false)
        { 
            CodeVeto =  codeVeto;
            try
            {
                MotDePasse = motDePasse;
                NomVeto = nomVeto;
                Archive = archive;
            }
            catch (Exception e)
            {
                throw new Exception("Un veterinaire ne peut être cree avec ces valeurs", e);
            }
        }
        #endregion

    }
}
