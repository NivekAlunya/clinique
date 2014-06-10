using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Vaccin
    {
        private int _codeVaccin;

        public int CodeVaccin
        {
            get { return _codeVaccin; }
            set { _codeVaccin = value; }
        }

        private string _nomVaccin;

        public string NomVaccin
        {
            get { return _nomVaccin; }
            set { _nomVaccin = value; }
        }

        private int _quantiteStock;

        public int QuantiteStock
        {
            get { return _quantiteStock; }
            set { _quantiteStock = value; }
        }

        private byte _periodeValidite;

        public byte PeriodeValidite
        {
            get { return _periodeValidite; }
            set { _periodeValidite = value; }
        }

        private bool _archive ;

        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }
        
    }
}
