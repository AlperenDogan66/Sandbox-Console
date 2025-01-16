using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class Held : Personnage
    {
        public string SuperKracht { get; set; }

        public override string Hallo()
        {
            return $"Ik ben superheld {Naam} en kan heel erg goed {SuperKracht}";
        }

        public Held(string superKracht, string naam) : base(naam)
        {
            SuperKracht = superKracht;
        }
    }
}
