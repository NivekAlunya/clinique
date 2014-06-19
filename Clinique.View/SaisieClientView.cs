using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique.View
{
    public partial class SaisieClientForm : Form
    {
        public SaisieClientForm()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            
        }

        public string NomAnimal
        {
            get
            {
                return this.txtNomAnimal.Text;
            }
        }

        public string NomClient
        {
            get
            {
                return this.txtNomClient.Text;
            }
        }
    }
}
