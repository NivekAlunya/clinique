using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class LigneConsultation
    {
        private Consultation _consultation;

        public Consultation  Consultation
        {
            get { return _consultation; }
            set { _consultation = value; }
        }
        
        private int _codeConsultation;

        public int CodeConsultation
        {
            get { return _codeConsultation; }
            set { _codeConsultation = value; }
        }

        private int _numLigne;

        public int NumLigne
        {
            get { return _numLigne; }
            set { _numLigne = value; }
        }

        private Bareme _bareme;

        public Bareme Bareme
        {
            get { return _bareme; }
            set { _bareme = value; }
        }
        
        private string _codeGroupement;

        public string CodeGroupement
        {
            get { return _codeGroupement; }
            set { _codeGroupement = value; }
        }

        private string _dateVigueur;

        public string DateVigueur
        {
            get { return _dateVigueur; }
            set { _dateVigueur = value; }
        }

        private decimal _prix;

        public decimal Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        private bool _rappelEnvoye;

        public bool RappelEnvoye
        {
            get { return _rappelEnvoye; }
            set { _rappelEnvoye = value; }
        }

        private bool _archive;

        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        

    }
}
