using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;
using System.Data;

namespace Clinique.Model
{
    public class Agenda
    {
        private Veterinaire _veto;

        public Veterinaire Veto
        {
            get { return _veto; }
            set { 
                _veto = value;
                CodeVeto = _veto.CodeVeto;
            }
        }

        private Guid _codeVeto;
        [Persist(SqlDbType.UniqueIdentifier,Persist.FieldBehaviour.pk)]
        public Guid CodeVeto
        {
            get { return _codeVeto; }
            private set { _codeVeto = value; }
        }


        private DateTime _dateRdv;

        [Persist(SqlDbType.DateTime, Persist.FieldBehaviour.pk)]
        public DateTime DateRdv
        {
            get { return _dateRdv; }
            set { _dateRdv = value; }
        }

        private Animal _animal;

        public Animal Animal
        {
            get { return _animal; }
            set { 
                _animal = value;
                CodeAnimal = _animal.CodeAnimal;
            }
        }
        
        private Guid _codeAnimal;

        [Persist(SqlDbType.UniqueIdentifier, Persist.FieldBehaviour.pk)]
        public Guid CodeAnimal
        {
            get { return _codeAnimal; }
            private set { _codeAnimal = value; }
        }

        public Agenda(Veterinaire veto,Animal animal, DateTime dateRdv)
        { 
            Veto = veto;
            Animal = animal;
            DateRdv = dateRdv;
        }

    }
}
