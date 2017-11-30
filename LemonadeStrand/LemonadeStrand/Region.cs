using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Region
    {
        string name;
        double gdpPerCapita;
        public string RegionName
        {
            get { return GetRegionName(); }
            set { name = value; }
        }
        public double RegionGDPPerCapita
        {
            get { return GetRegionGDPPerCapita(); }
            set { gdpPerCapita = value; }
        }
        public Region (string name, double gdpPerCapita)
        {
            this.name = RegionName;
            this.gdpPerCapita = RegionGDPPerCapita;
        }
       string GetRegionName()
        {
            return name = "Milwaukee";
        }
        double GetRegionGDPPerCapita()
        {
            return gdpPerCapita = 58701.00;
        }
    }
}
