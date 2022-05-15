using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek c = new Czlowiek() {  Imie = "Jan", Nazwisko = "Kowalski" };
             
            string napis = c.ToString();

            Czlowiek c2 = new Czlowiek() { Imie = "Adam", Nazwisko = "Kowalski" };


           bool czyTakisam= c.Equals(c2);
            Console.WriteLine(czyTakisam);

            Console.WriteLine(napis);

            Console.ReadKey();
        }


    }
}
