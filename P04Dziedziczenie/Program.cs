using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ala ma kota";
            object o = s; // rzutowanie niejawne (zawsze z obiektu bardziej szczegolowego moge rzutowac na obiekt bardziej ogolny)
            // w druga strone (wypakowywanie) juz zawesze musi byc rzutowanie jawne 

            string s2 = (string)o;

            object o2 = new Czlowiek();// rzutowanie niejawne  zmienna o2 wskazuje na czlowieka ale traktuje go jako object 

            Programista p = new Programista();
            p.Imie = "Jan";
            p.Nazwisko = "Kowalski";
            p.LiczbaMonitorow = 44;

            Czlowiek c = new Czlowiek();


            Czlowiek c3 = p; // teraz trakuje tego konkretnego programiste jako czlowieka 

             int a= ((Programista)c3).LiczbaMonitorow; 



        }
    }
}
