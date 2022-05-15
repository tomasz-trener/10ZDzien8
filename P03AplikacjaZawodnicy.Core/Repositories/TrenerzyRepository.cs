﻿
using P03AplikacjaZawodnicy.Core.Core.Domain;
using P03AplikacjaZawodnicy.Core.Core.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy.Core.Core.Repositories
{
    public class TrenerzyRepository
    {

        public Trener[] WczytajTrenerow()
        {

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] wynik = pzb.WyslijPolecenieSQL("select id_trenera, imie_t, nazwisko_t, data_ur_t from trenerzy");

            Trener[] trenerzy = new Trener[wynik.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                Trener ityTrener = new Trener();
                ityTrener.Id = (int)wynik[i][0];

                ityTrener.Imie = (string)wynik[i][1];
                ityTrener.Nazwisko = (string)wynik[i][2];

                if (wynik[i][3] != DBNull.Value)
                    ityTrener.DataUr = (DateTime)wynik[i][3];

                trenerzy[i] = ityTrener;
            }

            return trenerzy;
        }

        public Trener PodajTrenera(int id)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] wynik = pzb.WyslijPolecenieSQL($"select id_trenera, imie_t, nazwisko_t, data_ur_t from trenerzy where id_trenera = {id}");

            Trener trener = new Trener();
            trener.Id = (int)wynik[0][0];

            trener.Imie = (string)wynik[0][1];
            trener.Nazwisko = (string)wynik[0][2];

            if (wynik[0][3] != DBNull.Value)
                trener.DataUr = (DateTime)wynik[0][3];

            return trener;
        }

        public int DodajTrenera(Trener t)
        {
            string szablon = @"insert into trenerzy 
                         (imie_t, nazwisko_t, data_ur_t)
                         OUTPUT Inserted.id_trenera
                         values
                         ('{0}', '{1}', {2})";

            string sql = string.Format(szablon, t.Imie, t.Nazwisko, t.DataUr == null ? "null" : $"'{t.DataUr.Value.ToString("yyyyMMdd")}'");

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] wynik=  pzb.WyslijPolecenieSQL(sql);
            return (int)wynik[0][0];
        }

        public void Edytuj(Trener t)
        {
            // wersja podtana na atak typu SQL ijnection
            //string szablon = @"update trenerzy set imie_t='{0}',nazwisko_t='{1}',data_ur_t={2} where id_trenera = {3}";

            //string sql = string.Format(szablon, t.Imie, t.Nazwisko, t.DataUr == null ? "null" : $"'{t.DataUr.Value.ToString("yyyyMMdd")}'", t.Id);

            //PolaczenieZBaza pzb = new PolaczenieZBaza();
            //pzb.WyslijPolecenieSQL(sql);


            string sql = "update trenerzy set imie_t=@imie,nazwisko_t=@nazwisko,data_ur_t=@dataUr where id_trenera = @idTrenera";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter() { ParameterName = "@imie", Value = t.Imie},
                new SqlParameter() { ParameterName = "@nazwisko", Value = t.Nazwisko},
                new SqlParameter() { ParameterName = "@dataUr", Value = t.DataUr == null ? "null" : $"{t.DataUr.Value.ToString("yyyyMMdd")}"},
                new SqlParameter() { ParameterName = "@idTrenera", Value = t.Id},
            };
            //string sql = string.Format(szablon, t.Imie, t.Nazwisko, t.DataUr == null ? "null" : $"'{t.DataUr.Value.ToString("yyyyMMdd")}'", t.Id);

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WyslijPolecenieSQL(sql, sqlParameters);
        }

        //params - mogę podać jednego lub wielu po przecinku, lub po prostu całą kolekcję 
        public void Usun(params Trener[] trenerzy)
        {
            string sql = string.Format("delete trenerzy where id_trenera in ({0})",
                string.Join(" ,", trenerzy.Select(x => x.Id)));

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WyslijPolecenieSQL(sql);
        }
    }
}
