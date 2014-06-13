using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;

namespace Clinique.Store
{
    public static class AnimalStore
    {
        public static Animal Ajouter(string nomAnimal, Clinique.Model.Animal.eSexe sexe, string couleur, Race race,
             string tatouage, string antecedant, Boolean archive, Client client)
        {
            Animal animal = new Animal(Guid.NewGuid(), nomAnimal, sexe, couleur, race, tatouage, antecedant, archive, client);
            Database.Instance.insert(animal);
            return animal;
        }

        public static void Modifier(Animal animal, string nomAnimal, Clinique.Model.Animal.eSexe sexe, string couleur, Race race,
             string tatouage, string antecedant, Boolean archive, Client client)
        {
            animal.Antecedant = antecedant;
            animal.Archive = archive;
            animal.Client = client;
            animal.Couleur = couleur;
            animal.NomAnimal = nomAnimal;
            animal.Sexe = sexe;
            animal.Tatouage = tatouage;
            animal.Race = race;

            Database.Instance.insert(animal);
        }

        public static bool Supprimer(Animal animal)
        {
            return Database.Instance.delete(animal);
        }
    }
}
