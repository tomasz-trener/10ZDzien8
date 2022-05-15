
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
    internal class MiastaOperation
    {
        public MiastoVM[] PodajMiastaZBazy()
        {
            MiastaRepostiory zr = new MiastaRepostiory();
            var miasta = zr.WczytajMiasta();

            return miasta.Select(x => new MiastoVM()
            {
                Id = x.Id,
                Nazwa = x.Nazwa,
            }).ToArray();
        }

         

    }
}
