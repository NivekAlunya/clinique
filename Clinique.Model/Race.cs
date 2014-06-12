using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Store;
using System.Data;

namespace Clinique.Model
{
    [Persist("Races")]
    public class Race
    {
        private string _race;

        [Persist(System.Data.SqlDbType.VarChar,Persist.FieldBehaviour.pk,"Race")]
        public string Race_
        {
            get { return _race; }
            set { _race = value; }
        }

        private string _espece;

        [Persist(System.Data.SqlDbType.VarChar)]
        public string Espece
        {
            get { return _espece; }
            set { _espece = value; }
        }

        public Race(string race,string espece)
        {
            Race_ = race;
            Espece = espece;
        }
    }
}
