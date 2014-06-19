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
    public partial class DossierMedicalForm : Form
    {
        
        
#region constructor
        public DossierMedicalForm(Animal animal = null)
        {
            InitializeComponent();

            if (null != animal)
            {
                this.txtAnimal.Text = animal.NomAnimal;
                this.txtProprietaire.Text = animal.Client.NomClient;
                this.txtEcran.Text = animal.Antecedents;
            }
            //SaisieClientView saisieclient = SaisieClientView.ActiveForm();
            //if (null != saisieclient)
            //{
            //    this.txtAnimal.Text = saisieclient.NomAnimal;
            //    this.txtProprietaire.Text = saisieclient.NomClient;
            //}
        }


#endregion


        private void DossierMedicalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
