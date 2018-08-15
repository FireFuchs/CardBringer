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
        int idKorisnik;
        public Kosarica(int id)
        {
            InitializeComponent();
            idKorisnik = id;
            this.ControlBox = false;
        }

        private void Kosarica_Load(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var sql = $"SELECT  kart.slikaKarte, kart.imeKarte, kart.opisKarte, k.ime, mk.kolicina, mk.datum FROM karta kart join korisnikKarta kk on kart.idKarta = kk.idKarta join medjuspremnikKosarica mk on mk.idKorisnikKarta = kk.idKorisnikKarta join korisnik k on k.idKorisnika = kk.idKorisnik WHERE mk.idKosarica = " + idKorisnik + ";";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();


            command.Dispose();
            db.Connection.Close();
        }
    }
}
