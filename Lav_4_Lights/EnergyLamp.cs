using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lav_4_Lights
{
    public class EnergyLamp : Lamp
    {
        public int WorkTime { get; set; }
        public string MaterialType { get; set; }    
        public override string InformationAboutLamp()
        {
            return "Информация о товаре: " + ToString();
        }
        public override string ToString()
        {
            return " \r\nМодель: " + Brand + " \r\nСтоимость: " + Price + " \r\nЦвет: " + Color + " \r\nМощность: " + Power 
                + " \r\nВес: " + Weight + " \r\nВремя работы: " + WorkTime + " \r\nМатериал: " + MaterialType;
        }

        public string ActualWorkTime()
        {
            return $"Лампа проработает {WorkTime * 3} часов";
        }
        public string SetLamp()
        {
            return "Лампочка успешно вкручена!";
        }
    }
}
