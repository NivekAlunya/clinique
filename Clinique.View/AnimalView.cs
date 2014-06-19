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

        #region Construtors
        /// <summary>
        /// Construit un Formulaire de creation d'un animal pour un client
        /// </summary>
        /// <param name="animal"></param>
        public AnimalForm(Client client)
            :this()
        {
            this.cbbClient.SelectedItem = client;
            this.cbbClient.Enabled = false;
        }
        /// <summary>
        /// Construit un Formulaire de creation ou de modification d'un animal 
        /// </summary>
        /// <param name="animal"></param>
        public AnimalForm(Animal animal = null)
        {
            InitializeComponent();
            this.cbbClient.DisplayMember = "NomClient";
            this.cbbClient.DataSource = ClientController.Instance.Clients;
            this.cbbSexe.DisplayMember = "Sexe";
            this.cbbSexe.DataSource = new string[]{ "M", "F", "H" };
            this.cbbEspece.DisplayMember = "Nom";
            this.cbbEspece.DataSource = RaceController.Instance.Races;
            
            if (null != animal)
            {
                this.txtCode.Text = animal.CodeAnimal.ToString();
                this.txtNom.Text = animal.NomAnimal;
                this.txtCouleur.Text = animal.Couleur;
                this.txtTatouage.Text = animal.Tatouage; //TODO gerer le cas ou pas de tatouage
                this.cbbClient.SelectedItem = animal.Client;
                this.cbbClient.Enabled = false;
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
        /// Valide et modifie un animal
        /// Declenche l'evenement de validation
        /// </summary>
        /// <param name="animal"></param>
        /// <exception cref="Exception"></exception>
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
                Alert.Show(e.Message);
            }

        }
        /// <summary>
        /// Valide et ajoute un animal
        /// Declenche l'evenement de validation
        /// </summary>
        /// <exception cref="Exception"></exception>
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
                Alert.Show(e.Message);
            }
        }
        #endregion
    }
}

