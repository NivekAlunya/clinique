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
        }
        #endregion
    }
}
