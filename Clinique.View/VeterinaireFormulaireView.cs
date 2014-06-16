using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinique.Tools;
using Clinique.Controller;
using Clinique.Model;

namespace Clinique.View
{

    public partial class VeterinaireFormulaireView : Form
    {
        #region events
        public event EventValider<Veterinaire> evtValider;
        #endregion
        #region constructors
        /// <summary>
        /// Construit un Formulaire de consultation des veterinaires
        /// </summary>
        public VeterinaireFormulaireView(Veterinaire veterinaire = null)
        {
            InitializeComponent();

            if (null != veterinaire)
            {
                this.Text = "Reset password ...";
                this.txtNom.Text = veterinaire.NomVeto;
                this.txtNom.Enabled = this.lblNom.Enabled = false;
                this.btnValider.Click += (object sender, EventArgs e) =>
                {
                    valider(veterinaire);
                };
            }
            else
            {
                this.btnValider.Click += (object sender, EventArgs e) =>
                {
                    valider();
                };
            }

            this.btnAnnuler.Click += (object sender, EventArgs e) =>
            {
                this.Close();
            };

        }
        #endregion
        #region methods
        /// <summary>
        /// Valide et ajoute un veterinaire
        /// Declenche l'evenement de validation
        /// </summary>
        private void valider()
        {
            try
            {
                if (!_testMotDePasse()) return;

                Veterinaire veto = VeterinaireController.Instance.AjouterVeterinaire(this.txtNom.Text, this.txtPassword.Text);
                evtValider.Invoke(veto);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + (null != e.InnerException ? e.InnerException.Message + "\n" : ""), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void valider(Veterinaire veto)
        {
            try
            {
                if (!_testMotDePasse()) return;
                VeterinaireController.Instance.ModifierVeterinaire(veto, veto.NomVeto, this.txtPassword.Text);
                evtValider.Invoke(veto);
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + (null != e.InnerException ? e.InnerException.Message + "\n" : ""), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool _testMotDePasse()
        {
            if (this.txtPassword.Text != this.txtPassword2.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
    }
}
