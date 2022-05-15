using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05DziedziczenieZadanie
{
    internal abstract class Plik
    {
        public string Nazwa;
        public string Sciezka;
        public string Autor;
        public string Zawartosc;
        public string Rozszerzenie;

        public virtual void Zapisz()
        {
            File.WriteAllText(Sciezka + Rozszerzenie, Zawartosc);
        }
    }
}
