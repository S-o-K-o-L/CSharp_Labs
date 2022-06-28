using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_BusStation
{
    public abstract class Model
    {
        public double posX { get; internal set; }

        public double posY { get; internal set; }

        public bool IsLocked { get; internal set; }

        public bool IsCanceled { get; set; }

        public abstract void Start();

        public Action<string> Message;

        public Model(Action<string> message) => Message = message;
    }
}
