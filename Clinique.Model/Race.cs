using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Model
{
    public class Race
    {
        private string _race;

        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        private string _espece;

        public string Espece
        {
            get { return _espece; }
            set { _espece = value; }
        }
        
    }
}
