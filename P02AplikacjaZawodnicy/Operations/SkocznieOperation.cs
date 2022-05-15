
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
    internal class SkocznieOperation
    {
        public SkoczniaVM[] PodajSkocznieZBazy()
        {
            SkocznieRepostiory zr = new SkocznieRepostiory();
            var skocznie = zr.WczytajSkocznie();

            return skocznie.Select(x => new SkoczniaVM()
            {
                Id = x.Id,
                Nazwa = x.Nazwa,
                Kraj = x.Kraj,

            }).ToArray();
        }

         

    }
}
