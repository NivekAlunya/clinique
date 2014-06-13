using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
namespace Clinique.Store
{
    public static class RaceStore
    {
        public static Race Ajouter(string race_, string espece)
        {
            Race race = new Race(race_,espece);

            Database.Instance.insert(race);

            return race;
        }

        public static bool Supprimer(Race race)
        {
            return Database.Instance.delete(race);
        }
    }
}
