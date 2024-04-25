namespace PocetHvezd
{
    internal class Program
    {
        static void Main(string[] args)
        {
     

            Console.WriteLine("Zadej pocet hvezd:");

            int pocetHvezd;

            while (!int.TryParse(Console.ReadLine(), out pocetHvezd))
            {
                Console.WriteLine("To neni cislo. Zadej prosim platny vstup.");
            }

            
                for (int i = 0; i<pocetHvezd; i++)
                {
                    Console.WriteLine("*");
                }
            
        }
    }
}
