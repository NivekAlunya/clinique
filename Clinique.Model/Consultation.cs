using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Consultation
    {
        private int _codeConsultation;

        public int CodeConsultation
        {
            get { return _codeConsultation; }
            set { _codeConsultation = value; }
        }

        private DateTime _dateConsultation;

        public DateTime DateConsultation
        {
            get { return _dateConsultation; }
            set { _dateConsultation = value; }
        }

        private Veterinaire _veto;

        public Veterinaire Veto
        {
            get { return _veto; }
            set { _veto = value; }
        }
        
        private int _codeVeto;

        public int CodeVeto
        {
            get { return _codeVeto; }
            set { _codeVeto = value; }
        }

        private Animal _animal;

        public Animal Animal
        {
            get { return _animal; }
            set { _animal = value; }
        }
        

        private int _codeAnimal;

        public int Codeanimal
        {
            get { return _codeAnimal; }
            set { _codeAnimal = value; }
        }

        private string _commentaire;

        public string commentaire
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

        public eConsultationEtat Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        private Facture _facture;

        public Facture Facture
        {
            get { return _facture; }
            set { _facture = value; }
        }

        private int _numFacture;

        public int NumFacture
        {
            get { return _numFacture; }
            set { _numFacture = value; }
        }

        private bool _archive;

        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

    }
}
