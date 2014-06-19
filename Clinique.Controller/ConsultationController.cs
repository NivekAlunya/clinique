using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using Clinique.Store;
using System.ComponentModel;
namespace Clinique.Controller
{
    public class ConsultationController
    {
        #region attributes
        private BindingList<Consultation> _consultations;
        #endregion
        #region properties
        public BindingList<Consultation> Consultations
        {
            get
            {
                return _consultations;
            }
            private set
            {
                _consultations = value;
            }
        }
        #endregion


        # region Singleton Pattern
        private static ConsultationController _instance = null;
	    public static ConsultationController  Instance
	    {
		    get { return _instance == null ? _instance = new ConsultationController() : _instance;}
	    }

        private ConsultationController()
        {
            Consultations = new BindingList<Consultation>(ConsultationStore.Instance.Consultations);
        }
        # endregion

        public Consultation AjouterConsultation(Facture facture, Veterinaire veto, Animal animal, DateTime dateConsultation, Consultation.eConsultationEtat etat, string commentaire, bool archive)
        {
            return ConsultationStore.Instance.Ajouter(facture, veto, animal, dateConsultation, etat, commentaire, archive);
        }

        public void ModifierConsultation(Consultation consultation,Facture facture, Veterinaire veto,DateTime dateConsultation, Consultation.eConsultationEtat etat, string commentaire,bool archive)
        {
            ConsultationStore.Instance.Modifier(consultation, facture, veto, dateConsultation, etat, commentaire, archive);
        }

        public bool Supprimerconsultation(Consultation consultation)
        {
            return ConsultationStore.Instance.Supprimer(consultation);
        }

        public string AfficherConsultation(Consultation consultation)
        {
            return ConsultationStore.Instance.Afficher(consultation);
        }
    }
}
