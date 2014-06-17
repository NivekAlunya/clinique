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
        #region enum
        private enum State
        {
            Stateless = 1,
            Selection = 2,
            Creation = 4,
            Updating = 8
        }
        #endregion
        #region attributes
        State _state = State.Stateless;
        int _index = -1;
        List<System.Windows.Forms.Control> stateControls = new List<System.Windows.Forms.Control>();
        #endregion
        #region constructors
        public ClientForm()
        {
            InitializeComponent();
            this.btnPremier.Click += (object sender, EventArgs e) =>
            {
                _navigate(0,true);
            };

            this.btnDernier.Click += (object sender, EventArgs e) =>
            {
                _navigate(ClientController.Instance.Clients.Count - 1, true);
            };
            this.btnSuivant.Click += (object sender, EventArgs e) =>
            {
                _navigate(1);
            };

            this.btnPrecedent.Click += (object sender, EventArgs e) =>
            {
                _navigate(-1);
            };
            KeyEventHandler evt = (object sender, KeyEventArgs e) =>
            {
                if( State.Selection == _state) _setState(State.Updating);
            };
            
            this.txtNom.KeyUp += evt;
            this.txtPrenom.KeyUp += evt;
            this.txtAdresse1.KeyUp += evt;
            this.txtAdresse2.KeyUp += evt;
            this.txtCodePostal.KeyUp += evt;
            this.txtVille.KeyUp += evt;

            this.btnValider.Click += (object sender, EventArgs e) =>
            {
                _valider();
            };

            this.btnAnnuler.Click += (object sender, EventArgs e) =>
            {
                _annuler();
            };

            this.btnAjouterClient.Click += (object sender, EventArgs e) =>
            {
                _ajouterClient();
            };


            this.txtNom.Tag = this.txtPrenom.Tag = this.txtAdresse1.Tag = this.txtAdresse2.Tag = this.txtCodePostal.Tag = this.txtVille.Tag = State.Selection | State.Creation | State.Updating;
            stateControls.Add(this.txtNom);
            stateControls.Add(this.txtPrenom);
            stateControls.Add(this.txtAdresse1);
            stateControls.Add(this.txtAdresse2);
            stateControls.Add(this.txtCodePostal);
            stateControls.Add(this.txtVille);

            this.dgvAnimaux.Tag = this.btnEditerAnimal.Tag = this.btnSupprimerAnimal.Tag = this.btnAjouterAnimal.Tag = this.gpbClient.Tag = State.Stateless | State.Selection;
            stateControls.Add(this.dgvAnimaux);
            stateControls.Add(this.btnEditerAnimal);
            stateControls.Add(this.btnSupprimerAnimal);
            stateControls.Add(this.btnAjouterAnimal);
            stateControls.Add(this.gpbClient);
            stateControls.Add(this.dgvAnimaux);
            
            this.btnDernier.Tag = this.btnSuivant.Tag = this.btnPrecedent.Tag = this.btnPremier.Tag = this.btnSupprimerClient.Tag = State.Selection;
            stateControls.Add(this.btnDernier);
            stateControls.Add(this.btnSuivant);
            stateControls.Add(this.btnPrecedent);
            stateControls.Add(this.btnPremier);
            stateControls.Add(this.btnSupprimerClient);

            this.btnValider.Tag = this.btnAnnuler.Tag = State.Creation | State.Updating;
            stateControls.Add(this.btnValider);
            stateControls.Add(this.btnAnnuler);
            
            if (1 > ClientController.Instance.Clients.Count)
            {
                _index = -1;
                _setState(State.Stateless);
                
            }
            else
            {
                _navigate(0,true);
                _setState(State.Selection);
            }
        }

        private void _ajouterClient()
        {
            _setState(State.Creation);
            _displayClient();
        }

        #endregion
        #region methods
        private void _setState(State state)
        {
            _state = state;
            foreach (Control ctrl in stateControls)
                ctrl.Enabled = _state == ((State)ctrl.Tag & _state);
            _displayClient();

        }

        private void _valider()
        {
            Client c = null;
            if (_state == State.Creation)
            {
                c = ClientController.Instance.AjouterClient(txtNom.Text, txtPrenom.Text, txtAdresse1.Text, txtAdresse2.Text, txtCodePostal.Text, txtVille.Text, null, null, null, null, false);
                _navigate(ClientController.Instance.Clients.IndexOf(c),true);
            }
            else
            {
                c = ClientController.Instance.Clients.ElementAt(_index);
                ClientController.Instance.ModifierClient(c, txtNom.Text, txtPrenom.Text, txtAdresse1.Text, txtAdresse2.Text, txtCodePostal.Text, txtVille.Text, null, null, null, null, false);
            }
            _setState(State.Selection);
        }

        private void _annuler()
        {
            _setState(1 > ClientController.Instance.Clients.Count ? State.Stateless : State.Selection);
            _displayClient();
        }

        /// <summary>
        /// Navigue vers la position courante plus l'increment
        /// si sup au maximum de la liste alors on repart au debut 
        /// si inferieur à 0 alors au repart a la fin
        /// si goto vrai alors va directement a la position specifiee par index
        /// </summary>
        /// <param name="incrementIndex"></param>
        private void _navigate(int index, bool boogoto = false) 
        {
            if( 1 > ClientController.Instance.Clients.Count) 
            {
                _index = -1;
            }
            else
            {
                if (boogoto)
                {
                    _index = index;
                }
                else
                {
                    _index += index;
                }
                if (_index >= ClientController.Instance.Clients.Count)
                {
                    _index = boogoto ? ClientController.Instance.Clients.Count -1 :  0;
                }
                else if (0 > _index + index)
                {
                    _index = ClientController.Instance.Clients.Count - 1;
                }
            }
            _displayClient();
        }

        private void _displayClient()
        {
            if (State.Creation == _state || State.Stateless == _state)
            {
                this.txtCode.Clear();
                this.txtNom.Clear();
                this.txtPrenom.Clear();
                this.txtAdresse1.Clear();
                this.txtAdresse2.Clear();
                this.txtCodePostal.Clear();
                this.txtVille.Clear();
            }
            else
            {
                Client c = ClientController.Instance.Clients.ElementAt(_index);
                this.txtCode.Text = c.CodeClient.ToString();
                this.txtNom.Text = c.NomClient;
                this.txtPrenom.Text = c.PrenomClient;
                this.txtAdresse1.Text = c.Adresse1 == null ? "" : c.Adresse1;
                this.txtAdresse2.Text = c.Adresse2 == null ? "" : c.Adresse2;
                this.txtCodePostal.Text = c.CodePostal == null ? "" : c.CodePostal;
                this.txtVille.Text = c.Ville == null ? "" : c.Ville;
            }
        }

        private void _displayAnimaux()
        {
                    
        }
        #endregion

    }
}
