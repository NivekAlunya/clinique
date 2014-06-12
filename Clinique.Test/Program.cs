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
using Clinique.Store;
using Clinique.Controller;

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
            runCreationClient();
            Console.ReadKey();
        }

        private static void runCreationClient()
        {
            
            Client cred = new Client(Guid.NewGuid(),"Bugeavel-Track", "Amede", "3 rue du petit paris", "", "44950", "Flurne sur Loire" ,"0666785713", "Non" , "bens360@jjh.fr", "Pas de remarque" , false);
            Console.WriteLine("INSERT");
            Database.Instance.insert(cred);
            Console.ReadKey();
            Console.WriteLine("UPDATE");
            cred.Adresse1 = "1234";
            Database.Instance.update(cred);
            Console.ReadKey();
            Console.WriteLine("DELETE");
            Database.Instance.delete(cred);
        }

        private static void runCreation()
        {
            Connection cred = new Connection { Login = "MalalanichM", Password = "123" };
            Console.WriteLine("INSERT");
            Database.Instance.insert(cred);
            Console.ReadKey();
            Console.WriteLine("UPDATE");
            cred.Password = "1234";
            Database.Instance.update(cred);
            Console.ReadKey();
            Console.WriteLine("DELETE");
            Database.Instance.delete(cred);
            
        }

        private static void run()
        {
            //Race r = new Race();
            //r.Espece = "Chien";
            //r.Race_ = "Berger";
            //Database.Instance.insert(r);

            Vaccin v = new Vaccin (Guid.NewGuid(), "Ebola3", 50 ,6, false);
            Database.Instance.insert(v);
            v.QuantiteStock = 100;
            Database.Instance.update(v);
            Database.Instance.delete(v);

            Console.WriteLine(v.CodeVaccin);
        }

        private static void runConnection ()
        {
            if (ConnexionStore.VerifConnexion("BosapinE", "123") == true)
            { 
                Console.WriteLine("Test OK : BosapinE, 123");
            }
            else
            {
                Console.WriteLine("Probléme de déclaration de Verif Connexion");
            }

            if (ConnexionStore.VerifConnexion("fdds", "123") == false)
            { Console.WriteLine("Test OK"); }
            else
            {
                Console.WriteLine("Probléme de déclaration de Verif Connexion");
            }       
        }

    }
}
