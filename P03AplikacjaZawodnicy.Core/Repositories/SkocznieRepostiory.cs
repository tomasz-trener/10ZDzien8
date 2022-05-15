using P03AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy.Core.Core.Repositories
{
    public class SkocznieRepostiory
    {

        public Skocznia[] WczytajSkocznie()
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            return db.Skocznia.ToArray();
        }

        
    }
}
