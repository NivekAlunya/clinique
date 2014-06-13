using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Tools;
using System.Data;

namespace Clinique.Model
{
    [Persist("Factures")]
    public class Facture
    {

        public Facture()
        {
        
        }

       
        private Guid _numFacture;
        [Persist(SqlDbType.UniqueIdentifier,Persist.FieldBehaviour.pk)]
        public Guid NumFacture
        {
            get { return _numFacture; }
            set { _numFacture = value; }
        }

        private DateTime _dateFacture;

        [Persist(SqlDbType.DateTime)]
        public DateTime DateFacture
        {
            get { return _dateFacture; }
            set { _dateFacture = value; }
        }

        private Client _client;

        public Client Client
        {
            get { return _client; }
            set { 
                _client = value;
                CodeClient = _client.CodeClient;
            }
        }
        

        private Guid _codeClient;

        [Persist(SqlDbType.UniqueIdentifier)]
        public Guid CodeClient
        {
            get { return _codeClient; }
            private set { _codeClient = value; }
        }


        private decimal _totalFacture;
        [Persist(SqlDbType.Money)]
        public decimal TotalFacture
        {
            get { return _totalFacture; }
            set { _totalFacture = value; }
        }

        private bool _archive;

        [Persist(SqlDbType.Bit)]
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

        [Persist(SqlDbType.TinyInt)]
        public eFactureEtats Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        private DateTime _rappelEnvoye;

        [Persist(SqlDbType.DateTime)]
        public DateTime RappelEnvoye
        {
            get { return _rappelEnvoye; }
            set { _rappelEnvoye = value; }
        }

        public Facture(Guid numFacture,Client client,DateTime dateFacture,eFactureEtats etat, decimal totalFacture,DateTime rappelEnvoye,bool archive)
        {
            NumFacture =  numFacture;
            Client = client;
            DateFacture = dateFacture;
            Etat = etat;
            TotalFacture = totalFacture;
            RappelEnvoye = rappelEnvoye;
            Archive = archive;
        }


    }
}
