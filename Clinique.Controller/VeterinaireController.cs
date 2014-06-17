using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using Clinique.Store;
using System.Collections;
using System.ComponentModel;

namespace Clinique.Controller
{
    /// <summary>
    /// Controller pour la classe Veterinaire
    /// </summary>
    public class VeterinaireController
    {
        #region attributes
        private BindingList<Veterinaire> _veterinaires;
        #endregion
        #region properties
        public BindingList<Veterinaire> Veterinaires
        {
            get
            {
                return _veterinaires;
            }
            private set
            {
                _veterinaires = value;
            }
        }
        #endregion
        #region Singleton pattern
        private static VeterinaireController _instance = null;
        public static VeterinaireController Instance { 
            get {
                return null == _instance ? _instance = new VeterinaireController() : _instance;
            }
        }
        private VeterinaireController()
        {
            Veterinaires = new BindingList<Veterinaire>(
                VeterinaireStore.Veterinaires.FindAll((Veterinaire v) => v.Archive == false)
            );
        }
        #endregion
        /// <summary>
        /// creer via le store un object veterianire et l'ajoute dans la bindinglist
        /// </summary>
        /// <param name="nomVeto"></param>
        /// <param name="motDePasse"></param>
        /// <param name="archive"></param>
        /// <returns>un object veterinaire</returns>
        public Veterinaire AjouterVeterinaire(string nomVeto, string motDePasse, bool archive = false)
        {
            Veterinaire v = VeterinaireStore.Ajouter(nomVeto, motDePasse, archive);
            this.Veterinaires.Add(v);

            return v;
        }

        public void ModifierVeterinaire(Veterinaire veterinaire, string nomVeto, string motDePasse, bool archive = false)
        {
            VeterinaireStore.Modifier(veterinaire,nomVeto, motDePasse, archive);
        }

        public bool SupprimerVeterinaire(Veterinaire veterinaire)
        {
            if (VeterinaireStore.Supprimer(veterinaire)) {
                this.Veterinaires.Remove(veterinaire);
                return true;
            }

            return false;
        }

    }
}
