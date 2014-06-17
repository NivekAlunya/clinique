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
    public partial class VeterinaireView : Form
    {
        #region enum
        private enum State
        {
            Stateless = 1,
            Selection = 2,
        }
        #endregion
        #region attributes
        State _state = State.Stateless;
        List<System.Windows.Forms.Control> stateControls = new List<System.Windows.Forms.Control>();
        #endregion
        #region constructors
        /// <summary>
        /// Construit un Formulaire de consultation des veterinaires
        /// </summary>
        public VeterinaireView()
        {
            InitializeComponent();
            this.btnInit.Tag = this.btnSupprimer.Tag = this.lstVeterinaires.Tag = State.Selection;
            this.btnAjouter.Tag = State.Selection | State.Stateless;

            this.stateControls.Add(this.btnInit);
            this.stateControls.Add(this.btnSupprimer);
            this.stateControls.Add(this.btnAjouter);
            this.stateControls.Add(this.lstVeterinaires);


            this.lstVeterinaires.DisplayMember = "NomVeto";
            this.lstVeterinaires.DataSource = VeterinaireController.Instance.Veterinaires;

            this.btnAjouter.Click += (object sender, EventArgs e) =>
            {
                this._ajouterVeterinaire();
            };
            this.btnSupprimer.Click += (object sender, EventArgs e) =>
            {
                _supprimerVeterinaire();
            };
            this.btnInit.Click += (object sender, EventArgs e) =>
            {
                _initVeterinaire();
            };
            this.lstVeterinaires.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                if (null != this.lstVeterinaires.SelectedItem)
                    _setState(State.Selection);
            };
            if (1 > lstVeterinaires.Items.Count) _setState(State.Stateless);
        }

        #endregion
        #region methods
        /// <summary>
        /// Ouvre le formulaire d'ajout d'un veterinaire
        /// </summary>
        private void _ajouterVeterinaire()
        {
            VeterinaireFormulaireView form = new VeterinaireFormulaireView();
            form.evtValider += (Model.Veterinaire obj) =>
            {
                _setState(State.Selection);
            };
            form.ShowDialog();
        }
        /// <summary>
        /// Ouvre le formulaire d'ajout d'un veterinaire
        /// </summary>
        private void _initVeterinaire()
        {
            if (null != this.lstVeterinaires.SelectedItem)
            {
                VeterinaireFormulaireView form = new VeterinaireFormulaireView((Veterinaire)this.lstVeterinaires.SelectedItem);
                form.evtValider += (Model.Veterinaire obj) =>
                {
                    _setState(State.Selection);
                };
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selectionner un veterinaire dans la liste !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// archive un veterinaire
        /// </summary>
        private void _supprimerVeterinaire()
        {
            if (null != this.lstVeterinaires.SelectedItem)
                try
                {
                    VeterinaireController.Instance.SupprimerVeterinaire((Veterinaire)this.lstVeterinaires.SelectedItem);
                    if (1 > lstVeterinaires.Items.Count) _setState(State.Stateless);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Un veterinaire avec des consultations en cours ou àa venir ne peut etre archive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            else
                MessageBox.Show("Selectionner un veterinaire dans la liste !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void _setState(State state)
        {
            _state = state;
            foreach (Control ctrl in stateControls)
                ctrl.Enabled = _state == ((State)ctrl.Tag & _state);
        }
        #endregion


    }
}
