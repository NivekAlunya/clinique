using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Bareme
    {
        public Bareme(string codeGroupement, string dateVigueur, eTypeActe typeActe, string libelle, int codeVaccin,
            Vaccin vaccin)
        {
        CodeGroupement = codeGroupement;
        DateVigueur = dateVigueur;
        TypeActe = typeActe;
        Libelle = libelle;
        CodeVaccin = codeVaccin;
        Vaccin = vaccin;
        }

        private string _codeGroupement;

        public string CodeGroupement
        {
            get { return _codeGroupement; }
            private set { _codeGroupement = value; }
        }

        private string _dateVigueur;

        public string DateVigueur
        {
            get { return _dateVigueur; }
            private set { _dateVigueur = value; }
        }

        public enum eTypeActe
        {CONS, VACC, GYCA, CHIR, TATO, DIVE}

        private eTypeActe _typeActe;

        public eTypeActe TypeActe
        {
            get { return _typeActe; }
            set { _typeActe = value; }
        }

        private string _libelle;

        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        private int _codeVaccin;

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
        
    }
}
