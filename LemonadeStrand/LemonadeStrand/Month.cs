using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStrand
{
    public class Month
    {
        int month;
        public int ThisMonth
        {
            get { return month; }
            set { month = value; }
        }
        public Month(int month)
        {
            this.month = month;
        }
        public int DetermineMonth()
        {
            DateTime today = DateTime.Today;
            return month = today.Month;
        }
    }
}
