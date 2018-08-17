using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardBringer2
{
    internal class FormControls
    {
        public static void LoadDatagridView(DataGridView dataGridView, string sql)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dataReader);
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = dt;
            dataGridView.Refresh();


            command.Dispose();
            db.Connection.Close();
        }
    }
}
