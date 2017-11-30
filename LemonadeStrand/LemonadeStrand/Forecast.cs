using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    class Forecast
    {
        MKEClimate climate = new MKEClimate(0, 0, 0, 0, 0, 0, 0);
        int forecastTemperature;
        Random random = new Random();
        Month month = new Month(0);
        public int RandomizeTemperature()
        {
            int thisMonth = month.ThisMonth;
            if (thisMonth == 1)
            {
                forecastTemperature = random.Next(15, 30);
            }
            else if (thisMonth == 2)
            {
                forecastTemperature = random.Next(19, 33);
            }
            else if (thisMonth == 3)
            {
                forecastTemperature = random.Next(28, 42);
            }
            else if (thisMonth == 4)
            {
                forecastTemperature = random.Next(37, 58);
            }
            else if (thisMonth == 5)
            {
                forecastTemperature = random.Next(47, 65);
            }
            else if (thisMonth == 6)
            {
                forecastTemperature = random.Next(57, 75);
            }
            else if (thisMonth == 7)
            {
                forecastTemperature = random.Next(63, 80);
            }
            else if (thisMonth == 8)
            {
                forecastTemperature = random.Next(63, 79);
            }
            else if (thisMonth == 9)
            {
                forecastTemperature = random.Next(55, 71);
            }
            else if (thisMonth == 10)
            {
                forecastTemperature = random.Next(43, 59);
            }
            else if (thisMonth == 11)
            {
                forecastTemperature = random.Next(32, 46);
            }
            else if (thisMonth == 12)
            {
                forecastTemperature = random.Next(20, 33);
            }
            return forecastTemperature;
        }
    }
}
