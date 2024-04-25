using static System.Collections.Specialized.BitVector32;

namespace Domaci_ukol.Secitani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Secitani Secitani = new Secitani();

            Console.WriteLine("Zadej prvni cislo:");

            double cislo1;
            while (!double.TryParse(Console.ReadLine(), out cislo1))
            {
                Console.WriteLine("To neni cislo :). Zadej prosim platne cislo:");
            }

            Console.WriteLine("Zadej druhe cislo:");

            double cislo2;
            while (!double.TryParse(Console.ReadLine(), out cislo2))
            {
                Console.WriteLine("To neni cislo :). Zadej prosim platne cislo:");
            }

            double soucet = Secitani.Secti (cislo1, cislo2);

            Console.WriteLine($"{cislo1} + {cislo2} = {soucet}");
          
        }
    }
}

