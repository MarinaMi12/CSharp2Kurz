namespace Lucistnik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lucistnik Lucistnik = new Lucistnik();

            int pocetSipu = 10;

            while (pocetSipu>=0)
            {
                Lucistnik.Vystrel(pocetSipu);
                pocetSipu = pocetSipu - 1;
            }


                    
        }
    }
}
