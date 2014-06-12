using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Clinique.Store;

namespace Clinique.Model
{
    [Persist("Connexions")]
    public class Bareme
    {
        public Bareme(string codeGroupement, string dateVigueur, eTypeActe typeActe, string libelle,
            decimal tarifFixe, decimal tarifMini, decimal tarifMaxi, Vaccin vaccin)
        {
        CodeGroupement = codeGroupement;
        DateVigueur = dateVigueur;
        TypeActe = typeActe;
        Libelle = libelle;
        TarifFixe = tarifFixe;
        TarifMaxi = tarifMaxi;
        TarifMini = tarifMini;
        Vaccin = vaccin;
        }

        private string _codeGroupement;
        [Persist(System.Data.SqlDbType.VarChar, Persist.FieldBehaviour.pk)]
        public string CodeGroupement
        {
            get { return _codeGroupement; }
            private set { _codeGroupement = value; }
        }

        private string _dateVigueur;
        [Persist(System.Data.SqlDbType.VarChar, Persist.FieldBehaviour.pk)]
        public string DateVigueur
        {
            get { return _dateVigueur; }
            private set { _dateVigueur = value; }
        }

        public enum eTypeActe
        {CONS, VACC, GYCA, CHIR, TATO, DIVE}

        private eTypeActe _typeActe;
        [Persist(SqlDbType.VarChar)]
        public eTypeActe TypeActe
        {
            get { return _typeActe; }
            set { _typeActe = value; }
        }

        private string _libelle;
        [Persist(SqlDbType.VarChar)]
        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        private int _codeVaccin;
        [Persist(SqlDbType.BigInt)]
        public int CodeVaccin
        {
            get { return _codeVaccin; }
            set { _codeVaccin = value; }
        }

        private Vaccin _vaccin;

        public Vaccin Vaccin
        {
            get { return _vaccin; }
            set { _vaccin = value; }
        }

        private decimal _tarifFixe;
        [Persist(SqlDbType.Money)]
        public decimal TarifFixe
        {
            get { return _tarifFixe; }
            set { _tarifFixe = value; }
        }

        private decimal _tarifMini;
        [Persist(SqlDbType.Money)]
        public decimal TarifMini
        {
            get { return _tarifMini; }
            set { _tarifMini = value; }
        }

        private decimal _tarifMaxi;
        [Persist(SqlDbType.Money)]
        public decimal TarifMaxi
        {
            get { return _tarifMaxi; }
            set { _tarifMaxi = value; }
        }
    }
}
