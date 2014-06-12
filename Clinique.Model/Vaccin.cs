using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;
using System.Data;

namespace Clinique.Model
{
    [Persist("Vaccins")]
    public class Vaccin
    {
        public Vaccin(Guid codeVaccin, string nomVaccin, int quantiteStock, byte periodeValidite, bool archive)
        {
        CodeVaccin = codeVaccin;
        NomVaccin = nomVaccin;
        QuantiteStock = quantiteStock;
        PeriodeValidite = periodeValidite;
        Archive = archive;
        }

        private Guid _codeVaccin;
        [Persist(SqlDbType.UniqueIdentifier,Persist.FieldBehaviour.pk)]
        public Guid CodeVaccin
        {
            get { return _codeVaccin; }
            set { _codeVaccin = value; }
        }

        private string _nomVaccin;

        [Persist(SqlDbType.VarChar)]
        public string NomVaccin
        {
            get { return _nomVaccin; }
            set { _nomVaccin = value; }
        }

        private int _quantiteStock;

        [Persist(SqlDbType.Int)]
        public int QuantiteStock
        {
            get { return _quantiteStock; }
            set { _quantiteStock = value; }
        }

        private byte _periodeValidite;

        [Persist(SqlDbType.Char)]
        public byte PeriodeValidite
        {
            get { return _periodeValidite; }
            set { _periodeValidite = value; }
        }

        private bool _archive ;

        [Persist(SqlDbType.Bit)]
        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }
    }
}
