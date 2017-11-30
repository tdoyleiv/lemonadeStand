using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Day
    {
        int day;
        public int ThisDay
        {
            get { return GetDay(); }
            set { day = value; }
        }
        public Day(int day)
        {
            this.day = ThisDay;
        }
        int GetDay()
        {
            DateTime today = DateTime.Today;
            return day = today.Day;
        }
    }
}
