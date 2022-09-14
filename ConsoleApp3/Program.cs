using System;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tack för att du valde att hyra bil hoss oss.");
            Console.WriteLine("Hur många dagar hade ni tänkt att hyra bilen? ");
            string Days = Console.ReadLine();
            Console.WriteLine("Hur långt hade ni tänkt att köra med bilen? ");
            string Distance = Console.ReadLine();
            int iDays = int.Parse(Days);
            int iDistace = int.Parse(Distance);
            int Cost = 300 + iDays * 500 + iDistace;
            Console.WriteLine("er kostnad är: " + Cost);

        }
    }
}