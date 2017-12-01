using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Sugar
    {
        double globalSupplyTonnes = 179640000;
        double localSupplyLBS;
        double avgCupsPerLB = 2;
        int amount;
        double price = 0.66;
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
        double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Sugar(int amount, double price)
        {
            this.amount = Amount;
            this.price = Price;
        }
        double GetLocalSupplyLBS()
        {
            return localSupplyLBS = Math.Floor((((globalSupplyTonnes * supply.USShare) * supply.StateShare) * supply.LocalShare) * 2000);
        }
        int GetAmount()
        {
            return amount = (int)LocalSupply;
        }
    }
}
