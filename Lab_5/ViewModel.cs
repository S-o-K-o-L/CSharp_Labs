﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab_5_BusStation;

namespace Lab_5
{
    public class ViewModel : Object
    {
        public Model Model { get; }

        public override double X { get => Model.posX; }

        public override double Y { get => Model.posY; }

        public ViewModel(Model model, Image image, double x, double y) : base(image, x, y) => Model = model;
    }
}
