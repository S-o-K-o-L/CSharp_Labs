namespace Lab_Time
{
    public class Day
    {
        private Hour Hour { get; set; }
        private Minute Minute { get; set; }

        public Day(int hour, int minute)
        {
            if (hour > 24 || minute > 59)
                throw new ArgumentException("Invalid value");
            Hour = new Hour(hour);
            Minute = new Minute(minute);
        }
        public Day()
        {
            Hour = new Hour(0);
            Minute = new Minute(0);
        }
        public string GetCurrentTime()
        {
            string strHour = Hour.CountHour.ToString();
            string strMinute = Minute.CountMinute.ToString();
            if (strHour.Length < 2) strHour = "0" + strHour;
            if(strMinute.Length < 2) strMinute = "0" + strMinute;
            return strHour + ":" + strMinute;
        }
        public string GetCurrentTimeOfDay()
        {
            if (Hour.CountHour >= 4 && Hour.CountHour < 10) return "Утро";
            if (Hour.CountHour >= 10 && Hour.CountHour < 16) return "День";
            if (Hour.CountHour >= 16 && Hour.CountHour < 22) return "Вечер";
            if (Hour.CountHour >= 22 || Hour.CountHour < 4) return "Ночь";
            throw new Exception("Invalid value");
        }
    }
}