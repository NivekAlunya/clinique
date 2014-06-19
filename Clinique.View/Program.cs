using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinique.Model;
using Clinique.Store;
using Clinique.Tools;
namespace Clinique.View
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Diagnostics.Debug.WriteLine(AgendaStore.Instance.Agendas);
            //Application.Run(new RendezVousForm());
        }   


         private static Form getConnection()
         {
             ConnexionForm ecran = new ConnexionForm();
             ecran.evtConnected += (object sender, EventArgs args) =>
             {
                 System.Diagnostics.Debug.WriteLine("connected");
             };
             return ecran;
         }
    }
    
   
}
