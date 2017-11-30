﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Weather : GreatLakesClimate
    {
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
        string GetPrecipitate()
        {
            if (isPrecipitate == true)
            {
                return GetPrecipitateType();
            }
            else
            {
                precipitateType = "dry";
            }
            return precipitateType;
        }
        string GetPrecipitateType()
        {
           GetPrecipitateTypeChance();
            if (isWhichPrecipitate == true)
            {
                precipitateType = "Snow";
            }
            else
            {
                precipitateType = "Rain";
            }
            return precipitateType;
        }
        bool GetPrecipitationChance()
        {
            int thisMonth = month.ThisMonth;
            if (thisMonth == 1)
            {
                if (random.Next(31) <= 11)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 2)
            {
                if (random.Next(28) <= 10)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 3)
            {
                if (random.Next(31) <= 11)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 4)
            {
                if (random.Next(30) <= 12)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 5)
            {
                if (random.Next(31) <= 11)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 6)
            {
                if (random.Next(30) <= 10)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 7)
            {
                if (random.Next(31) <= 10)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 8)
            {
                if (random.Next(31) <= 10)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 9)
            {
                if (random.Next(30) <= 9)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 10)
            {
                if (random.Next(31) <= 10)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 11)
            {
                if (random.Next(30) <= 11)
                {
                    isPrecipitate = true;
                }
            }
            else if (thisMonth == 12)
            {
                if (random.Next(31) <= 11)
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
                if (random.Next(10) <= 9)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 2)
            {
               if (random.Next(10) <= 8)
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
                if (random.Next(100) <= 54)
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
                if (random.Next(100) <= 17)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 5)
            {
                if (random.Next(1000) <= 9)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 10)
            {
                if (random.Next(100) <= 3)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 11)
            {
                if (random.Next(100) <= 27)
                {
                    isWhichPrecipitate = true;
                }
            }
            else if (thisMonth == 12)
            {
                if (random.Next(25) <= 18)
                {
                    isWhichPrecipitate = true;
                }
            }
            return isWhichPrecipitate;
        }
    }
}
