using System.Collections.Generic;
using System.Data.Common;

namespace CardBringer2.Database
{
    public class KartaDB
    {
        public int idKarta;
        public string imeKarte;
        public string opisKarte;
        public string slikaKarte;

        public KartaDB()
        {
        }

        public KartaDB(DbDataReader dr)
        {
            if (dr == null) return;
            idKarta = (int)dr["idKarta"];
            imeKarte = dr["imeKarte"].ToString();
            opisKarte = dr["opisKarte"].ToString();
            slikaKarte = dr["slikaKarte"].ToString();
            dr.Close();
        }

        public int Spremi()
        {
            string sqlUpit = $"INSERT INTO karta(imeKarte, opisKarte, slikaKarte) " +
                             $"VALUES('{imeKarte}','{opisKarte}','{slikaKarte}')";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<KartaDB> DohvatiKarte()
        {
            List<KartaDB> lista = new List<KartaDB>();
            string sqlUpit = "SELECT * FROM karta";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                KartaDB karta = new KartaDB(dr);
                lista.Add(karta);
            }
            dr.Close();
            return lista;
        }
    }
}