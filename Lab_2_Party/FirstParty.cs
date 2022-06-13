namespace Lab_2_Party
{
    public class FirstParty
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public double Percantage { get; set; }
        public FirstParty(string name, int size, double percantage)
        {
            Name = name;
            Size = size;
            Percantage = percantage;
        }
        public FirstParty()
        {
            Name = "";
            Size = 0;
            Percantage = 0;
        }
        public virtual double Quality() => 0.3 * Size + 0.7 * Percantage;
        public override string ToString()
        {
            return $"Название: {Name}\r\nЧисленность: {Size}\r\nПроцент голосов на прошлых выборах: {Percantage}%";
        }
    }
}