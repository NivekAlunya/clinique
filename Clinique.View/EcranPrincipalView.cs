using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique.View
{
    public partial class EcranPrincipalView : Form
    {
        public EcranPrincipalView()
        {
            InitializeComponent();
        }

        private void btnRendezVous_Click(object sender, EventArgs e)
        {
            AgendaForm agendaForm = new AgendaForm();
            agendaForm.ShowDialog();
        }

        private void btnClientAnimal_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
        }

        private void btnRelance_Click(object sender, EventArgs e)
        {
            // RelanceForm relanceForm = new RelanceForm(); //Todo - enlever les commentaires lorsque RelanceForm sera créee  
            //relanceForm.ShowDialog();
        }

        private void btnDossierMedical_Click(object sender, EventArgs e)
        {
            DossierMedicalForm dossierMedicalForm = new DossierMedicalForm();
            SaisieClientView saisieClient = new SaisieClientView();
            saisieClient.ShowDialog();
            dossierMedicalForm.ShowDialog();
            //dossierMedicalForm. = saisieClient.NomAnimal;
            // = saisieClient.NomClient;
        }

        private void priseDeRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendaForm agenda = new AgendaForm();
            agenda.ShowDialog();
        }

        private void dossierClientAnimauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DossierMedicalForm dossierMedicalForm = new DossierMedicalForm();
            SaisieClientView saisieClient = new SaisieClientView();
            saisieClient.ShowDialog();
            dossierMedicalForm.ShowDialog();
            //dossierMedicalForm. = saisieClient.NomAnimal;
            // = saisieClient.NomClient;
        }

        private void relancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // RelanceForm relanceForm = new RelanceForm(); //Todo - enlever les commentaires lorsque RelanceForm sera créee  
            //relanceForm.ShowDialog();
        }

        private void miseaJourDuStockDeVaccinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // VaccinForm vaccinForm = new vaccinForm(); //Todo - enlever les commentaires lorsque VaccinForm sera créee  
            //vaccinForm.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendaForm agenda = new AgendaForm();
            agenda.ShowDialog();
        }

        private void dosssierMedicauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendaForm agenda = new AgendaForm();
            agenda.ShowDialog();
        }

        private void veterinairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeterinaireView veterinaire = new VeterinaireView();
            veterinaire.ShowDialog();
        }

        private void miseaJourDuBaremeDeTarificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BaremeView bareme = new BaremeView(); //Todo - enlever les commentaires lorsque BaremeForm sera créee  
            //bareme.showDialog();
        }


    }
}
