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
            CommonBehaviourView.createColumnDataGridView(this.dgvAgenda);
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
                _refreshAgenda();
            };

            dtpRendezVous.ValueChanged += (object sender, EventArgs e) =>
            {
                _refreshAgenda();
            };
            btnSupprimer.Click += (object sender, EventArgs e) =>
            {
                _supprimerRendezVous();
            };
            btnValider.Click += (object sender, EventArgs e) =>
            {
                _valider();
            };
            _refreshAgenda();
        }

        #endregion
        #region properties
        public BindingList<Animal> ListAnimaux { get; set; }
        #endregion
        #region methods
        private void _valider()
        {
            if(null == this.cmbVeto.SelectedItem)
            {
                Alert.Show("Selectionner un veterinaire");
                return;
            }
            
            if(null == this.cmbAnimal.SelectedItem)
            {
                Alert.Show("Selectionner un animal");
                return;
            }

            if(null == this.cmbHeure.SelectedItem)
            {
                Alert.Show("Selectionner une heure");
                return;
            }
            
            
            Animal animal = (Animal)this.cmbAnimal.SelectedItem;
            Veterinaire veto = (Veterinaire)this.cmbVeto.SelectedItem;
            string heure = (string)this.cmbHeure.SelectedItem;

            DateTime dt;
            if (!DateTime.TryParse(this.dtpRendezVous.Value.ToShortDateString() + " " + heure, out dt))
            {
                Alert.Show("heure non valide.");
            }
            try
            {
                AgendaController.Instance.AjouterAgenda(veto, animal, dt);
                _refreshAgenda();
            }
            catch (Exception e)
            {
                Alert.Show(e.Message);
            }
            
        }

        private void _supprimerRendezVous()
        {
            if (this.dgvAgenda.SelectedRows.Count > 0)
            {
                AgendaController.Instance.SupprimerAgenda((Agenda)this.dgvAgenda.SelectedRows[0].Cells[0].Value);
                _refreshAgenda();
            }
        }

        private void _refreshAgenda()
        {

            if (null == this.cmbVeto.SelectedItem) return;
            
            Veterinaire veto = (Veterinaire)this.cmbVeto.SelectedItem;
            this.dgvAgenda.DataSource = AgendaController.Instance.getAgendasDuJourPourVeto(veto,dtpRendezVous.Value);
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
