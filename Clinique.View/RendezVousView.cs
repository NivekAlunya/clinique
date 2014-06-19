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
    public partial class RendezVousForm : Form
    {
        #region constructors
        public RendezVousForm()
        {
            InitializeComponent();
            _initHeure();
            cmbClient.DisplayMember = "NomClient";
            cmbClient.DataSource = ClientController.Instance.Clients;
            cmbClient.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                _changeClient();
            };

            cmbVeto.DisplayMember = "NomVeto";
            cmbVeto.DataSource = VeterinaireController.Instance.Veterinaires;
            cmbVeto.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                _changeVeto();
            };
        }
        #endregion
        #region properties
        public BindingList<Animal> ListAnimaux { get; set; }
        #endregion
        #region methods
        private void _changeVeto()
        {
            _refreshAgenda((Veterinaire)this.cmbVeto.SelectedItem,this.dtpRendezVous.Value);
        }

        private void _refreshAgenda(Veterinaire veto,DateTime dt)
        {
            this.dgvAgenda.DataSource = AgendaController.Instance.getAgendasDuJourPourVeto(veto,dt);
        }

        private void _changeClient()
        {
            _refreshAnimaux();
        }
        private void _refreshAnimaux()
        { 
            if (null != this.cmbClient.SelectedItem)
            {
                ListAnimaux = AnimalController.Instance.getAnimalPourClient((Client)this.cmbClient.SelectedItem);
                this.cmbAnimal.DataSource = ListAnimaux;
                cmbAnimal.DisplayMember = "NomAnimal";
            }
            else
            {
                this.cmbAnimal.DataSource = null;
                ListAnimaux =null;
            }
        }

        private void _initHeure()
        {
            dtpRendezVous.Value = DateTime.Now;
            string curQuarter = DateTime.Now.Hour + ":" + (Math.Ceiling((decimal)(DateTime.Now.Minute / 15))) * 15;
            string quarter = "";
            for (int i = 0; i < 24; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    quarter = i.ToString().PadLeft(2, '0') + ":" + (j * 15).ToString().PadLeft(2, '0');
                    this.cmbHeure.Items.Add(quarter);
                    if (quarter.CompareTo(curQuarter) == 0) this.cmbHeure.SelectedItem = quarter;
                }
            }
        }
        #endregion
    }
}
