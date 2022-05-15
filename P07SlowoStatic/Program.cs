using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07SlowoStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek.Nazwisko = "Kowalski";

            Czlowiek c1 = new Czlowiek();
            c1.Imie = "Jan";
           // c1.Nazwisko = "Kowalski";

            Czlowiek c2 = new Czlowiek();
            c1.Imie = "Adam";
            // c2.Nazwisko = "Kowalski";

            c1.PrzedstawSie();

            Czlowiek.MetodaStatyczna();
        }
    }
}
