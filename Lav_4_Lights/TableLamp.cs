using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lav_4_Lights
{
    public class TableLamp : Lamp
    {
        public int Size { get; set; }
        public string Type { get; set; }
        public override string InformationAboutLamp()
        {
            return "Информация о товаре: "+ ToString();
        }
        public override string ToString()
        {
            return " \r\nМодель: " + Brand + " \r\nСтоимость: " + Price + " \r\nЦвет: " + Color + " \r\nМощность: " + Power 
                + " \r\nВес: " + Weight +" \r\nРазмер: " + Size +" \r\nТип: " + Type;
        }
        public string TurnOnLamp() => "Вы включили настольную лампу!";
        public string Quality()
        {
            Random rand = new Random();
            if (rand.Next(0, 2) == 1)
                return "Качественная лампа!";
            else
                return "Не качественная лампа!";
        }
        public string TryThiefLamp()
        {
            Random rand = new Random();
            if (rand.Next(0, 2) == 1)
                return "Вы украли лампу!";
            else
                return "Вас поймали и посадили в тюрьму за кражу!";
        }
    }
}
