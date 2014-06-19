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
                _animaux = Animaux = new BindingList<Animal>(
                    AnimalStore.Instance.Animaux.FindAll((Animal a) => a.Archive == false)
                );
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

        }
        #endregion
        #region methods
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
        /// <exception cref="Exception"></exception>
        public Animal AjouterAnimal(string nomAnimal, Animal.eSexe sexe, string couleur, Race race,
             string tatouage, string antecedant, bool archive, Client client)
        {
            try
            {
                Animal a = AnimalStore.Instance.Ajouter(nomAnimal, sexe, couleur, race, tatouage, antecedant, archive, client);
                _animaux.Add(a);
                return a;
            }
            catch (Exception e)
            {
                throw e;
            }
            return null;
        }
        /// <summary>
        /// Modifier animal
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="nomAnimal"></param>
        /// <param name="sexe"></param>
        /// <param name="couleur"></param>
        /// <param name="race"></param>
        /// <param name="tatouage"></param>
        /// <param name="antecedents"></param>
        /// <param name="client"></param>
        /// <param name="archive"></param>
        /// <exception cref="Exception"></exception>
        public void ModifierAnimal(Animal animal, string nomAnimal, Animal.eSexe sexe, string couleur, Race race,
             string tatouage, string antecedents, Client client, bool archive = false)
        {
            try
            {
                AnimalStore.Instance.Modifier(animal, nomAnimal, sexe, couleur, race, tatouage, antecedents, archive, client);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// archive un animal
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>vrai ou faux</returns>
        /// <exception cref="Exception"></exception>
        public bool SupprimerAnimal(Animal animal)
        {
            try 
	        {
                if (AnimalStore.Instance.Supprimer(animal))
                {
                    _animaux.Remove(animal);
                    return true;
                }
            }
	        catch (Exception e)
	        {
                throw e;
	        }
            return false;
        }

        public BindingList<Animal> getAnimalPourClient(Client client)
        {
            return new BindingList<Animal>(AnimalController.Instance.Animaux.ToList<Animal>().FindAll(
                (Animal a) =>
                {
                    return a.Client.Equals(client);
                }
            ));
        }
        #endregion
    }
}
