using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_BusStation.Passenger
{
    public class AdultPassenger : Passenger
    {
        public AdultPassenger(Action<string> message, double defaultX, double defaultY) : base(message, defaultX, defaultY)
        {
            Random rnd = new Random();
            age = rnd.Next(20, 60);
            passangerType = "Взрослый пассажир";
        }
    }
}
