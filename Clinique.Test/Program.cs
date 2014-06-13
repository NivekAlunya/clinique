using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Configuration;
using Clinique.Model;
using Clinique.Controller;
using Clinique.Store;
using System.Reflection;

namespace Clinique.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //run();
            //runConnection();
            //runCreation();
            //runCreationClient();
            runCreationVeto();
            //runCreationAnimal();
            
            Console.ReadKey();
        }

        private static void runCreationAnimal()
        {
            Race Labrador = new Race("Chien", "Labrador");
            Client amede = new Client(Guid.NewGuid(), "Bugeavel-Track", "Amede", "3 rue du petit paris", "", "44950", "Flurne sur Loire", "0666785713", "Non", "bens360@jjh.fr", "Pas de remarque", false);
            
            Animal animal = AnimalStore.Ajouter("Bethoveen", Animal.eSexe.M, "Beige", Labrador, "007", "Joueur avec le facteur", false, amede);
            Console.WriteLine("INSERT");
            Console.ReadKey();
            Console.WriteLine("UPDATE");
            AnimalStore.Modifier(animal, "Bethoveen", Animal.eSexe.F, "Marron", Labrador, "007", "Joueur avec le facteur et la police", false, amede);
            Console.ReadKey();
            Console.WriteLine("DELETE");
            AnimalStore.Supprimer(animal);
           
        }




        private static void runCreationClient()
        {
            
            Console.WriteLine("INSERT");
            Client client = ClientControler.AjouterClient("Bugeavel-Track", "Amede", "3 rue du petit paris", "", "44950", "Flurne sur Loire", "0666785713", "Non", "bens360@jjh.fr", "Pas de remarque", false); 

            Console.ReadKey();
            Console.WriteLine("UPDATE");
            ClientControler.ModifierClient(client, "Bug", "Ade", "3 rue", "", "44950", "Flurre", "0666785713", "AGPM", "bens360@jjh.fr", "Pas de remarque", false);  
            Console.ReadKey();
            Console.WriteLine("DELETE");
            ClientControler.SupprimerClient(client);
           }

        private static void runCreationVaccin()
        {
            Console.WriteLine("New Vaccin"); 
            Vaccin vaccin = VaccinController.Instance.AjouterVaccin("VIH Vaccin", 50, 2, false);
            Console.ReadKey();
            Console.WriteLine("Update Vaccin"); 
            VaccinController.Instance.ModifierVaccin(vaccin, "VIH Vaccin altere", 50, 2, true);
            Console.ReadKey();
            Console.WriteLine("Delete Vaccin"); 
            VaccinController.Instance.SupprimerVaccin(vaccin);
        }

        private static void runCreationVeto()
        {
            Console.WriteLine("New Veterinaire");
            Veterinaire veto = VeterinaireController.Instance.AjouterVeterinaire("TOTO", "password",false);
            Console.ReadKey();
            Console.WriteLine("Update Veterinaire");
            VeterinaireController.Instance.ModifierVeterinaire(veto, "TITI", "******", true);
            Console.ReadKey();
            Console.WriteLine("Delete Veterinaire");
            VeterinaireController.Instance.SupprimerVeterinaire(veto);
        }

        private static void runCreation()
        {
            //Connection cred = new Connection { Login = "MalalanichM", Password = "123" };
            //Console.WriteLine("INSERT");
            //Database.Instance.insert(cred);
            //Console.ReadKey();
            //Console.WriteLine("UPDATE");
            //cred.Password = "1234";
            //Database.Instance.update(cred);
            //Console.ReadKey();
            //Console.WriteLine("DELETE");
            //Database.Instance.delete(cred);


            
        }

        private static void run()
        {
            //Race r = new Race();
            //r.Espece = "Chien";
            //r.Race_ = "Berger";
            //Database.Instance.insert(r);

        }

        private static void runConnection ()
        {
            //if (ConnexionStore.VerifConnexion("BosapinE", "123") == true)
            //{ 
            //    Console.WriteLine("Test OK : BosapinE, 123");
            //}
            //else
            //{
            //    Console.WriteLine("Probléme de déclaration de Verif Connexion");
            //}

            //if (ConnexionStore.VerifConnexion("fdds", "123") == false)
            //{ Console.WriteLine("Test OK"); }
            //else
            //{
            //    Console.WriteLine("Probléme de déclaration de Verif Connexion");
            //}       
        }



    }
}
