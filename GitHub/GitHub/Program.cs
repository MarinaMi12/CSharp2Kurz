using System.Data.Common;

namespace GitHub
{
    internal class PocitaniDovolene
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Zadejte den odjezdu: ");
            int denOdjezdu = int.Parse(Console.ReadLine());

            Console.Write("Zadejte mesic odjezdu: ");
            int mesicOdjezdu = int.Parse(Console.ReadLine());

            Console.Write("Zadejte rok odjezdu: ");
            int rokOdjezdu = int.Parse(Console.ReadLine());

            Dovolena Dovolena = new Dovolena(denOdjezdu, mesicOdjezdu, rokOdjezdu);


            int pocetDnu = Dovolena.VypocitejDni();

            Console.WriteLine($"Hura, do dovolene zbylo {pocetDnu} dni");
        }
    }
}
