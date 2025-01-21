using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kleur_mixer__essential_
{
    internal class Kleur
    {
        //Properties
        public int Rood { get; set; }
        public int Groen { get; set; }
        public int Blauw { get; set; }


        //Methode
        //MengKleur
        public void MengKleur(Kleur voegKleurToe)
        {
            Rood = (voegKleurToe.Rood + Rood) / 2; 
            Groen = (voegKleurToe.Groen + Groen) / 2;
            Blauw = (voegKleurToe.Blauw + Blauw) / 2;
        }

    }
}
