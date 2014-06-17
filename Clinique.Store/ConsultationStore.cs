using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
namespace Clinique.Store
{
    public class ConsultationStore
    {
        #region Singleton pattern
        private static ConsultationStore _instance = null;
        
        public static ConsultationStore Instance { 
            get {
                return null == _instance ? _instance = new ConsultationStore() : _instance;
            }
        }

        private ConsultationStore()
        {

        }
        #endregion

        public Consultation Ajouter(Facture facture, Veterinaire veto,Animal animal, DateTime dateConsultation, Consultation.eConsultationEtat etat, string commentaire, bool archive)
        {
            Consultation consultation = new Consultation(Guid.NewGuid(), facture, veto,animal, dateConsultation, etat, commentaire, archive);
            Database.Instance.insert(consultation);
            return consultation;
        }

        public void Modifier(Consultation consultation,Facture facture, Veterinaire veto,DateTime dateConsultation, Consultation.eConsultationEtat etat, string commentaire,bool archive)
        {
            consultation.Facture = facture;
            consultation.Veto = veto;
            consultation.DateConsultation = dateConsultation;
            consultation.Etat = etat;
            consultation.Commentaire = commentaire;
            consultation.Archive = archive;
            Database.Instance.update(consultation);
        }

        public bool Supprimer(Consultation consultation)
        {
            return Database.Instance.delete(consultation);
        }
    }
}
