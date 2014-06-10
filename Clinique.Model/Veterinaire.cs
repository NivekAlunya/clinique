using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Veterinaire
    {
        private int _codeVeto;

        public int CodeVeto
        {
            get { return _codeVeto; }
            set { _codeVeto = value; }
        }

        private string  _nomVeto;

        public string  NomVeto
        {
            get { return _nomVeto; }
            set { _nomVeto = value; }
        }


        private string _motDePasse;

        public string MotDePasse
        {
            get { return _motDePasse; }
            set { _motDePasse = value; }
        }

        private bool _archive;

        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

    }
}
