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
            _show(new ClientForm());
        }

        private void priseDeRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showRendezVous();
        }

        private void _showRendezVous()
        {
            _show(new RendezVousForm());
        }

        private void veterinairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showVeterinaire();
        }

        private void _showVeterinaire()
        {
            _show(new VeterinaireForm());
        }

        private void _show(Form f)
        {
            fermerLesFenetres();
            f.MdiParent = this;
            f.Show();
            
        }
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            _showAgenda();
        }

        private void _showAgenda()
        {
            _show(new AgendaForm());
        }


        private void dossierClientAnimauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showFormClientAnimal();
        }

        private void fermerLesFenetres()
        {
            foreach (Form fenetre in this.MdiChildren)
            {
                fenetre.Close();
            }
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showAgenda();
        }

    }
}
