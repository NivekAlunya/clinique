using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using System.Data;
using System.Collections;
using System.ComponentModel;
using Clinique.Store;

namespace Clinique.Controller
{
    /// <summary>
    /// Controller pour la classe Animal
    /// </summary>
    public class AnimalController
    {
         #region attributes
        private BindingList<Animal> _animaux;
        #endregion
        #region properties
        public BindingList<Animal> Animaux
        {
            get
            {
                return _animaux;
            }
            private set
            {
                _animaux = value;
            }
        }
        #endregion
        #region Singleton pattern
        private static AnimalController _instance = null;
        public static AnimalController Instance { 
            get {
                return null == _instance ? _instance = new AnimalController() : _instance;
            }
        }
        private AnimalController()
        {
            Animaux = new BindingList<Animal>(
                AnimalStore.Instance.Animaux.FindAll((Animal a) => a.Archive == false)
                );
        }
        #endregion
        /// <summary>
        /// creer via le store un object animal et l'ajoute dans la bindinglist
        /// </summary>
        /// <param name="nomAnimal"></param>
        /// <param name="sexe"></param>
        /// <param name="antecedant"></param>
        /// <param name="archive"></param>
        /// <param name="client"></param>
        /// <param name="couleur"></param>
        /// <param name="race"></param>
        /// <param name="tatouage"></param>
        /// <returns>un object animal</returns>
        public Animal AjouterAnimal(string nomAnimal, Animal.eSexe sexe, string couleur, Race race,
             string tatouage, string antecedant, bool archive, Client client)
        {
            Animal a = AnimalStore.Instance.Ajouter(nomAnimal, sexe, couleur, race,
             tatouage, antecedant, archive, client);
            this.Animaux.Add(a);
            return a;
        }

        public void ModifierAnimal(Animal animal, string nomAnimal, Animal.eSexe sexe, string couleur, Race race,
             string tatouage, string antecedents, Client client, bool archive = false)
        {
            AnimalStore.Instance.Modifier(animal, nomAnimal, sexe, couleur, race,
             tatouage, antecedents, archive, client);
        }

        public bool SupprimerAnimal(Animal animal)
        {
            this.Animaux.Remove(animal);
            return AnimalStore.Instance.Supprimer(animal);
        }

    }
}
