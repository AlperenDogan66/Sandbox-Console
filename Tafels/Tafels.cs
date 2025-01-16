using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tafels
{
    class Tafels
    {
        private int score;
        private int level;
        private int levelBoundary;
        private int getal1, getal2;

        public int Score { get { return score; } }
        public int Level {  get { return level; } }
        public int AantalJuisteAntwoorden
        {
            set
            {
                if (value > 0)
                {
                    levelBoundary = value;
                }
            }
        }

        public Tafels()
        {
            score = 0;
            level = 1;
            levelBoundary = 2;
            getal1 = 0;
            getal2 = 0;
        }
        public string GenereerVraag(int antwoord)
        {
            bool correct = (antwoord == getal1 * levelBoundary);
            if (correct)
            {
                score++;

                if (score % levelBoundary == 0)
                {
                    level++;
                }

            }

            return correct;
        }
    }
}
