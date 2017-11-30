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
        int temperature;
        string precipitateType;
        string sky;
        bool isPrecipitate;
        bool isWhichPrecipitate;
        bool isSunshine;
        Random random = new Random();
        Month month = new Month(0);
        int ForecastTemperature()
        {
            temperature = random.Next(climate.TempLowAvg, climate.TempHighAvg);
            return temperature;
        }
        public int Temperature
        {
            get { return ForecastTemperature(); }
            set { temperature = value; }
        }
        public string PrecipitateType
        {
            get { return GetPrecipitate(); }
            set { precipitateType = value; }
        }
        public string Sky
        {
            get { return GetSky(); }
            set { sky = value; }
        }
        public Forecast(int temperature, string precipitateType, string sky)
        {
            this.temperature = Temperature;
            this.precipitateType = PrecipitateType;
            this.sky = Sky;
        }
        string GetPrecipitate()
        {
            GetPrecipitationChance();
            if (isPrecipitate == true)
            {
                return DeterminePrecipitate();
            }
            else
            {
                precipitateType = "Dry";
            }
            return precipitateType;
        }
        string DeterminePrecipitate()
        {
            GetPrecipitationChance();
            GetPrecipitateTypeChance();
            if (isWhichPrecipitate == true)
            {
                precipitateType = "Snowing";
            }
            else
            {
                precipitateType = "Raining";
            }
            return precipitateType;
        }
        bool GetPrecipitationChance()
        {
            int thisMonth = month.ThisMonth;
            if (thisMonth == 1)
            {
                if (random.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 2)
            {
                if (random.Next(28) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 3)
            {
                if (random.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 4)
            {
                if (random.Next(30) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 5)
            {
                if (random.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 6)
            {
                if (random.Next(30) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 7)
            {
                if (random.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 8)
            {
                if (random.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 9)
            {
                if (random.Next(30) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 10)
            {
                if (random.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 11)
            {
                if (random.Next(30) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 12)
            {
                if (random.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            return isPrecipitate;
        }
        bool GetPrecipitateTypeChance()
        {
            if (random.Next(climate.PrecipDays) <= climate.SnowDays)
            {
                isWhichPrecipitate = true;
            }
            return isWhichPrecipitate;
        }
        bool GetSunshineChance()
        {
            if (random.Next(100) < climate.SunChance)
            {
                isSunshine = true;
            }
            return isSunshine;
        }
        string GetSky()
        {
            GetSunshineChance();
            if (isSunshine == true)
            {
                sky = "Sunny";
            }
            else
            {
                sky = "Overcast";
            }
            return sky;
        }
    }
}
