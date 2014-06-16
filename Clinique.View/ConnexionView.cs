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

namespace Clinique.View
{
    public partial class ConnexionForm : Form
    {

        public event EventHandler evtConnected;
        
        public ConnexionForm()
        {
            InitializeComponent();
        }

        private void txtB_MotDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            ValiderConnexion(txtNom.Text, txtMotDePasse.Text);
            
        }

        private void ValiderConnexion(string Nom, string MotDePasse)
        {
            if (ConnexionController.GetInstance().Connect(Nom, MotDePasse) == true)
            {
                if (evtConnected != null)
                {
                    evtConnected(Nom, EventArgs.Empty);
                }
            }
        }
    }
}
