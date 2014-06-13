﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Tools;
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

        private string _motPasse;
        [Persist(System.Data.SqlDbType.VarChar)]
        public string MotPasse
        {
            get { return _motPasse; }
            set { _motPasse = value; }
        }

        private bool _archive;
        [Persist(System.Data.SqlDbType.Bit)]
        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        public Veterinaire(Guid codeVeto, string nomVeto, string motDePasse, bool archive)
        { 
            CodeVeto =  codeVeto;
            MotPasse = motDePasse;
            NomVeto = nomVeto;
            Archive = archive;
        }

    }
}
