using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Tools;
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
            private set { _race = value; }
        }

        private string _espece;

        [Persist(System.Data.SqlDbType.VarChar)]
        public string Espece
        {
            get { return _espece; }
            private set { _espece = value; }
        }

        public string Nom
        {
            get { return Espece + ":" + Race_; }
        }

        public Race(string race,string espece)
        {
            Race_ = race;
            Espece = espece;
        }
    }
}
