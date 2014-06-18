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
using Clinique.Tools;

namespace Clinique.View
{
    public partial class AnimalForm : Form
    {
        #region events
        public event EventValider<Animal> evtValider;
        #endregion

        /// <summary>
        /// Construit un Formulaire de consultation des animaux
        /// </summary>
        #region Construtors
        public AnimalForm(Animal animal = null)
        {
            InitializeComponent();

            this.cbbClient.DisplayMember = "NomClient";
            this.cbbClient.DataSource = ClientController.Instance.Clients; //this.cbbClient.DataSource = AnimalController.Instance.Animaux; 
            this.cbbSexe.DisplayMember = "Sexe";
            this.cbbSexe.DataSource = new string[]{ "M", "F", "H" };
            this.cbbEspece.DisplayMember = "Race";
            this.cbbEspece.DataSource = RaceController.Instance.Races;
            

            //Animal animal = null;

            if (null != animal)
            {
                this.txtCode.Text = animal.CodeAnimal.ToString();
                this.txtNom.Text = animal.NomAnimal;
                this.txtCouleur.Text = animal.Couleur;
                this.txtTatouage.Text = animal.Tatouage; //TODO gerer le cas ou pas de tatouage
                this.cbbClient.SelectedItem = animal.Client;
                this.cbbSexe.SelectedItem = animal.Sexe;
                this.cbbEspece.SelectedItem = animal.Race;
                this.btnValider.Click += (object sender, EventArgs e) =>
                {
                    _valider(animal);
                };
            }
            else
            {
                this.btnValider.Click += (object sender, EventArgs e) =>
                {
                    _valider();
                };
            }



            this.btnAnnuler.Click += (object sender, EventArgs e) =>
            {
                this.Close();
            };
            
            this.btnDossierMedical.Click += (object sender, EventArgs e) =>
            {
                DossierMedicalForm form = new DossierMedicalForm(animal);
                form.Show();
            };
        }
    
        #endregion
                     
        #region methods
        /// <summary>
        /// Valide et ajoute un animal
        /// Declenche l'evenement de validation
        /// </summary>
        private void _valider(Animal animal)
        {
            try
            {
                AnimalController.Instance.ModifierAnimal(animal, txtNom.Text, (Animal.eSexe)cbbSexe.Text[0], txtCouleur.Text, (Race)cbbEspece.SelectedItem, txtTatouage.Text, " ", (Client)cbbClient.SelectedItem, false);
                if (null != evtValider) evtValider.Invoke(animal);
                this.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message + (null != e.InnerException ? e.InnerException.Message + "\n" : ""), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void _valider()
        {
            try
            {
                Animal animal = AnimalController.Instance.AjouterAnimal(txtNom.Text, (Animal.eSexe)cbbSexe.Text[0], txtCouleur.Text, (Race)cbbEspece.SelectedItem, txtTatouage.Text, " ", false, (Client)cbbClient.SelectedItem);
                if (null != evtValider) evtValider.Invoke(animal);
                this.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message + (null != e.InnerException ? e.InnerException.Message + "\n" : ""), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}

