using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Party
{
    public class SecondParty : FirstParty
    {
        public int LastYearSize { get; set; }
        public SecondParty(string name, int size, double percent,int lastYearPercentage) : base(name, size, percent)
        {
            LastYearSize = lastYearPercentage;
        } 
        public SecondParty()
        {
            LastYearSize = 0;
        }
        public override double Quality()
        {
            if (Size > LastYearSize)
                return base.Quality() * 1.2;
            else
                return base.Quality() * 0.8;
        }
        public override string ToString()
        {
            return base.ToString() + $"\r\nЧисленность в прошлом году: {LastYearSize}";
        }
    }
}
