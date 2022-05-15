using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Dziedziczenie
{
    internal class Czlowiek
    {
        public string Imie;
        public string Nazwisko;
        public string PrzedstawSie()
        {
            return Imie + " " + Nazwisko;
        }
    }
}
