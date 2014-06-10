using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Facture
    {
        private int _numFacture;

        public int NumFacture
        {
            get { return _numFacture; }
            set { _numFacture = value; }
        }

        private DateTime _dateFacture;

        public DateTime DateFacture
        {
            get { return _dateFacture; }
            set { _dateFacture = value; }
        }

        private Client _client;

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }
        

        private int _codeClient;

        public int CodeClient
        {
            get { return _codeClient; }
            set { _codeClient = value; }
        }


        private decimal _totaFacture;

        public decimal TotaFacture
        {
            get { return _totaFacture; }
            set { _totaFacture = value; }
        }

        private bool _archive;

        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        public enum eFactureEtats { 
            a_imprimer,
            imprimee,
            payee
        }

        private eFactureEtats _etat;

        public eFactureEtats Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        private bool _rappelEnvoye;

        public bool RappelEnvoye
        {
            get { return _rappelEnvoye; }
            set { _rappelEnvoye = value; }
        }

    }
}
