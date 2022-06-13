using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightSource
{
    public abstract class Lamp : ILightSource
    {
        public string Color { get; set; }
        public int Power { get; set; }
        public int Weight { get; set; }
        public bool TryToLightRoom(int areaSquare)
        {
            return Power/3 >= areaSquare;
        }
        public string LightingRoom(int areaSquare)
        {
            if (TryToLightRoom(areaSquare))
                return "Комната успешно освещена!";
            else
                return $"Мощности лампы недостаточно, чтобы осветить комнату!\r\nВам нужна лампа мощностью {areaSquare * 3}";
        }
        public abstract string InformationAboutLamp();
    }
}
