using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Inventory
    {
        Lemon lemon = new Lemon(0, 0);
        Sugar sugar = new Sugar(0, 0);
        Cup cup = new Cup(0, 0);
        Ice ice = new Ice();
    }
}
