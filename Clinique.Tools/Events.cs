using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Tools
{
    public delegate void EventValider<T>(T obj);
    public delegate void EventAnnuler<T>(T obj);

}
