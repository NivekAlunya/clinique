using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Bareme
    {
        private string _codeGroupement;

        public string CodeGoupement
        {
            get { return _codeGroupement; }
            set { _codeGroupement = value; }
        }

        private string _dateVigueur;

        public string DateVigueur
        {
            get { return _dateVigueur; }
            set { _dateVigueur = value; }
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
      
        
    }
}
