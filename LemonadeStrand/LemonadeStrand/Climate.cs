using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Climate
    {
        Month month = new Month(0);
        int tempHigh;
        int tempLow;
        int tempHighAvg;
        int tempLowAvg;
        int precipDays;
        int snowDays;
        int sunChance;
        public int TempHigh
        {
            get { return GetTempHigh(); }
            set { tempHigh = value; }
        }
        public int TempLow
        {
            get { return GetTempLow(); }
            set { tempLow = value; }
        }
        public int TempHighAvg
        {
            get { return GetTempHighAvg(); }
            set { tempHighAvg = value; }
        }
        public int TempLowAvg
        {
            get { return GetTempLowAvg(); }
            set { tempLowAvg = value; }
        }
        public int PrecipDays
        {
            get { return GetPrecipDays(); }
            set { precipDays = value; }
        }
        public int SnowDays
        {
            get { return GetSnowDays(); }
            set { snowDays = value; }
        }
        public int SunChance
        {
            get { return GetSunChance(); }
            set { sunChance = value; }
        }
        public Climate(int tempHigh, int tempLow, int tempHighAvg, int tempLowAvg, int precipDays, int snowDays, int sunChance)
        {
            this.tempHigh = TempHigh;
            this.tempLow = TempLow;
            this.tempHighAvg = TempHighAvg;
            this.tempLowAvg = TempLowAvg;
            this.precipDays = PrecipDays;
            this.snowDays = SnowDays;
            this.sunChance = SunChance;
        }
        int GetTempHigh()
        {
            GetClimateData();
            return tempHigh;
        }
        int GetTempLow()
        {
            GetClimateData();
            return tempLow;
        }
        int GetTempHighAvg()
        {
            GetClimateData();
            return tempHighAvg;
        }
        int GetTempLowAvg()
        {
            GetClimateData();
            return tempHighAvg;
        }
        int GetPrecipDays()
        {
            GetClimateData();
            return precipDays;
        }
        int GetSnowDays()
        {
            GetClimateData();
            return snowDays;
        }
        int GetSunChance()
        {
            GetClimateData();
            return sunChance;
        }
        void GetClimateData()
        {
            int thisMonth = month.ThisMonth;
            if (thisMonth == 1)
            {
                tempHigh = 63;
                tempLow = -26;
                tempHighAvg = 29;
                tempLowAvg = 16;
                precipDays = 11;
                snowDays = 10;
                sunChance = 48;
            }
            else if (thisMonth == 2)
            {
                tempHigh = 71;
                tempLow = -26;
                tempHighAvg = 33;
                tempLowAvg = 19;
                precipDays = 10;
                snowDays = 8;
                sunChance = 51;
            }
            else if (thisMonth == 3)
            {
                tempHigh = 84;
                tempLow = -10;
                tempHighAvg = 42;
                tempLowAvg = 28;
                precipDays = 11;
                snowDays = 6;
                sunChance = 50;
            }
            else if (thisMonth == 4)
            {
                tempHigh = 91;
                tempLow = 12;
                tempHighAvg = 42;
                tempLowAvg = 37;
                precipDays = 12;
                snowDays = 2;
                sunChance = 53;
            }
            else if (thisMonth == 5)
            {
                tempHigh = 94;
                tempLow = 21;
                tempHighAvg = 65;
                tempLowAvg = 47;
                precipDays = 11;
                snowDays = 0;
                sunChance = 61;
            }
            else if (thisMonth == 6)
            {
                tempHigh = 104;
                tempLow = 33;
                tempHighAvg = 75;
                tempLowAvg = 57;
                precipDays = 10;
                snowDays = 0;
                sunChance = 66;
            }
            else if (thisMonth == 7)
            {
                tempHigh = 105;
                tempLow = 40;
                tempHighAvg = 80;
                tempLowAvg = 64;
                precipDays = 10;
                snowDays = 0;
                sunChance = 69;
            }
            else if (thisMonth == 8)
            {
                tempHigh = 103;
                tempLow = 42;
                tempHighAvg = 79;
                tempLowAvg = 63;
                precipDays = 10;
                snowDays = 0;
                sunChance = 65;
            }
            else if (thisMonth == 9)
            {
                tempHigh = 99;
                tempLow = 28;
                tempHighAvg = 60;
                tempLowAvg = 55;
                precipDays = 9;
                snowDays = 0;
                sunChance = 57;
            }
            else if (thisMonth == 10)
            {
                tempHigh = 89;
                tempLow = 15;
                tempHighAvg = 59;
                tempLowAvg = 43;
                precipDays = 10;
                snowDays = 1;
                sunChance = 52;
            }
            else if (thisMonth == 11)
            {
                tempHigh = 77;
                tempLow = -14;
                tempHighAvg = 46;
                tempLowAvg = 32;
                precipDays = 11;
                snowDays = 3;
                sunChance = 38;
            }
            else if (thisMonth == 12)
            {
                tempHigh = 68;
                tempLow = -22;
                tempHighAvg = 33;
                tempLowAvg = 20;
                precipDays = 11;
                snowDays = 8;
                sunChance = 37;
            }
        }
    }
}
