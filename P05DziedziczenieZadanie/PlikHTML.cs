using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05DziedziczenieZadanie
{
    internal class PlikHTML : Plik
    {
        public override void Zapisz()
        {
            Rozszerzenie = ".html";
            base.Zapisz();
            // File.WriteAllText(Sciezka + Rozszerzenie, Zawartosc);
        }
    }
}
