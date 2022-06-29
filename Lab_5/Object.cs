using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab_5_BusStation;

namespace Lab_5
{
    public class Object
    {
        public virtual double X { get; set; }

        public virtual double Y { get; set; }

        public Image Image { get; set; }

        public Object(Image image, double x, double y)
        {
            Image = image;
            X = x;
            Y = y;
        }
    }
}
