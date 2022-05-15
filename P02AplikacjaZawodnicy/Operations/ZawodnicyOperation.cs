
using P02AplikacjaZawodnicy.ViewModels;
using P03AplikacjaZawodnicy.Core.Core.Repositories;
using P03AplikacjaZawodnicy.Core.Core.Tools;
using P03AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02AplikacjaZawodnicy.Operations
{
    /// <summary>
    /// Klasa obsługjaca podstawowe operacje na zawodnikach 
    /// </summary>
    internal class ZawodnicyOperation
    {

        private Zawodnik MapujNaZawodnikDB(ZawodnikVM z)
        {
            return new Zawodnik()
            {
                Id = z.Id,
                Imie = z.Imie,
                Nazwisko = z.Nazwisko,
                Kraj = z.Kraj,
                DataUr = z.DataUr,
                IdTrenera = z.IdTrenera,
                Wzrost = z.Wzrost,
                Waga = z.Waga,
            };
        }
        public ZawodnikVM[] PodajZawodnikowZBazy(string filtr =null, string sortowanie=null, int? strona = null)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            var zawodnicy = zr.WczytajZawodnikow(filtr, sortowanie, strona);

            // rolą operacji jest (miedzy innymi)  zeby przetransformowac obiekt bazodanowy na obiekt ViewModel, który bedzie wyswietlany na widoku 

            //moze być tak, że niektore pola w bazie bedą trochę inne niz pola na interfejsie graficznym np: taka sytuacja jest w przypadku daty 
            // gdzie w bazie danych data moze byc pusta (null) ale nasz interfejs graficzny nie pozwala technicze na ustawienie pustej daty 
            return zawodnicy.Select(x => new ZawodnikVM()
            {
                Id = x.Id,
                Imie = x.Imie,
                Nazwisko = x.Nazwisko,
                Kraj = x.Kraj,
                DataUr = x.DataUr,
                //DataUr = x.DataUr == null ? DateTime.Now : (DateTime)x.DataUr, to zabezpiecznie bylo potrzebny wtedy gdy nasz widok nie przyjmowal wartosci pustych (bo technicznie nie dalo stego zrobic) ale po zrobieniu walnego datetime pickera , ktory przyjmuje wartosci null mozmey je usunac 
                Wzrost = x.Wzrost,
                ImieNazwiskoTrenera = x.Trener?.Imie + " " + x.Trener?.Nazwisko,
                Waga = x.Waga == null ? 0 : (int)x.Waga
            }).ToArray();
        }

        public void DodajZawodnikowDoBazy(ZawodnikVM z)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            var zDB = MapujNaZawodnikDB(z);
            zr.DodajZawodnika(zDB);
        }

        public void Edytuj(ZawodnikVM z)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            var zDB = MapujNaZawodnikDB(z);
            zr.Edytuj(zDB);
        }


        public void Usun(params ZawodnikVM[] zawodnicy)
        {

            ZawodnicyRepository zr = new ZawodnicyRepository();
            var zawDB = zawodnicy.Select(x => MapujNaZawodnikDB(x)).ToArray();
            zr.Usun(zawDB);
        }

        public void StworzRaportPDF(ZawodnikVM[] zawodnicy, string sciezka)
        {
            PDFManager pdfManager = new PDFManager();

            var zaw = zawodnicy.Select(x => new P03AplikacjaZawodnicy.Core.Core.Domain.Zawodnik() { Imie = x.Imie, Nazwisko = x.Nazwisko, Kraj=x.Kraj }).ToArray();

            
            pdfManager.WygenerujRaport(zaw, sciezka);
        }


    }
}
