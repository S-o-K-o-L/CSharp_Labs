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
        public Passenger(Action<string> message, double defaultX, double defaultY) : base(message, defaultX, defaultY) { }
        protected override void CheckEvents()
        {
            if(!IsLocked)
            {
                MoveToX = defaultX;
                MoveToY = defaultY;
            }
        }
    }
}
