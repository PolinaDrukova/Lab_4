using System;

namespace Laba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstLevel f = new FirstLevel("vistar", 12, 2);
            Console.WriteLine(f.getQ());
            FirstLevel f2 = new SecondLevel("vistar", 12, 2, 3);
            Console.WriteLine(f2.getQ());
        }
    }

    public class SecondLevel : FirstLevel
    {
        public int averageSpeed { set; get; }
        public SecondLevel(string title, int quantityWorkStations, int averageDistance, int averageSpeed)
        : base(title, quantityWorkStations, averageDistance)
        {
            this.averageSpeed = averageSpeed;
        }

        public override int getQ()
        {
            return quantityWorkStations * averageDistance * averageSpeed;
        }
    }

    public class FirstLevel
    {
        public string title { get; set; }
        public int quantityWorkStations { get; set; }
        public int averageDistance { get; set; }

        public FirstLevel(string title, int quantityWorkStations, int averageDistance)
        {
            this.title = title;
            this.quantityWorkStations = quantityWorkStations;
            this.averageDistance = averageDistance;
        }

        public virtual int getQ()
        {
            return quantityWorkStations * averageDistance;
        }
    }
}
