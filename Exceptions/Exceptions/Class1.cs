using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Clovek
    {
        public string Jmeno;
        public int TelCislo;
        public Clovek(string jmeno, int telCislo)
        {

            if (string.IsNullOrEmpty(jmeno))
            {
                throw new Exception("Jmeno nemuze byt prazdne nebo null");
            }

            if (telCislo.ToString().Length !=9)

            {
                throw new Exception("Cislo neni platne");
            }
            Jmeno = jmeno;
            TelCislo = telCislo;
        }
        public string VypisJmenoACislo()
        {
            return $"{Jmeno}: {TelCislo}";
        }
    }
}
