using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Cup
    {
        double globalSupplyUnits = 130000000000;
        double localSupply;
        double bulk;
        double cupsPerPack = 50;
        int amount;
        double price = 4.25;
        Supply supply = new Supply(0, 0, 0);
        double LocalSupply
        {
            get { return GetLocalSupply(); }
            set { localSupply = value; }
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
        public Cup(int amount, double price)
        {
            this.amount = Amount;
            this.price = Price;
        }
        double GetLocalSupply()
        {
            return localSupply = Math.Floor(((globalSupplyUnits * supply.USShare) * supply.StateShare) * supply.LocalShare);
        }
        double ConvertToBulk()
        {
            return bulk = LocalSupply / cupsPerPack;
        }
        int GetAmount()
        {
            return amount = (int)LocalSupply;
        }
    }
}
