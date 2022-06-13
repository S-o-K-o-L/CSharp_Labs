using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Time
{
    class Hour
    {
        public int CountHour { get; set; }
        public int CountMinute { get; set; }
        public Hour()
        {
            CountHour = 0;
            CountMinute = 0;
        }
        public Hour(int countHour)
        {
            if (countHour < 0)
                throw new ArgumentException("Invalid value");

            CountHour = countHour;
            CountMinute = countHour * 60;
        }
    }
}
