﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_BusStation
{
    public class Bus : MovingModel
    {
        Station station;
        public bool IsFull { get;  set; } 
        public int Capacity { get; set; }
        public Bus(Station station,int capacity, Action<string> message, double defaultX, double defaultY) : base(message, defaultX, defaultY)
        {
            this.station = station;
            this.Capacity = capacity;
        }
        public bool RandomFull()
        {
            Random rnd = new Random();
            if (rnd.Next(0,100)<30)
            {
                Message("Автобус " + Name + " переполнен!");
                IsFull = true;
            }
            return IsFull;
        }

        protected override void CheckEvents()
        {
            if (!IsLocked)
            {
                if (IsFull)
                {
                    MoveToX = station.posX + 500;
                    MoveToY = station.posY;
                }
                else
                {
                    MoveToX = defaultX;
                    MoveToY = defaultY;
                }
            }      
        }
    }
}
