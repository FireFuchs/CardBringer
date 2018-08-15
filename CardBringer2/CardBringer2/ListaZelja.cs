using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardBringer2
{
    public partial class ListaZelja : Form
    {
        int idKorisnika;
        public ListaZelja(int id)
        {
            InitializeComponent();
            idKorisnika = id;
            this.ControlBox = false;
        }

        private void ListaZelja_Load(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var sql = $"SELECT idKarta, imeKarte, opisKarte, slikaKarte FROM karta;";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            SveKarteDatagrid.AutoGenerateColumns = true;
            SveKarteDatagrid.DataSource = dt;
            SveKarteDatagrid.Refresh();


            command.Dispose();
            db.Connection.Close();
        }

        private void SveKarteDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
