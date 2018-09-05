using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardBringer2.Database
{
    class KorisnikDB
    {
        public int idKorisnika;
        public string ime;
        public string lozinka;
        public string email;
        public string mjestoStanovanja;
        public int idUloga = 1;

        public KorisnikDB()
        {
        }

        public KorisnikDB(DbDataReader dr)
        {
            if (dr == null) return;
            idKorisnika = (int)dr["idKorisnika"];
            ime = dr["ime"].ToString();
            lozinka = dr["lozinka"].ToString();
            email = dr["email"].ToString();
            mjestoStanovanja = dr["mjestoStanovanja"].ToString();
            idUloga = (int)dr["idUloga"];
        }

        public int Spremi()
        {
            string sqlUpit = $"INSERT INTO korisnik (ime, lozinka, email, mjestoStanovanja, idUloga) " +
                             $"VALUES('{ime}', '{lozinka}', '{email}', '{mjestoStanovanja}', 1);";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public int Update()
        {
            string sqlUpit = $"INSERT INTO korisnik (ime, lozinka, email, mjestoStanovanja, idUloga) " +
                             $"VALUES('{ime}', '{lozinka}', '{email}', '{mjestoStanovanja}', 1) " +
                             $"WHERE idKorisnika = '{idKorisnika}';";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<KorisnikDB> DohvatiKorisnike()
        {
            List<KorisnikDB> lista = new List<KorisnikDB>();
            string sqlUpit = "SELECT * FROM korisnik";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                KorisnikDB korisnik = new KorisnikDB(dr);
                lista.Add(korisnik);
            }
            dr.Close();
            return lista;
        }
    }
}
