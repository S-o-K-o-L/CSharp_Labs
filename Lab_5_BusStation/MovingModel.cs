using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_BusStation
{
    public abstract class MovingModel : Model
    {
        public Action currentAction;
        public double defaultX, defaultY;
        public double MoveToX { get; internal set; }
        public double MoveToY { get; internal set; }
        public string Name { get; set; }
        public MovingModel(Action<string> message, double defaultX, double defaultY) : base(message)
        {
            this.defaultX = defaultX;
            this.defaultY = defaultY;
            posX = defaultX;
            posY = defaultY;
            MoveToX = defaultX;
            MoveToY = defaultY;
            currentAction = null;
        }
        const double SPEED = 3;        
        protected abstract void CheckEvents();
        public bool IsArrived() => Math.Abs(posX - MoveToX) < 5 && Math.Abs(posY - MoveToY) < 5;

        public void Move()
        {
            if (IsArrived()) return;

            if (posX - MoveToX != 0)
            {
                posX += SPEED * Math.Sign(MoveToX - posX);
                posY += SPEED * (MoveToY - posY) / Math.Abs(MoveToX - posX);
            }
            else
            {
                posX += SPEED * (MoveToX - posX) / Math.Abs(MoveToY - posY);
                posY += SPEED * Math.Sign(MoveToY - posY);
            }
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                CheckEvents();
                Move();
                currentAction?.Invoke();
                Task.Delay(30).Wait();
            }
        }
    }
}
