using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Tools;
using System.Data;

namespace Clinique.Model
{
    [Persist("Agendas")]
    public class Agenda
    {
        private Veterinaire _veto;

        public Veterinaire Veto
        {
            get { return _veto; }
            set {
                if (null == value) throw new Exception("Le veterinaire doit être renseigné pour définir un rendez-vous");
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

        [Persist(SqlDbType.SmallDateTime, Persist.FieldBehaviour.pk)]
        public DateTime DateRdv
        {
            get { return _dateRdv; }
            set {
                if (null == value || DateTime.Now.ToUniversalTime() >= value) throw new Exception("La date de rendez-vous doit-être renseignée et ne peut être définie dans le passée");  
                _dateRdv = value; }
        }

        private Animal _animal;

        public Animal Animal
        {
            get { return _animal; }
            set {
                if (null == value) throw new Exception("Un animal doit être renseigné pour définir un rendez-vous");
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
