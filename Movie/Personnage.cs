using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class Personnage
    {
        public string Naam { get; set; }

        public virtual string Hallo()
        {
            return $"Hallo ik ben {Naam}";
        }

        public Personnage()
        {

        }

        public Personnage(string naam)
        {
            Naam = naam ;
        }
    }
}
