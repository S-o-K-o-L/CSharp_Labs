using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Time
{
    class Minute
    {
        public int CountMinute { get; set; }
        public int CountSecond { get; set; }
        public Minute()
        {
            CountMinute = 0;
            CountSecond = 0;
        }
        public Minute(int countMinute)
        {
            if (countMinute < 0)
                throw new ArgumentException("Invalid value");

            CountMinute = countMinute;
            CountSecond = countMinute * 60;
        }
    }
}
