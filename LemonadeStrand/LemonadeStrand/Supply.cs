using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public abstract class Supply
    {
        int amount;
        Region region = new Region(null, 0.00);
        int Amount
        {
            get { return GetAmount(); }
            set { amount = value; }
        }
        int GetAmount()
        {
            double share = region.RegionGDPPerCapita;
            return amount;
        }
    }
}
