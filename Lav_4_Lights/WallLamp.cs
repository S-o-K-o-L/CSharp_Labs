using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lav_4_Lights
{
    public class WallLamp : Lamp
    {
        public int CountFixation { get; set; }
        public string FormFactor { get; set; }
        public override string InformationAboutLamp()
        {
            return "Информация о товаре: " + ToString();
        }
        public override string ToString()
        {
            return " \r\nМодель: " + Brand + " \r\nСтоимость: " + Price + " \r\nЦвет: " + Color + " \r\nМощность: " + Power 
                + " \r\nВес: " + Weight + " \r\nКоличество креплений: "+ CountFixation+" \r\nФорм-фактор: " + FormFactor;
        }

        public string TryToSetupLampOnWall()
        {
            Random random = new Random();
            if (random.Next(0, 2) == 1)
                return "Установлено на стену!";
            else
                return "Ваших навыков недостаточно сегодня! Попробуйте завтра!";
        }
        public string DestroyLamp()
        {
            return "Вы успешно разбили настенную лампу!";
        }
    }
}
