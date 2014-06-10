using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class LigneFacture
    {
        private Facture _facture;

        public Facture Facture
        {
            get { return _facture; }
            set { _facture = value; }
        }
        
        private int _numFacture;

        public int NumFacture
        {
            get { return _numFacture; }
            set { _numFacture = value; }
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

        private decimal _prix;

        public decimal Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        private bool _archive;

        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

    }
}
