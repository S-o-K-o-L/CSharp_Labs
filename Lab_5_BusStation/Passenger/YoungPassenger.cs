using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_BusStation.Passenger
{
    public class YoungPassenger : Passenger
    {
        public YoungPassenger(Action<string> message, double defaultX, double defaultY) : base(message, defaultX, defaultY)
        {
            Random rnd = new Random();
            age = rnd.Next(5, 20);
            passangerType = "Молодой пассажир";
        }
    }
}
