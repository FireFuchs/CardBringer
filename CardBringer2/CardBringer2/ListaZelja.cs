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
        private readonly string _reloadSql;

        public ListaZelja(int id)
        {
            InitializeComponent();
            _idKorisnika = id;
            _reloadSql = $"SELECT kart.idKarta, kart.imeKarte, kart.opisKarte, kart.slikaKarte, w.kolicina FROM karta kart JOIN wishlist w ON w.idKarta = kart.idKarta JOIN korisnik k ON k.idKorisnika = w.idKorisnik WHERE idKorisnik = '{_idKorisnika}';";
            this.ControlBox = false;
        }

        private void ListaZelja_Load(object sender, EventArgs e)
        {
            ListaZeljaLoadGridGlavni();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kartaId = (int)SveKarteDatagrid.SelectedRows[0].Cells[0].Value;
            var db = new DbInteraction();
            db.Connection.Open();
            var sql = $"SELECT COUNT(idKarta) FROM wishlist WHERE idKorisnik = '{_idKorisnika}' AND idKarta = '{kartaId}';";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            var broj = 0;
            while (dataReader.Read())
            {
                broj = dataReader.GetInt32(0);
            }
            dataReader.Close();
            command.Dispose();
            if (broj == 1)
            {
                var kolKarti = 0;
                sql = $"SELECT kolicina FROM wishlist WHERE idKorisnik = '{_idKorisnika}' AND idKarta = '{kartaId}';";
                command = new SqlCommand(sql, db.Connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    kolKarti = dataReader.GetInt32(0);
                }
                kolKarti += 1;
                dataReader.Close();
                command.Dispose();
                sql = $"UPDATE wishlist SET kolicina = '{kolKarti}' WHERE idKorisnik = '{_idKorisnika}' AND idKarta = '{kartaId}';";
                var dataAdapter = new SqlDataAdapter();
                dataAdapter.UpdateCommand = new SqlCommand(sql, db.Connection);
                dataAdapter.UpdateCommand.ExecuteNonQuery();
                db.Connection.Close();
                FormControls.LoadDatagridView(ListaZeljaDataGrid, _reloadSql);
            }
            else
            {
                var dataAdapter = new SqlDataAdapter();
                sql = $"INSERT INTO wishlist (idKorisnik, idKarta, napomena, kolicina) VALUES('{_idKorisnika}','{kartaId}','{1}','{1}'); ";
                dataAdapter.UpdateCommand = new SqlCommand(sql, db.Connection);
                dataAdapter.UpdateCommand.ExecuteNonQuery();
                db.Connection.Close();

                ListaZeljaDataGrid.DataSource = null;
                FormControls.LoadDatagridView(ListaZeljaDataGrid, _reloadSql);
            }
        }

        private void ListaZeljaGumbMakni_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();
            var idKarte = (int)ListaZeljaDataGrid.SelectedRows[0].Cells[0].Value;
            var sql = $"DELETE FROM wishlist WHERE idKorisnik = '{_idKorisnika}' AND idKarta = '{idKarte}';";
            var command = new SqlCommand(sql, db.Connection);
            command.ExecuteNonQuery();
            command.Dispose();
            db.Connection.Close();
            FormControls.LoadDatagridView(ListaZeljaDataGrid, _reloadSql);
        }
        
        private void GumbResetListaZelja_Click(object sender, EventArgs e)
        {
            ListaZeljaLoadGridGlavni();
        }

        private void ListaZeljaButtonTrazi_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void ListaZeljaTrazi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Filter();
            }
        }

        private void Filter()
        {
            var kartaIme = ListaZeljaTrazi.Text;
            var sql = $"SELECT imeKarte, opisKarte FROM karta WHERE imeKarte LIKE '%{kartaIme}%';";
            FormControls.LoadDatagridView(SveKarteDatagrid, sql);
            FormControls.LoadDatagridView(ListaZeljaDataGrid, _reloadSql);
        }

        private void ListaZeljaLoadGridGlavni()
        {
            var sql = $"SELECT imeKarte, opisKarte FROM karta;";
            FormControls.LoadDatagridView(SveKarteDatagrid, sql);
            FormControls.LoadDatagridView(ListaZeljaDataGrid, _reloadSql);
        }
    }
}
