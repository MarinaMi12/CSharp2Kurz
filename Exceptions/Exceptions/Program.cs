﻿namespace Exceptions
{

              //Upravte tridu Clovek tak, aby konstruktor vyhodil vyjimku, pokud jmeno neni platne (null nebo prazdny string)
              //nebo pokud tel cislo neni validni (zkontrolujte pocet cislic). Tip: Delku cisla zjistite zavolanim telCislo.ToString().Length.
              //Do metody Main doplnte blok try-catch, ktery uzivatele upozorni, pokud udela chybu
              //Muzete pouzit obecnou tridu Exception, nebo lepe specifickou ArgumentException

        public class Program
        {
            public static void Main()
            {
            try
            {
                Console.WriteLine("Program na vytvareni telefonniho seznamu");
                Console.WriteLine("========================================");
                Console.Write("Zadejte jmeno: ");
                string jmeno = Console.ReadLine();
                Console.Write("Zadejte telefonni cislo: ");
                string cislo = Console.ReadLine();
                Clovek prvniClovek = new Clovek(jmeno, int.Parse(cislo));
                prvniClovek.VypisJmenoACislo();
                Console.ReadLine();
            }
             catch (ArgumentException vyjimka)
            {
                Console.WriteLine($"Chyba pri zadani: {vyjimka}");
            }
            }
        }
    }
    

