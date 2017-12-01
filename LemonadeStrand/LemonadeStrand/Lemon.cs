using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Lemon
    {
        double globalSupplyTonnes = 3500000;
        double localSupplyLBS;
        double LemonsPerLB = 4;
        double bulk;
        int amount;
        double price = 0.50;
        Supply supply = new Supply(0, 0, 0);
        double LocalSupply
        {
            get { return GetLocalSupplyLBS(); }
            set { localSupplyLBS = value; }
        }
        public int Amount
        {
            get { return GetAmount(); }
            set { amount = value; }
        }
        double Bulk
        {
            get { return ConvertToBulk(); }
            set { bulk = value; }
        }
        double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Lemon(int amount, double price)
        {
            this.amount = Amount;
            this.price = Price;
        }
        double GetLocalSupplyLBS()
        {
            return localSupplyLBS = Math.Floor((((globalSupplyTonnes * supply.USShare) * supply.StateShare) * supply.LocalShare) * 2000);
        }
        double ConvertToBulk()
        {
            return bulk = LocalSupply / LemonsPerLB;
        }
        int GetAmount()
        {
            return amount = (int)Bulk;
        }
    }
}
