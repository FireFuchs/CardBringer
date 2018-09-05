using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardBringer2.Database
{
    class KosaricaDB
    {
        public int idKosarica;
        public int idKorisnika;
        public int idOglas;
        public int kolicina;
        public string datum = DateTime.Today.ToString("yyyy-MM-dd");
        public int kupljeno = 0;

        public KosaricaDB()
        {
        }

        public KosaricaDB(DbDataReader dr)
        {
            if (dr == null) return;
            idKosarica = (int) dr["idKosarica"];
            idKorisnika = (int) dr["idKorisnika"];
            idOglas = (int) dr["idOglas"];
            kolicina = (int) dr["kolicina"];
            datum = dr["datum"].ToString();
            kupljeno = (int) dr["kupljeno"];
        }

        public int Spremi()
        {
            string sqlUpit = $"INSERT INTO kosarica (idKorisnika, idOglas, kolicina, datum, kupljeno) " +
                             $"VALUES('{idKorisnika}', '{idOglas}', '{kolicina}', '{datum}', '{kupljeno}');";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public int Update()
        {
            string sqlUpit = $"INSERT INTO kosarica (idKorisnika, idOglas, kolicina, datum, kupljeno) " +
                             $"VALUES('{idKorisnika}', '{idOglas}', '{kolicina}', '{datum}', '{kupljeno}') " +
                             $"WHERE idKosarica = '{idKosarica}';";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<KosaricaDB> DohvatiKosarice()
        {
            List<KosaricaDB> lista = new List<KosaricaDB>();
            string sqlUpit = "SELECT * FROM korisnik";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                KosaricaDB kosarica = new KosaricaDB(dr);
                lista.Add(kosarica);
            }
            dr.Close();
            return lista;
        }
    }
}
