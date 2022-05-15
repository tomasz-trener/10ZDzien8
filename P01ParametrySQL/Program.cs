using P03AplikacjaZawodnicy.Core.Core.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ParametrySQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            PolaczenieZBaza polaczenieZBaza = new PolaczenieZBaza();

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@parametrKraj";
            parameter.Value = "pol ' or kraj ='ger' --";

            var wynik=  polaczenieZBaza.WyslijPolecenieSQL("select * from zawodnicy where kraj = @parametrKraj", parameter);

            foreach (var e in wynik)
            {
                Console.WriteLine(e[2] + " " + e[3]);
            }

     
            Console.ReadKey();
        }
    }
}
