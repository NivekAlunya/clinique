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
            Application.Run(new EcranPrincipalView());
            //Application.Run(new VeterinaireView());
            //Animal animal = AnimalStore.Instance.Animaux.ElementAt(0);
            //AnimalForm animalform = new AnimalForm(animal);
            //animalform.evtValider += (Animal animal  ) =>
            //{
            //    MessageBox.Show(animal.NomAnimal);
            //};

            ////Application.Run(animalform);

            //DossierMedicalForm dossierMedicalForm = new DossierMedicalForm(animal);
            //Application.Run(dossierMedicalForm);
            //System.Diagnostics.Debug.WriteLine(ConsultationStore.Instance.Consultations);
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
