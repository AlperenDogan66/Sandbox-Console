using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apparaat
{
    internal class Laptop : Apparaat
    {
        //Properties
        public string Resolution { get; set; }
        public string Processor { get; set; }
        public string Brand { get; set; }

        public override string Melding()
        {
            return Resolution;
        }

        //Lege Construtor
        public Laptop()
        {
            
        }
        //Overloaded Constructor
        public Laptop(string resolution, string processor, string brand, string voeding, string gewicht) : base(voeding, gewicht)
        {
            Resolution = resolution;
            Processor = processor;
            Brand = brand;
        }
        //Override ToString
        public override string ToString()
        {
            return base.Info() + $", Resolution: {Resolution}, Processor: {Processor}, Merk: {Brand}";
        }
    }
}
