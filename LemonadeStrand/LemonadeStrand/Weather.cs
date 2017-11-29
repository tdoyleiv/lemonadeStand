using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Weather
    {
        int temperature;
        string precipitationType;
        bool isPrecipitate;
        bool isSunshine;
        int sunshineHours;
        Random random = new Random();
        Month month = new Month(0);
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public string PrecipitationType
        {
            get { return precipitationType; }
            set { precipitationType = value; }
        }
        public bool IsPrecipitate
        {
            get { return isPrecipitate; }
            set { isPrecipitate = value; }
        }
        public bool IsSunshine
        {
            get { return isSunshine; }
            set { isSunshine = value; }
        }
        public int SunshineHours
        {
            get { return sunshineHours; }
            set { sunshineHours = value; }
        }
        public Weather(int temperature, string precipitationType, bool isPrecipitate, bool isSunshine, int sunshineHours)
        {
            this.temperature = temperature;
            this.precipitationType = precipitationType;
            this.isPrecipitate = isPrecipitate;
            this.isSunshine = isSunshine;
            this.SunshineHours = sunshineHours;
        }
        public int GetTemperature()
        {
            return RandomizeTemperature();
        }
        public int RandomizeTemperature()
        {
            int thisMonth = month.DetermineMonth();
            if (thisMonth == 1)
            {
                temperature = random.Next(-26, 63);
            }
            else if (thisMonth == 2)
            {
                temperature = random.Next(-26, 71);
            }
            else if (thisMonth == 3)
            {
                temperature = random.Next(-10, 84);
            }
            else if (thisMonth == 4)
            {
                temperature = random.Next(12, 91);
            }
            else if (thisMonth == 5)
            {
                temperature = random.Next(21, 94);
            }
            else if (thisMonth == 6)
            {
                temperature = random.Next(33, 104);
            }
            else if (thisMonth == 7)
            {
                temperature = random.Next(40, 105);
            }
            else if (thisMonth == 8)
            {
                temperature = random.Next(42, 103);
            }
            else if (thisMonth == 9)
            {
                temperature = random.Next(28, 99);
            }
            else if (thisMonth == 10)
            {
                temperature = random.Next(15, 89);
            }
            else if (thisMonth == 11)
            {
                temperature = random.Next(-14, 77);
            }
            else if (thisMonth == 12)
            {
                temperature = random.Next(-22, 68);
            }
            return temperature;
        }
    }
}
