using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05DziedziczenieZadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plik[] pliki = new Plik[3]
            {
                new PlikSQL(){ Nazwa="p1", Sciezka=@"c:\dane\mojePliki\p1", Zawartosc="ala ma kota"},
                new PlikHTML(){ Nazwa="p2", Sciezka=@"c:\dane\mojePliki\p2", Zawartosc="ala ma kota"},
                new PlikCSV(){ Nazwa="p3", Sciezka=@"c:\dane\mojePliki\p3", Zawartosc="ala ma kota"},
            };
            foreach (var p in pliki)
                p.Zapisz();

            PlikCSV plikCSV = new PlikCSV();
            plikCSV.Zapisz();

            Plik plikcsv2 = new PlikCSV();
            plikcsv2.Zapisz();

            //foreach (var p in pliki)
            //{
            //    if (p is PlikSQL)
            //        ((PlikSQL)p).Zapisz();

            //    if (p is PlikHTML)
            //        ((PlikHTML)p).Zapisz();

            //    if (p is PlikCSV)
            //        ((PlikCSV)p).Zapisz();
            //}


           // Plik p = new Plik();






        }
    }
}
