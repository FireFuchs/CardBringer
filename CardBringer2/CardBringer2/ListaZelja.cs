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
        
        private readonly int _idKorisnika;
        public ListaZelja(int id)
        {
            InitializeComponent();
            _idKorisnika = id;
            this.ControlBox = false;
        }

        private void ListaZelja_Load(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var sql = $"SELECT idKarta, imeKarte, opisKarte, slikaKarte FROM karta;";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dataReader);
            SveKarteDatagrid.AutoGenerateColumns = true;
            SveKarteDatagrid.DataSource = dt;
            SveKarteDatagrid.Refresh();


            command.Dispose();
            db.Connection.Close();
            UpdateDatagrid();
        }

        private void SveKarteDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kartaId = (int)SveKarteDatagrid.SelectedRows[0].Cells[0].Value;
            var db = new DbInteraction();
            db.Connection.Open();
            var sql = $"SELECT COUNT(idKarta) FROM wishlist WHERE idKorisnik = '{_idKorisnika}' AND idKarta = '{kartaId}';";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            int broj= 0;
            while (dataReader.Read())
            {
                broj = dataReader.GetInt32(0);
            }
            dataReader.Close();
            command.Dispose();
            if (broj == 1)
            {
                int kolKarti = 0;
                sql = $"SELECT kolicina FROM wishlist WHERE idKorisnik = '{_idKorisnika}' AND idKarta = '{kartaId}';";
                command = new SqlCommand(sql, db.Connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    kolKarti = dataReader.GetInt32(0);
                }
                kolKarti = kolKarti + 1;
                dataReader.Close();
                command.Dispose();
                sql = $"UPDATE wishlist SET kolicina = '{kolKarti}' WHERE idKorisnik = '{_idKorisnika}' AND idKarta = '{kartaId}';";
                var dataAdapter = new SqlDataAdapter();
                dataAdapter.UpdateCommand = new SqlCommand(sql, db.Connection);
                dataAdapter.UpdateCommand.ExecuteNonQuery();
                UpdateDatagrid();
                db.Connection.Close();
            }
            else
            {
                var dataAdapter = new SqlDataAdapter();
                sql = $"INSERT INTO wishlist (idKorisnik, idKarta, napomena, kolicina) VALUES('{_idKorisnika}','{kartaId}','{1}','{1}'); ";
                dataAdapter.UpdateCommand = new SqlCommand(sql, db.Connection);
                dataAdapter.UpdateCommand.ExecuteNonQuery();
                db.Connection.Close();
                UpdateDatagrid();

            }
            

        }
        private void UpdateDatagrid()
        {
            ListaZeljaDataGrid.DataSource = null;
            var db = new DbInteraction();
            db.Connection.Open();

            var sql = $"SELECT kart.idKarta, kart.imeKarte, kart.opisKarte, kart.slikaKarte, w.kolicina FROM karta kart JOIN wishlist w ON w.idKarta = kart.idKarta JOIN korisnik k ON k.idKorisnika = w.idKorisnik WHERE idKorisnik = '{_idKorisnika}';";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            ListaZeljaDataGrid.AutoGenerateColumns = true;
            ListaZeljaDataGrid.DataSource = dt;
            ListaZeljaDataGrid.Refresh();


            command.Dispose();
            db.Connection.Close();
        }

        private void ListaZeljaGumbMakni_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();
            int idKarte = (int)ListaZeljaDataGrid.SelectedRows[0].Cells[0].Value;
            var sql = $"DELETE FROM wishlist WHERE idKorisnik = '{_idKorisnika}' AND idKarta = '{idKarte}';";
            var command = new SqlCommand(sql, db.Connection);
            command.ExecuteNonQuery();
            command.Dispose();
            db.Connection.Close();
            UpdateDatagrid();
        }
    }
}
