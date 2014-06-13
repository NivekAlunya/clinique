using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
namespace Clinique.Store
{
    public static class AgendaStore
    {
        public static Agenda Ajouter(Veterinaire veto, Animal animal, DateTime dateRdv)
        {
            Agenda agenda = new Agenda(veto, animal, dateRdv);
            Database.Instance.insert(agenda);

            return agenda;
        }

        public static void Modifier(Agenda agenda, Veterinaire veto, Animal animal, DateTime dateRdv)
        {
            agenda.Veto = veto;
            agenda.DateRdv = dateRdv;
            agenda.Animal = animal;
            Database.Instance.update(agenda);
        }

        public static bool Supprimer(Agenda agenda)
        {
            return Database.Instance.delete(agenda);
        }
    }
}
