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
        private readonly int _idKorisnika;
        private readonly string _reloadSql = $"SELECT idKarta, imeKarte, opisKarte, slikaKarte FROM karta;";
        public ObjaviOglas(int id)
        {
            InitializeComponent();
            ControlBox = false;
            _idKorisnika = id;
        }

        private void ObjaviOglas_Load(object sender, EventArgs e)
        {
            FormControls.LoadDatagridView(dataGridView1, _reloadSql);
        }
        
        private void buttonObjaviOglas_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var dataAdapter = new SqlDataAdapter();
            var idKarta = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var cijena = unosCijeneKarteObjaviOglas.Text;
            var kolicina = Convert.ToDecimal(unosKolicineKarteObjaviOglas.Text);
            var sql = $"INSERT INTO korisnikKarta (idKorisnik, idKarta, cijena, kolicina) VALUES('{_idKorisnika}', '{idKarta}', '{cijena}', '{kolicina}');";
            var command = new SqlCommand(sql, db.Connection);
            dataAdapter.InsertCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            db.Connection.Close();

            FormControls.LoadDatagridView(dataGridView1, _reloadSql);
        }
        
    }
}
