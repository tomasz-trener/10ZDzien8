using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05DziedziczenieZadanie
{
    internal class PlikSQL : Plik
    {
       // string rozszerzenie2;
        public override void Zapisz()
        {
            Rozszerzenie = ".sql";
            base.Zapisz();
           // File.WriteAllText(Sciezka + Rozszerzenie, Zawartosc);
        }
    }
}
