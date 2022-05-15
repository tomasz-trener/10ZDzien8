using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07SlowoStatic
{
    internal class Czlowiek
    {
        public string Imie;
        public static string Nazwisko;

        public void PrzedstawSie()
        {
            Console.WriteLine(Imie  + " " + Nazwisko);
        }


        public static void MetodaStatyczna()
        {
            Console.WriteLine("Dzien dobry nazywam sie "+ Nazwisko);
        }
    }
}
