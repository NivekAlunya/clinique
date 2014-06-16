using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinique.Controller;
using Clinique.Model;

namespace Clinique.View
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnAjouterClient2_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterClient1_Click(object sender, EventArgs e)
        {
            btnAjouterClient1.Enabled = false;
            btnAjouterClient2.Enabled = false;
            btnDernier.Enabled = false;
            btnEditerEditer.Enabled = false;
            btnPrecedent.Enabled = false;
            btnPremier.Enabled = false;
            btnRechercher.Enabled = false;
            btnSuivant.Enabled = false;
            txtAdresse1.Clear();
            txtAdresse2.Clear();
            txtCode.Clear();
            dgvAnimaux.ClearSelection();
            txtCodePostal.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtVille.Clear();

            btnValider.Visible = true;
            btnAnnuler.Visible = true;
            ClientControler.AjouterClient(txtNom.Text, txtPrenom.Text, txtAdresse1.Text, txtAdresse2.Text, txtCodePostal.Text, txtVille.Text, "0123456789", "", "", "", false);
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string client = txtRechercherClient.Text;
           

        }


    }
}
