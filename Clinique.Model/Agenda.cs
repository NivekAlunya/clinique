using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Agenda
    {
        private Veterinaire _veto;

        public Veterinaire Veto
        {
            get { return _veto; }
            set { _veto = value; }
        }
        
        private int _codeVeto;

        public int CodeVeto
        {
            get { return _codeVeto; }
            set { _codeVeto = value; }
        }


        private DateTime _dateRdv;

        public DateTime DateRdv
        {
            get { return _dateRdv; }
            set { _dateRdv = value; }
        }

        private Animal _animal;

        public Animal Animal
        {
            get { return _animal; }
            set { _animal = value; }
        }
        

        private int _codeAnimal;

        public int CodeAnimal
        {
            get { return _codeAnimal; }
            set { _codeAnimal = value; }
        }


    }
}
