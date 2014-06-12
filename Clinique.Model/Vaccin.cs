using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;

namespace Clinique.Model
{
    [Persist("Vaccins")]
    public class Vaccin
    {
        private Guid _codeVaccin;
        [Persist(System.Data.SqlDbType.UniqueIdentifier,Persist.FieldBehaviour.pk)]
        public Guid CodeVaccin
        {
            get { return _codeVaccin; }
            set { _codeVaccin = value; }
        }

        private string _nomVaccin;

        [Persist(System.Data.SqlDbType.VarChar)]
        public string NomVaccin
        {
            get { return _nomVaccin; }
            set { _nomVaccin = value; }
        }

        private int _quantiteStock;

        [Persist(System.Data.SqlDbType.Int)]
        public int QuantiteStock
        {
            get { return _quantiteStock; }
            set { _quantiteStock = value; }
        }

        private byte _periodeValidite;

        [Persist(System.Data.SqlDbType.Char)]
        public byte PeriodeValidite
        {
            get { return _periodeValidite; }
            set { _periodeValidite = value; }
        }

        private bool _archive ;

        [Persist(System.Data.SqlDbType.Bit)]
        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }
    }
}
