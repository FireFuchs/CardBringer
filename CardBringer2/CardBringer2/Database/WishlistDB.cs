using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardBringer2.Database
{
    class WishlistDB
    {
        public int idWishlist;
        public int idKorisnik;
        public int idKarta;
        public int kolicina;

        public WishlistDB()
        {
        }

        public WishlistDB(DbDataReader dr)
        {
            if (dr == null) return;
            idWishlist = (int)dr["idWishlist"];
            idKorisnik = (int)dr["idKorisnik"];
            idKarta = (int)dr["idKarta"];
            kolicina = (int)dr["kolicina"];
        }

        public int Spremi()
        {
            string sqlUpit = $"INSERT INTO wishlist (idKorisnik, idKarta, kolicina) " +
                             $"VALUES('{idKorisnik}','{idKarta}','{kolicina}'); ";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public int Update()
        {
            string sqlUpit = $"INSERT INTO wishlist (idKorisnik, idKarta, kolicina) " +
                             $"VALUES('{idKorisnik}','{idKarta}','{kolicina}') " +
                             $"WHERE idWishlist = '{idWishlist}';";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<WishlistDB> DohvatiWishliste()
        {
            List<WishlistDB> lista = new List<WishlistDB>();
            string sqlUpit = "SELECT * FROM korisnik";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                WishlistDB wishlist = new WishlistDB(dr);
                lista.Add(wishlist);
            }
            dr.Close();
            return lista;
        }
    }
}
