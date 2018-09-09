using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardBringer2
{
    public partial class ObjaviOglas : Form
    {
        private readonly int _idKorisnika;
        private readonly string _reloadSql = $"SELECT idKarta, imeKarte, opisKarte FROM karta;";
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

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            
            var idKarta = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var sql = $"SELECT imeKarte, opisKarte, slikaKarte from karta WHERE idKarta = '{idKarta}';";

            var db = new DbInteraction();
            db.Connection.Open();
            
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                ImeKarte.Text = dataReader[0].ToString();
                OpisKarte.Text = dataReader[1].ToString();
                var slikaKarte = FormControls.DohvatiSlikuKarte(dataReader[2].ToString());
                pictureBoxSlikaKarte.Image = Image.FromStream(slikaKarte);
                pictureBoxSlikaKarte.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            command.Dispose();
            dataReader.Close();
            db.Connection.Close();
        }
    }
}
