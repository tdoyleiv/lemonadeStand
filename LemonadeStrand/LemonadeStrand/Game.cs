using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Game
    {
        Random random = new Random();
        public Random RNG
        {
            get { return random; }
            set { random = value; }
        }
        public Game(Random random)
        {
            this.random = random;
        }
    }
}
