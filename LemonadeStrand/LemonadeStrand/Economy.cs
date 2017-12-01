using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Economy
    {
        double globalGDP = 78280;
        double usGDP = 18750;
        double stateGDP = 232.3;
        double localGDP = 102.21;
        public double GlobalGDP
        {
            get { return globalGDP; }
            set { globalGDP = value; }
        }
        public double USGDP
        {
            get { return usGDP; }
            set { usGDP = value; }
        }
        public double StateGDP
        {
            get { return stateGDP; }
            set { stateGDP = value; }
        }
        public double LocalGDP
        {
            get { return localGDP; }
            set { localGDP = value; }
        }
        public Economy(double globalGDP, double usGDP, double stateGDP, double localGDP)
        {
            this.globalGDP = GlobalGDP;
            this.usGDP = USGDP;
            this.stateGDP = StateGDP;
            this.localGDP = LocalGDP;
        }
    }
}
