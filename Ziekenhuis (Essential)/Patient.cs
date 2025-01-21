using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziekenhuis__Essential_
{
    internal class Patient
    {
        //Variabalen
        int kost;

        //Properties
        public string Naam { get; set; }
        public int AantalUrenInZiekenhuis { get; set; }
        

        //Methode
        //Constructor
        public Patient()
        {

        }
        //Overload Constructor
        public Patient(string naam, int aantalUrenInZiekenhuis)
        {
            Naam = naam;
            AantalUrenInZiekenhuis = aantalUrenInZiekenhuis;
        }
        //BerekenKost
        public virtual double BerekenKost()
        {
            kost = 50 + (AantalUrenInZiekenhuis * 20);
            return kost;
        }
        //ToonInfo
        public void ToonInfo()
        {
            Console.WriteLine($"{Naam}: aantal uren = {AantalUrenInZiekenhuis} & kost = {BerekenKost()} euro");
        }
    }
}
