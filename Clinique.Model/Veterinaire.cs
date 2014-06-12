using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;
using System.Data;

namespace Clinique.Model
{
    [Persist("Veterinaires")]
    public class Veterinaire
    {
        private Guid _codeVeto;

        [Persist(System.Data.SqlDbType.UniqueIdentifier, Persist.FieldBehaviour.pk)]
        public Guid CodeVeto
        {
            get { return _codeVeto; }
            set { _codeVeto = value; }
        }

        private string  _nomVeto;
        [Persist(System.Data.SqlDbType.VarChar)]
        public string  NomVeto
        {
            get { return _nomVeto; }
            set { _nomVeto = value; }
        }

        private string _motDePasse;
        [Persist(System.Data.SqlDbType.VarChar)]
        public string MotDePasse
        {
            get { return _motDePasse; }
            set { _motDePasse = value; }
        }

        private bool _archive;
        [Persist(System.Data.SqlDbType.Bit)]
        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

    }
}
