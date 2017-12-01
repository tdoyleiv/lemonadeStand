using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Supply
    {
        double localShare;
        double stateShare;
        double usShare;
        Economy economy = new Economy(0, 0, 0, 0);
        public double LocalShare
        {
            get { return GetLocalShare(); }
            set { localShare = value; }
        }
        public double StateShare
        {
            get { return GetStateShare(); }
            set { stateShare = value; }
        }
        public double USShare
        {
            get { return GetUSShare(); }
            set { usShare = value; }
        }
        public Supply(double localShare, double stateShare, double usShare)
        {
            this.localShare = LocalShare;
            this.stateShare = StateShare;
            this.usShare = USShare;
        }
        double GetUSShare()
        {
            return usShare = economy.USGDP / economy.GlobalGDP;
        }
        double GetStateShare()
        {
            return stateShare = economy.StateGDP / economy.USGDP;
        }
        double GetLocalShare()
        {
            return localShare = economy.LocalGDP / economy.StateGDP;
        }
    }
}
