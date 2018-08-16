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
        private const string ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bro\Documents\r18030\CardBringer2\CardBringer2\BazaYgo.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection Connection = new SqlConnection(ConnString);
    }
}
