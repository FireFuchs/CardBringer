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
    public partial class ObjaviOglas : Form
    {
        int idKorisnika;
        public ObjaviOglas(int id)
        {
            InitializeComponent();
            ControlBox = false;
            idKorisnika = id;
        }

        private void ObjaviOglas_Load(object sender, EventArgs e)
        {
            LoadDatagridView();
        }
        
        private void buttonObjaviOglas_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var dataAdapter = new SqlDataAdapter();
            var idKarta = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var cijena = unosCijeneKarteObjaviOglas.Text;
            var kolicina = Convert.ToDecimal(unosKolicineKarteObjaviOglas.Text);
            var sql = $"INSERT INTO korisnikKarta (idKorisnik, idKarta, cijena, kolicina) VALUES('{idKorisnika}', '{idKarta}', '{cijena}', '{kolicina}');";
            var command = new SqlCommand(sql, db.Connection);
            dataAdapter.InsertCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            db.Connection.Close();
            LoadDatagridView();
        }

        private void LoadDatagridView()
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var sql = $"SELECT idKarta, imeKarte, opisKarte, slikaKarte FROM karta;";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dataReader);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();


            command.Dispose();
            db.Connection.Close();
        }
    }
}
