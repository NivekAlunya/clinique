using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using System.Data;
namespace Clinique.Store
{
    public class ConsultationStore
    {
        #region properties
        private List<Consultation> _consultations; 
        
        public List<Consultation> Consultations
        {
            get
            {
                return _consultations;
            }
            set { _consultations = value; }
        }

        #endregion

        #region Singleton pattern
        private static ConsultationStore _instance = null;
        
        public static ConsultationStore Instance { 
            get {
                return null == _instance ? _instance = new ConsultationStore() : _instance;
            }
        }

        private ConsultationStore()
        {
            Consultations = new List<Consultation>();
            _loadConsultations();
        }
        #endregion
        #region methods
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

        private void _loadConsultations()
        {
            string sql = "select * from Consultations";
            IDbConnection cn = Database.Instance.getConnection();
            IDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;

            try
            {
                cn.Open();
                IDataReader reader = cmd.ExecuteReader();
                object nf, etat, commentaire;
                while (reader.Read())
                {
                    //nf = Database.read(reader, "NumFacture");
                    //Facture facture = nf == null ? null : FactureStore.Instance.RecupererFacture((Guid)nf);
                    Facture facture = null;
                    Veterinaire veto = VeterinaireStore.Instance.RecupererVeterinaire(Database.read<Guid>(reader, "CodeVeto"));
                    Animal animal = AnimalStore.Instance.RecupererAnimal(Database.read<Guid>(reader,"CodeAnimal"));
                    commentaire = Database.read(reader, "Commentaire");
                    this.Consultations.Add(new Consultation(
                        Database.read<Guid>(reader, "CodeConsultation"),
                        facture, 
                        veto, 
                        animal, 
                        Database.read<DateTime>(reader, "DateConsultation"),
                        (Consultation.eConsultationEtat)Database.read<byte>(reader, "Etat"),
                        null == commentaire ? null : (string)commentaire,
                        Database.read<bool>(reader, "Archive"))
                    );
                }
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }

#endregion


    }
}
