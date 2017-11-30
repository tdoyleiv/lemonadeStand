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
            get { return GetMonth(); }
            set { month = value; }
        }
        public Month(int month)
        {
            this.month = ThisMonth;
        }
        int GetMonth()
        {
            DateTime today = DateTime.Today;
            return month = today.Month;
        }
    }
}
