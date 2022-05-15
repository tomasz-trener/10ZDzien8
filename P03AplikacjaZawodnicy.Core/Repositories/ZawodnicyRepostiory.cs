using P03AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy.Core.Core.Repositories
{
    public class ZawodnicyRepository
    {

        public Zawodnik[] WczytajZawodnikow(string filtr = null, string sortowanie = null)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            IQueryable<Zawodnik> zapytanie;

            if (string.IsNullOrWhiteSpace(filtr))
                zapytanie = db.Zawodnik.AsQueryable();
            else
                zapytanie = db.Zawodnik.Where(x => x.Imie.Contains(filtr)
                                || x.Nazwisko.Contains(filtr)
                                || x.Kraj.Contains(filtr));

            if (sortowanie != null)
            {
                if (sortowanie == "Imie")
                    zapytanie = zapytanie.OrderBy(x => x.Imie);
                if (sortowanie == "Nazwisko")
                    zapytanie = zapytanie.OrderBy(x => x.Nazwisko);
                if (sortowanie == "Kraj")
                    zapytanie = zapytanie.OrderBy(x => x.Kraj);
            }

            return zapytanie.ToArray(); // dopiero teraz idzie zapytanie do bazy danych 


            // metody: ToArray(), ToList() oraz First lub FirstOrDefault() 
            // sa metodami specjalnymi bo wysylaja zapytanie do bazy danych 
            // typ IQueryable jest takim typem , ktory przechowuje to zapytanie lokalnie 








        }

        /// <summary>
        /// To metoda do tworzenia zaowdnika
        /// </summary>
        /// <param name="z">Nowy Zawodnik do dodania do bazy danych </param>
        public void DodajZawodnika(Zawodnik z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            z.IdTrenera = z.IdTrenera == 0 ? null : z.IdTrenera;
            db.Zawodnik.InsertOnSubmit(z);
            db.SubmitChanges();
        }

        public void Edytuj(Zawodnik z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnik doEdycji = db.Zawodnik.FirstOrDefault(x => x.Id == z.Id);
            doEdycji.Imie = z.Imie;
            doEdycji.Nazwisko = z.Nazwisko;
            doEdycji.Kraj = z.Kraj;
            doEdycji.DataUr = z.DataUr;
            doEdycji.Wzrost = z.Wzrost;
            doEdycji.Waga = z.Waga;
            doEdycji.IdTrenera = z.IdTrenera == 0 ? null : z.IdTrenera;
            db.SubmitChanges();

        }

        //params - mogę podać jednego lub wielu po przecinku, lub po prostu całą kolekcję 
        public void Usun(params Zawodnik[] zawodnicy)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            int[] szukaneIdiki = zawodnicy.Select(y => y.Id).ToArray();
            Zawodnik[] doUsuniecia = db.Zawodnik.Where(x => szukaneIdiki.Contains(x.Id)).ToArray();
            db.Zawodnik.DeleteAllOnSubmit(doUsuniecia);
            db.SubmitChanges();
        }
    }
}
