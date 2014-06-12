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
            runCreation();
            Console.ReadKey();
        }

        private static void runCreation()
        {
            Connection cred = new Connection { Login = "MalalanichM", Password = "123" };
            Database.Instance.insert(cred);
            cred.Password = "1234";
            Database.Instance.update(cred);
            Database.Instance.delete(cred);
            
        }

        private static void run()
        {
            //Race r = new Race();
            //r.Espece = "Chien";
            //r.Race_ = "Berger";
            //Database.Instance.insert(r);

            Vaccin v = new Vaccin { CodeVaccin= Guid.NewGuid(), Archive = false, NomVaccin = "Ebola3", PeriodeValidite = 6, QuantiteStock = 50 };
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
