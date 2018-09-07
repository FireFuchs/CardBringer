using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardBringer2.Database
{
    class OglasDB
    {
        public int idOglas;
        public int idKorisnik;
        public int idKarta;
        public string cijena;
        public int kolicina;

        public OglasDB()
        {
        }

        public OglasDB(DbDataReader dr)
        {
            if (dr == null) return;
            idOglas = (int)dr["idOglas"];
            idKorisnik = (int)dr["idKorisnik"];
            idKarta = (int)dr["idKarta"];
            cijena = dr["cijena"].ToString();
            kolicina = (int)dr["kolicina"];
            dr.Close();
        }

        public int Spremi()
        {
            string sqlUpit = $"INSERT INTO oglas(idKorisnik, idKarta, cijena, kolicina) " +
                             $"VALUES('{idKorisnik}', '{idKarta}', '{cijena}', '{kolicina}'); ";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public int Update()
        {
            string sqlUpit = $"INSERT INTO oglas(idKorisnik, idKarta, cijena, kolicina) " +
                             $"VALUES('{idKorisnik}', '{idKarta}', '{cijena}', '{kolicina}') " +
                             $"WHERE idOglas = '{idOglas}';";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<OglasDB> DohvatiOglase()
        {
            List<OglasDB> lista = new List<OglasDB>();
            string sqlUpit = "SELECT * FROM oglas";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                OglasDB oglas = new OglasDB(dr);
                lista.Add(oglas);
            }
            dr.Close();
            return lista;
        }

        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM oglas WHERE idOglas = " + idOglas;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }
    }
}
