namespace HadejCislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int cislo = r.Next(0, 100);
            int hadaneCislo;


            Console.WriteLine("Hádej číslo mezi 1 a 100:");

            while (!int.TryParse(Console.ReadLine (), out hadaneCislo))
            {
                Console.WriteLine("Nezadal jsi cislo, jeste jednou a lepe :)");
            }

            while (hadaneCislo != cislo)
            {
                if (hadaneCislo < cislo)
                {
                    Console.WriteLine("Číslo je menší, hádej znovu:");

                    while (!int.TryParse(Console.ReadLine(), out hadaneCislo))
                    {
                        Console.WriteLine("Nezadal jsi cislo, jeste jednou a lepe :)");
                    }
                }
                else if (hadaneCislo > cislo)
                {
                    Console.WriteLine("Číslo je větší, hádej znovu:");

                    while (!int.TryParse(Console.ReadLine(), out hadaneCislo))
                    {
                        Console.WriteLine("Nezadal jsi cislo, jeste jednou a lepe :)");
                    }

                }
            }

            Console.WriteLine("To je správně!");


        }
    }
}
