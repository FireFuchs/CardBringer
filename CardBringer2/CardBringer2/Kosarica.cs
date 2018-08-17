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
    public partial class Kosarica : Form
    {
        private readonly int _idKorisnik;
        public Kosarica(int id)
        {
            InitializeComponent();
            _idKorisnik = id;
            this.ControlBox = false;
        }

        private void Kosarica_Load(object sender, EventArgs e)
        {
            Refresaj();
        }

        private void GumbKupi_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();
            var popup = new UnosKartice();
            popup.ShowDialog();
            var sql = $"INSERT INTO obavljenaKupnja ( idKorisnik, kolicinaKarata, ukupnaCijena, datum) VALUES('{_idKorisnik}','{Convert.ToInt32(KolicinaKarataLabela.Text.ToString())}', '{Convert.ToInt32(ukupnaCijenaLabela.Text.ToString())}', '{DateTime.Today.ToString("yyyy-MM-dd")}');";
            var command = new SqlCommand(sql, db.Connection);
            var dataAdapter = new SqlDataAdapter();
            dataAdapter.InsertCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            sql = $"DELETE FROM medjuspremnikKosarica WHERE idKorisnika = '{_idKorisnik}';";
            command = new SqlCommand(sql, db.Connection);
            command.ExecuteNonQuery();
            command.Dispose();
            db.Connection.Close();
            Refresaj();
        }

        private void Refresaj()
        {
            var sql = $"SELECT  kart.slikaKarte, kart.imeKarte, kart.opisKarte, k.ime, kk.cijena, mk.kolicina, mk.datum FROM karta kart join korisnikKarta kk on kart.idKarta = kk.idKarta join medjuspremnikKosarica mk on mk.idKorisnikKarta = kk.idKorisnikKarta join korisnik k on k.idKorisnika = kk.idKorisnik WHERE mk.idKorisnika = {_idKorisnik};";
            FormControls.LoadDatagridView(dataGridView1, sql);
            var sumaNovaca = 0;
            var kolicinaKarata = 0;
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sumaNovaca += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                kolicinaKarata += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            ukupnaCijenaLabela.Text = sumaNovaca.ToString();
            KolicinaKarataLabela.Text = kolicinaKarata.ToString();
        }
    }
}
