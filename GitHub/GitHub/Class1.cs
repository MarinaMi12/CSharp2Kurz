using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    internal class Dovolena
    {

        public DateTime datumOdjezdu;

        public Dovolena(int denOdjezdu, int mesicOdjezdu, int rokOdjezdu) 
        {
            datumOdjezdu = new DateTime(rokOdjezdu, mesicOdjezdu, denOdjezdu);
        }

        public int VypocitejDni()
        {
            TimeSpan pocetDnu = datumOdjezdu - DateTime.Today;
            return pocetDnu.Days;
        }
    }
}
