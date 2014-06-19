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
            //runCreationVeto();
            runrecuperationlisteAnimal();
            //runCreationAnimal();
            //runCreationBareme();
            //runCreationFacture();
            //runCreationLignesFacture();
            //runCreationRace();
            //runCreationAgenda();
            //runCreationConsultationFull();

            Console.ReadKey();
        }

        private static void runrecuperationlisteAnimal()
        {
            Console.WriteLine("Verification remplissage de la liste");
            foreach  (Animal animal in AnimalController.Instance.Animaux)
	        {
		         Console.WriteLine(animal.Espece + "  " + animal.Race);
	        }
              
        }

        private static void runCreationLignesFacture()
        {
            Client client = ClientController.Instance.AjouterClient("Bugeavel-Track", "Amede", "3 rue du petit paris", "", "44950", "Flurne sur Loire", "0666785713", "Non", "bens360@jjh.fr", "Pas de remarque", false);
            Facture facture = FactureStore.Instance.Ajouter(client, DateTime.Now.ToUniversalTime(), Facture.eFactureEtats.a_imprimer, 135, DateTime.Now.ToUniversalTime(), false);
            Vaccin vaccin = VaccinController.Instance.AjouterVaccin("VIH Vaccin", 50, 2, false);
            Bareme bareme = BaremeStore.Instance.Ajouter("103", "30/07/07", "VACC", "Vaccination DT", 11, 10, 14, vaccin, false);
            LigneFacture ligneFacture = LigneFactureStore.Instance.Ajouter(facture, bareme, 135, false);
            Console.WriteLine("INSERT");
            Console.ReadKey();
            Console.WriteLine("UPDATE");
            LigneFactureStore.Instance.Modifier(ligneFacture, facture, bareme, 1350, true);
            Console.ReadKey();
            Console.WriteLine("DELETE");
            LigneFactureStore.Instance.Supprimer(ligneFacture);
        }

        private static void runCreationFacture()
        {
            Client client = ClientController.Instance.AjouterClient("Bugeavel-Track", "Amede", "3 rue du petit paris", "", "44950", "Flurne sur Loire", "0666785713", "Non", "bens360@jjh.fr", "Pas de remarque", false);
            Facture facture = FactureStore.Instance.Ajouter(client, DateTime.Now.ToUniversalTime(), Facture.eFactureEtats.a_imprimer, 135, DateTime.Now.ToUniversalTime(), false);
            Console.WriteLine("INSERT");
            Console.ReadKey();
            Console.WriteLine("UPDATE");
            FactureStore.Instance.Modifier(facture, client, DateTime.Now.ToUniversalTime(), Facture.eFactureEtats.payee, 2500, DateTime.Now.ToUniversalTime(), false);
            Console.ReadKey();
            Console.WriteLine("DELETE");
            FactureStore.Instance.Supprimer(facture);
        }

        private static void runCreationBareme()
        {
            Vaccin vaccin = VaccinController.Instance.AjouterVaccin("VIH Vaccin", 50, 2, false);
            Bareme bareme = BaremeStore.Instance.Ajouter("103", "30/07/07", "VACC", "Vaccination DT", 11, 10, 14, vaccin, false);
            Console.WriteLine("INSERT");
            Console.ReadKey();
            Console.WriteLine("UPDATE");
            BaremeStore.Instance.Modifier(bareme, "VACC", "Vaccination DT americanos", 110, 100, 140, vaccin);
            Console.ReadKey();
            Console.WriteLine("DELETE");
            BaremeStore.Instance.Supprimer(bareme);
        }
		private static void runCreationConsultationFull()
        {
            Veterinaire veto = VeterinaireController.Instance.AjouterVeterinaire("toto", "*****", false);
            Race Labrador = RaceStore.Instance.Ajouter("Chien", "Labrador");
            Client amede = ClientStore.Instance.Ajouter("Bugeavel-Track", "Amede", "3 rue du petit paris", "", "44950", "Flurne sur Loire", "0666785713", "Non", "bens360@jjh.fr", "Pas de remarque", false);
            Animal animal = AnimalStore.Instance.Ajouter("Bethoveen", Animal.eSexe.M, "Beige", Labrador, "007", "Joueur avec le facteur", false, amede);
            Console.WriteLine("INSERT");
            Consultation consultation = ConsultationController.Instance.AjouterConsultation(null, veto,animal, DateTime.Now, Consultation.eConsultationEtat.en_cours_de_saisie, "", false);
            Console.ReadKey();
            Console.WriteLine("UPDATE");
            ConsultationController.Instance.ModifierConsultation(consultation, null, veto, DateTime.Now.AddMonths(-1), Consultation.eConsultationEtat.saisie_veterinaire_terminee_facturation_possible,"comment ..............." , false);
            Console.ReadKey();
            Console.WriteLine("DELETE");
            ConsultationController.Instance.Supprimerconsultation(consultation);

            AnimalStore.Instance.Supprimer(animal);
            ClientStore.Instance.Supprimer(amede);
            RaceStore.Instance.Supprimer(Labrador);
            VeterinaireStore.Instance.Supprimer(veto);

        }

        private static void runCreationAgenda()
        {
            Veterinaire veto = VeterinaireController.Instance.AjouterVeterinaire("toto", "*****", false);
            Race Labrador = RaceStore.Instance.Ajouter("Chien", "Labrador");
            Client amede = ClientStore.Instance.Ajouter("Bugeavel-Track", "Amede", "3 rue du petit paris", "", "44950", "Flurne sur Loire", "0666785713", "Non", "bens360@jjh.fr", "Pas de remarque", false);
            Animal animal = AnimalStore.Instance.Ajouter("Bethoveen", Animal.eSexe.M, "Beige", Labrador, "007", "Joueur avec le facteur", false, amede);
            
            
            Console.WriteLine("INSERT");
            Agenda agenda = AgendaController.Instance.AjouterAgenda(veto, animal, DateTime.Now);
            Console.ReadKey();
            Console.WriteLine("DELETE");
            AgendaController.Instance.SupprimerAgenda(agenda);
            AnimalStore.Instance.Supprimer(animal);
            ClientStore.Instance.Supprimer(amede);
            RaceStore.Instance.Supprimer(Labrador);
            VeterinaireStore.Instance.Supprimer(veto);

        }

        private static void runCreationRace()
        {
            Console.WriteLine("INSERT");
            Race r = RaceController.Instance.AjouterRace("Chien", "Labrador");
            Console.ReadKey();
            Console.WriteLine("DELETE");
            RaceController.Instance.SupprimerRace(r);
        }

        private static void runCreationAnimal()
        {
            Race Tecquel = RaceStore.Instance.Ajouter("Chien", "Tecquel");
            Client amede = ClientStore.Instance.Ajouter("Bugeavel", "Amede", "3 rue du petit paris", "", "44950", "Flurne sur Loire", "0666785713", "Non", "bens360@jjh.fr", "Pas de remarque", false);
            Animal animal = AnimalController.Instance.AjouterAnimal("Bethoveen", Animal.eSexe.M, "Beige", Tecquel, "007", "Joueur avec le facteur", false, amede);
            Console.WriteLine("INSERT");
            Console.ReadKey();
            Console.WriteLine("UPDATE");
            AnimalController.Instance.ModifierAnimal(animal, "Bethoveen", Animal.eSexe.F, "Marron", Tecquel, "007", "Joueur avec le facteur et la police",  amede, false);
            Console.ReadKey();
            Console.WriteLine("DELETE");
            AnimalController.Instance.SupprimerAnimal(animal);
        }


        private static void runCreationClient()
        {
            
            Console.WriteLine("INSERT");
            Client client = ClientController.Instance.AjouterClient("Bugeavel-Track", "Amede", "3 rue du petit paris", "", "44950", "Flurne sur Loire", "0666785713", "Non", "bens360@jjh.fr", "Pas de remarque", false); 

            Console.ReadKey();
            Console.WriteLine("UPDATE");
            ClientController.Instance.ModifierClient(client, "Bug", "Ade", "3 rue", "", "44950", "Flurre", "0666785713", "AGPM", "bens360@jjh.fr", "Pas de remarque", false);  
            Console.ReadKey();
            Console.WriteLine("DELETE");
            ClientController.Instance.SupprimerClient(client);
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
