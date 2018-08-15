using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardBringer2
{
    class DbInteraction
    {
        private const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=C:\Users\bro\Documents\r18030\CardBringer2\CardBringer2\BazaYgo.mdf;
              Integrated Security=True;Connect Timeout=30";

        public SqlConnection connection = new SqlConnection(connString);

        //public void OpenConnection()
        //{
        //    connection.Open();
        //}

        //public void CloseConnection()
        //{
        //    connection.Close();
        //}

        //public void Select(string query)
        //{
            
        //}
    }

    
}
