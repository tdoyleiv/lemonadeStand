using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    class Forecast
    {
        Climate climate = new Climate(0, 0, 0, 0, 0, 0, 0);
        int temperature;
        string precipitateType;
        string sky;
        bool isPrecipitate;
        bool isWhichPrecipitate;
        bool isSunshine;
        Game game = new Game(null);
        Month month = new Month(0);
        int ForecastTemperature()
        {
            temperature = game.RNG.Next(climate.TempLowAvg, climate.TempHighAvg);
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
                if (game.RNG.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 2)
            {
                if (game.RNG.Next(28) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 3)
            {
                if (game.RNG.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 4)
            {
                if (game.RNG.Next(30) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 5)
            {
                if (game.RNG.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 6)
            {
                if (game.RNG.Next(30) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 7)
            {
                if (game.RNG.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 8)
            {
                if (game.RNG.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 9)
            {
                if (game.RNG.Next(30) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 10)
            {
                if (game.RNG.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 11)
            {
                if (game.RNG.Next(30) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 12)
            {
                if (game.RNG.Next(31) <= climate.PrecipDays)
                {
                    isPrecipitate = true;
                }
            }
            return isPrecipitate;
        }
        bool GetPrecipitateTypeChance()
        {
            if (game.RNG.Next(climate.PrecipDays) <= climate.SnowDays)
            {
                isWhichPrecipitate = true;
            }
            return isWhichPrecipitate;
        }
        bool GetSunshineChance()
        {
            if (game.RNG.Next(100) < climate.SunChance)
            {
                isSunshine = true;
            }
            return isSunshine;
        }
        string GetSky()
        {
            GetSunshineChance();
            GetPrecipitationChance();
            if (isSunshine == true && isPrecipitate == false)
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
