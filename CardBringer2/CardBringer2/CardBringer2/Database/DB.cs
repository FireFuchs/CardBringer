using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardBringer2.Database
{
    class DB
    {
        private static DB instance; //Singleton objekt
        private string connectionString; //Putanja i ostali podaci za spajanje na bazu
        private SqlConnection connection; //Konekcija prema bazi

        public static DB Instance //Singleton instanca klase za rad za bazom.
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();

                }
                return instance;
            }
        }

        public string ConnectionString //Putanja i ostali podaci za spajanje na bazu
        {
            get { return connectionString; }
            private set { connectionString = value; }
        }

        public SqlConnection Connection //Konekcija prema bazi
        {
            get { return connection; }
            private set { connection = value; }
        }

        private DB() //Konstruktor klase
        {
            ConnectionString = @"Server=tcp:cardbringerdb.database.windows.net,1433;Initial Catalog=CardBringerDB;Persist Security Info=False;User ID=cardbringer;Password=YuGiOh!1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        ~DB() //Destruktor klase
        {
            Connection.Close(); Connection = null;
        }

        public DbDataReader DohvatiDataReader(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
