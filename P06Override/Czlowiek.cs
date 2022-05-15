using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Override
{
    internal class Czlowiek
    {
        public string Imie;
        public string Nazwisko;

        public override string ToString()
        {
            return Imie + " " + Nazwisko;
        }
        public override bool Equals(object obj)
        {
            if (obj is Czlowiek)
                return ((Czlowiek)obj).Nazwisko == Nazwisko;

            return base.Equals(obj);    
        }
    }
}
