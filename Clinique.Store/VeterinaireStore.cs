using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
namespace Clinique.Store
{
    public static class VeterinaireStore
    {
        public static Veterinaire Ajouter(string nomVeto, string motDePasse, bool archive)
        {
            Veterinaire veto = new Veterinaire(Guid.NewGuid(), nomVeto, motDePasse, archive);
            Database.Instance.insert(veto);
            
            return veto;
        }

        public static void Modifier(Veterinaire veterinaire, string nomVeto, string motDePasse, bool archive)
        {
            veterinaire.MotPasse = motDePasse;
            veterinaire.NomVeto = nomVeto;
            veterinaire.Archive = archive;
            Database.Instance.update(veterinaire);
        }

        public static bool Supprimer(Veterinaire veterinaire)
        {
            return Database.Instance.delete(veterinaire);
        }
    }
}
