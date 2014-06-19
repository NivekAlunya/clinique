using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinique.Model;
using Clinique.Controller;

namespace Clinique.View
{
    public partial class AgendaForm : Form
    {
        #region contructors
        /// <summary>
        /// Contruit un formulaire agenda
        /// </summary>
        public AgendaForm()
        {
            InitializeComponent();
            CommonBehaviourView.createColumnDataGridView(this.dgvAgenda);
            cmbVeto.DisplayMember = "NomVeto";
            cmbVeto.DataSource = VeterinaireController.Instance.Veterinaires;
            cmbVeto.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                _refreshAgenda();
            };
            dtpRendezVous.ValueChanged += (object sender, EventArgs e) =>
            {
                _refreshAgenda();
            };
            btnDossierMedical.Click += (object sender, EventArgs e) =>
            {
                _showDossier();
            };
        }
        #endregion
        #region methods
        private void _showDossier()
        {
            if (this.dgvAgenda.SelectedRows.Count > 0)
            {
                DossierMedicalForm f = new DossierMedicalForm(((Agenda)this.dgvAgenda.SelectedRows[0].Cells[0].Value).Animal);
                f.ShowDialog();
            }
        }

        private void _refreshAgenda()
        {

            if (null == this.cmbVeto.SelectedItem) return;

            Veterinaire veto = (Veterinaire)this.cmbVeto.SelectedItem;
            this.dgvAgenda.DataSource = AgendaController.Instance.getAgendasDuJourPourVeto(veto, dtpRendezVous.Value);
        }
        #endregion
    }
}
