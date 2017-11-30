using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Weather
    {
        MKEClimate climate = new MKEClimate(0, 0, 0, 0, 0, 0, 0);
        int temperature;
        string precipitateType;
        string sky;
        bool isWhichPrecipitate;
        bool isPrecipitate;
        bool isSunshine;
        Random random = new Random();
        Month month = new Month(0);
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public string PrecipitateType
        {
            get { return precipitateType; }
            set { precipitateType = value; }
        }
        public string Sky
        {
            get { return sky; }
            set { sky = value; }
        }
        public Weather(int temperature, string precipitateType, string sky)
        {
            this.temperature = Temperature;
            this.precipitateType = PrecipitateType;
            this.sky = Sky;
        }
        int GetTemperature()
        {
            return RandomizeTemperature();
        }
        int RandomizeTemperature()
        {
            int thisMonth = month.ThisMonth;
            if (thisMonth == 1)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            else if (thisMonth == 2)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            else if (thisMonth == 3)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            else if (thisMonth == 4)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            else if (thisMonth == 5)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            else if (thisMonth == 6)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            else if (thisMonth == 7)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            else if (thisMonth == 8)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            else if (thisMonth == 9)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            else if (thisMonth == 10)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            else if (thisMonth == 11)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            else if (thisMonth == 12)
            {
                temperature = random.Next(climate.TempLow, climate.TempHigh);
            }
            return temperature;
        }
        string GetPrecipitate()
        {
            if (isPrecipitate == true)
            {
                return GetPrecipitateType();
            }
            else
            {
                precipitateType = "Dry";
            }
            return precipitateType;
        }
        string GetPrecipitateType()
        {
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
            int thisMonth = month.ThisMonth;
            if (thisMonth == 1)
            {
                if (random.Next(climate.PrecipDays) <= climate.SnowDays)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 2)
            {
               if (random.Next(climate.PrecipDays) <= climate.SnowDays)
                {
                    isWhichPrecipitate = true;
                }
                else
                {
                    isWhichPrecipitate = false;
                }
            }
            else if (thisMonth == 3)
            {
                if (random.Next(climate.PrecipDays) <= climate.SnowDays)
                {
                    isWhichPrecipitate = true;
                }
                else
                {
                    isWhichPrecipitate = false;
                }
            }
            else if (thisMonth == 4)
            {
                if (random.Next(climate.PrecipDays) <= climate.SnowDays)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 5)
            {
                if (random.Next(climate.PrecipDays) <= climate.SnowDays)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 6)
            {
                if (random.Next(climate.PrecipDays) <= climate.PrecipDays)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 7)
            {
                if (random.Next(climate.PrecipDays) <= climate.PrecipDays)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 8)
            {
                if (random.Next(climate.PrecipDays) <= climate.PrecipDays)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 9)
            {
                if (random.Next(climate.PrecipDays) <= climate.PrecipDays)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 10)
            {
                if (random.Next(climate.PrecipDays) <= climate.SnowDays)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 11)
            {
                if (random.Next(climate.PrecipDays) <= climate.SnowDays)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 12)
            {
                if (random.Next(climate.PrecipDays) <= climate.SnowDays)
                {
                    isWhichPrecipitate = true;
                }
            }
            return isWhichPrecipitate;
        }
    }
}
