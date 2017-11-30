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
            forecastTemperature = random.Next(climate.TempLowAvg, climate.TempHighAvg);
            return forecastTemperature;
        }
    }
}
