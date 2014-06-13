using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;

namespace Clinique.Store
{
    public static class ClientStore
    {
        public static Client Ajouter ( string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
            Client client = new Client(Guid.NewGuid(), nomClient, prenomClient, adresse1, adresse2, codePostal,
             ville, numTel, assurance, email, remarque, archive);
            Database.Instance.insert(client);
        return client;
        }

        public static void Modifier(Client client, string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
             client.NomClient = nomClient;
             client.PrenomClient = prenomClient;
             client.Adresse1 = adresse1;
             client.Adresse2 = adresse2;
             client.Archive = archive;
             client.Assurance = assurance;
             client.CodePostal = codePostal;
             client.Email = email;
             client.NumTel = numTel;
             client.Remarque = remarque;
             client.Ville = ville;

             Database.Instance.update(client);
        }

        public static bool Supprimer(Client client)
        {
            return Database.Instance.delete(client);
        }
    }
}
