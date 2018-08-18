using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CardBringer2
{
    internal class DbInteraction
    {
        private const string ConnString = @"Server=tcp:cardbringerdb.database.windows.net,1433;Initial Catalog=CardBringerDB;Persist Security Info=False;User ID=cardbringer;Password=YuGiOh!1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public SqlConnection Connection = new SqlConnection(ConnString);
    }
}
