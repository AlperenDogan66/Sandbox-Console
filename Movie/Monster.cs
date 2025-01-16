using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class Monster : Personnage
    {
        public int Strength { get; set; }

        public override string Hallo()
        {
            return "MUAHHAHAHA IK BEN EEN MONSTER";
        }

    }
}
