using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;
using System.Data;

namespace Clinique.Model
{
    [Persist("LignesConsultations")]
    public class LigneConsultation
    {
        private Consultation _consultation;
        
        public Consultation  Consultation
        {
            get { return _consultation; }
            set { _consultation = value; CodeConsultation = _consultation.CodeConsultation;}
        }
        
        private Guid _codeConsultation;
        [Persist(SqlDbType.UniqueIdentifier,Persist.FieldBehaviour.pk)]
        public Guid CodeConsultation
        {
            get { return _codeConsultation; }
            private set { _codeConsultation = value; }
        }

        private Guid _numLigne;

        [Persist(SqlDbType.UniqueIdentifier,Persist.FieldBehaviour.pk)]
        public Guid NumLigne
        {
            get { return _numLigne; }
            private set { _numLigne = value; }
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

        private string _dateVigueur;
        [Persist(SqlDbType.VarChar)]
        public string DateVigueur
        {
            get { return _dateVigueur; }
            set { _dateVigueur = value; }
        }

        private decimal _prix;
        [Persist(SqlDbType.Money)]
        public decimal Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        private bool _rappelEnvoye;
        [Persist(SqlDbType.Bit)]
        public bool RappelEnvoye
        {
            get { return _rappelEnvoye; }
            set { _rappelEnvoye = value; }
        }

        private bool _archive;
        [Persist(SqlDbType.Bit)]
        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        public LigneConsultation(Guid numLigne,Consultation consultation,Bareme bareme,bool archive ,string dateVigueur,decimal prix,bool rappelEnvoye)
        { 
            Bareme = bareme;
            Archive = archive;
            Consultation = consultation;
            DateVigueur = dateVigueur;
            NumLigne = numLigne;
            Prix = prix;
            RappelEnvoye = rappelEnvoye;
        }
        

    }
}
