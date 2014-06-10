using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Baremes
    {
        private string _CodeGroupement;

        public string CodeGoupement
        {
            get { return _CodeGroupement; }
            set { _CodeGroupement = value; }
        }

        private string _DateVigueur;

        public string DateVigueur
        {
            get { return _DateVigueur; }
            set { string _DateVigueur = value; }
        }

        enum eTypeActe
        {CONS, VACC, GYCA, CHIR, TATO, DIVE}

        private eTypeActe _TypeActe;

        public eTypeActe MyProperty
        {
            get { return _TypeActe; }
            set { _TypeActe = value; }
        }

        private string _Libelle;

        public string Libelle
        {
            get { return _Libelle; }
            set { _Libelle = value; }
        }

     
        
      
        
    }
}
