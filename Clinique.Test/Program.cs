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
using System.Reflection;
namespace Clinique.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            run();
            Console.ReadKey();
        }

        private static void run()
        {
            //ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["SqlServer"];
            //IDbConnection cn = DbProviderFactories.GetFactory(settings.ProviderName).CreateConnection();
            //cn.ConnectionString = settings.ConnectionString;
            //cn.Open();
            //cn.Close();
            Race r = new Race();
            foreach(PropertyInfo p in r.GetType().GetProperties())
            {
                System.Attribute[] attrs = System.Attribute.GetCustomAttributes(p);
                foreach(System.Attribute att in attrs)
                {
                    Console.WriteLine(((Persist)att).DbType);
                }
            }


        }
    }
}
