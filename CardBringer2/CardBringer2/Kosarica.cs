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
        readonly int _idKorisnik;
        public Kosarica(int id)
        {
            InitializeComponent();
            _idKorisnik = id;
            this.ControlBox = false;
        }

        private void Kosarica_Load(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var sql = $"SELECT  kart.slikaKarte, kart.imeKarte, kart.opisKarte, k.ime, kk.cijena, mk.kolicina, mk.datum FROM karta kart join korisnikKarta kk on kart.idKarta = kk.idKarta join medjuspremnikKosarica mk on mk.idKorisnikKarta = kk.idKorisnikKarta join korisnik k on k.idKorisnika = kk.idKorisnik WHERE mk.idKosarica = {_idKorisnik};";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            int sumaNovaca = 0;
            int kolicinaKarata = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sumaNovaca += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                kolicinaKarata += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            ukupnaCijenaLabela.Text = sumaNovaca.ToString();
            KolicinaKarataLabela.Text = kolicinaKarata.ToString();
            command.Dispose();
            db.Connection.Close();
        }
    }
}
