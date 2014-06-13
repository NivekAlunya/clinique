using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;

namespace Clinique.Store
{
    public class FactureStore
    {
        public static Facture Ajouter(Client client, DateTime dateFacture, Facture.eFactureEtats etat, decimal totalFacture, DateTime rappelEnvoye, bool archive)
        {
            Facture facture = new Facture(Guid.NewGuid(), client, dateFacture, etat, totalFacture, rappelEnvoye, archive);
            Database.Instance.insert(facture);

            return facture;
       }

        public static void Modifier(Facture facture ,Client client, DateTime dateFacture, Facture.eFactureEtats etat, decimal totalFacture, DateTime rappelEnvoye, bool archive)
        {
            facture.Archive = archive;
            facture.Client = client;
            facture.DateFacture = dateFacture;
            facture.Etat = etat;
            facture.RappelEnvoye = rappelEnvoye;
            facture.TotalFacture = totalFacture;

            Database.Instance.update(facture);
        }

        public static bool Supprimer(Facture facture)
        {
            return Database.Instance.delete(facture);
        }

        
    }
}
