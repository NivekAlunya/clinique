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
            _showRendezVous();
        }

        private void btnClientAnimal_Click(object sender, EventArgs e)
        {
            _showFormClientAnimal();
        }

        private void _showFormClientAnimal()
        {
            ClientForm clientForm = new ClientForm();
            clientForm.MdiParent = this;
            clientForm.Show();
        }

        private void priseDeRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showRendezVous();
        }

        private void _showRendezVous()
        {
            RendezVousForm rdv = new RendezVousForm();
            rdv.MdiParent = this;
            rdv.Show();
        }

        private void veterinairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showVeterinaire();
        }

        private void _showVeterinaire()
        {
            VeterinaireView veterinaire = new VeterinaireView();
            veterinaire.MdiParent = this;
            veterinaire.Show();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            
        }

        private void dossierClientAnimauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showFormClientAnimal();
        }

    }
}
