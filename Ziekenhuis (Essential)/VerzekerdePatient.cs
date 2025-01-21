using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziekenhuis__Essential_
{
    internal class VerzekerdePatient : Patient
    {
        //Variabalen
        double totaalBasisKost;
        private double korting = 0.1;


        //Methode
        //Constructor
        public VerzekerdePatient()
        {

        }
        //BerekenKost
        public override double BerekenKost()
        {
            totaalBasisKost = base.BerekenKost();

            return totaalBasisKost - (totaalBasisKost * korting);
        }
    }
}
