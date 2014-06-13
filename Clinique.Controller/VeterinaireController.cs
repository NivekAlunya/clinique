using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using Clinique.Store;
namespace Clinique.Controller
{
    public class VeterinaireController
    {
        #region Singleton pattern
        private static VeterinaireController _instance = null;
        public static VeterinaireController Instance { 
            get {
                return null == _instance ? _instance = new VeterinaireController() : _instance;
            }
        }
        private VeterinaireController()
        {
                
        }
        #endregion

        public Veterinaire AjouterVeterinaire(string nomVeto, string motDePasse, bool archive)
        {
            return VeterinaireStore.Ajouter(nomVeto,motDePasse,archive);
        }

        public void ModifierVeterinaire(Veterinaire veterinaire, string nomVeto, string motDePasse, bool archive)
        {
            VeterinaireStore.Modifier(veterinaire,nomVeto, motDePasse, archive);
        }

        public bool SupprimerVeterinaire(Veterinaire veterinaire)
        {
            return Database.Instance.delete(veterinaire);
        }

    }
}
