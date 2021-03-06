﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Tools;
using System.Data;

namespace Clinique.Model
{
    [Persist("Consultations")]
    public class Consultation
    {
        private Guid _codeConsultation;
        [Persist(SqlDbType.UniqueIdentifier,Persist.FieldBehaviour.pk)]
        public Guid CodeConsultation
        {
            get { return _codeConsultation; }
            set { _codeConsultation = value; }
        }

        private DateTime _dateConsultation;

        [Persist(SqlDbType.DateTime)]
        public DateTime DateConsultation
        {
            get { return _dateConsultation; }
            set { _dateConsultation = value; }
        }

        private Veterinaire _veto;

        public Veterinaire Veto
        {
            get { return _veto; }
            set { 
                _veto = value; 
                CodeVeto = _veto.CodeVeto;
            }
        }
        
        private Guid _codeVeto;
        [Persist(SqlDbType.UniqueIdentifier)]
        public Guid CodeVeto
        {
            get { return _codeVeto; }
            private set { _codeVeto = value; }
        }

        private Animal _animal;

        public Animal Animal
        {
            get { return _animal; }
            set { 
                _animal = value; 
                CodeAnimal = _animal.CodeAnimal;
            }
        }
        

        private Guid _codeAnimal;
        [Persist(SqlDbType.UniqueIdentifier)]
        public Guid CodeAnimal
        {
            get { return _codeAnimal; }
            private set { _codeAnimal = value; }
        }

        private string _commentaire;

        [Persist(SqlDbType.VarChar)]
        public string Commentaire
        {
            get { return _commentaire; }
            set { _commentaire = value; }
        }

        public enum eConsultationEtat
        {
            en_cours_de_saisie,
            saisie_veterinaire_terminee_facturation_possible,
            facture_generee
        }

        private eConsultationEtat _etat;
        
        [Persist(SqlDbType.TinyInt)]
        public eConsultationEtat Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        private Facture _facture;
        public Facture Facture
        {
            get { return _facture; }
            set { 
                _facture = value;
                NumFacture = (null == _facture) ? Guid.Empty : _facture.NumFacture;
            }
        }

        private Guid _numFacture;

        [Persist(SqlDbType.UniqueIdentifier)]
        public Guid NumFacture
        {
            get { return _numFacture; }
            private set { 
                _numFacture = value; 
            }
        }

        private bool _archive;

        [Persist(SqlDbType.Bit)]
        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        public Consultation(Guid codeConsultation,Facture facture, Veterinaire veto, Animal animal,DateTime dateConsultation, eConsultationEtat etat, string commentaire,bool archive)
        {
            CodeConsultation = codeConsultation;
            Archive =  archive;
            Commentaire = commentaire;
            DateConsultation = dateConsultation;
            Etat = etat;
            Facture = facture;
            Veto = veto;
            Animal = animal;
        }

    }
}
