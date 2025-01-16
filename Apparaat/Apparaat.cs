using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apparaat
{
    internal abstract class Apparaat
    {
        //Properties
        public static int AantalObjecten = 0;
        public string Voeding { get; set; }
        public string Gewicht { get; set; }

        public abstract string Melding();

        //Methode Info
        public virtual string Info()
        {
            return $"Gewicht: {Gewicht}, Voeding: {Voeding}";
        }
        //Lege Constructor
        public Apparaat()
        {
            AantalObjecten++;
        }
        //Overloaded Constructor (H11: Zie Scherp Scherper)
        public Apparaat(string voeding, string gewicht)
        {
            Voeding = voeding;
            Gewicht = gewicht;
        }   
    }
}
