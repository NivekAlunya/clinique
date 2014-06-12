using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;
using System.Data;

namespace Clinique.Model
{
    [Persist("LignesFactures")]
    public class LigneFacture
    {
        private Facture _facture;

        public Facture Facture
        {
            get { return _facture; }
            set { 
                _facture = value;
                NumFacture = _facture.NumFacture;
            }
        }
        
        private Guid _numFacture;
        [Persist(SqlDbType.UniqueIdentifier)]
        public Guid NumFacture
        {
            get { return _numFacture; }
            private set { _numFacture = value; }
        }

        private Guid _numLigne;
        [Persist(SqlDbType.UniqueIdentifier,Persist.FieldBehaviour.pk)]
        public Guid NumLigne
        {
            get { return _numLigne; }
            set { _numLigne = value; }
        }

        private Bareme _bareme;

        public Bareme Bareme
        {
            get { return _bareme; }
            set { 
                _bareme = value;
                CodeGroupement = _bareme.CodeGroupement;
            }
        }

        private string _codeGroupement;
        [Persist(SqlDbType.VarChar)]
        public string CodeGroupement
        {
            get { return _codeGroupement; }
            private set { _codeGroupement = value; }
        }

        private decimal _prix;

        [Persist(SqlDbType.Money)]
        public decimal Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        private bool _archive;

        [Persist(SqlDbType.Bit)]
        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        public LigneFacture(Guid numLigne,Facture facture,Bareme bareme,decimal prix,bool archive)
        {
            Bareme = bareme;
            Facture = facture;
            NumLigne = numLigne;
            Prix = prix;
            Archive = archive;
        }

    }
}
