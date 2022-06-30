using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_BusStation.Passenger
{
    public abstract class Passenger : MovingModel, IPassenger 
    {
        public string passangerType;
        public int age;
        Station station;
        Random random = new Random();
        public int randChange = 10; 
        public Passenger(Station station,Action<string> message, double defaultX, double defaultY) : base(message, defaultX, defaultY) 
        { 
            this.station = station;
            randChange = random.Next(-100, 50);
        }
        protected override void CheckEvents()
        {
            if(!IsLocked)
            {
                MoveToX = station.posX + 50 + randChange;
                MoveToY = station.posY;
            }
        }       
    }
}
