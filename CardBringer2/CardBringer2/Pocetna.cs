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
    public partial class Pocetna : Form
    { int idKorisnika;
        public Pocetna(int id)
        {
            InitializeComponent();
            idKorisnika = id;
            this.ControlBox = false;
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var dataAdapter = new SqlDataAdapter();

            // HARDCODIRANO DA JE SAMO KUPAC (idUloga)
            var sql = $"SELECT kar.imeKarte AS 'Ime Karte' , kar.opisKarte AS 'Opis Karte', kk.cijena AS 'Cijena', kk.kolicina AS 'Kolicina', k.ime AS 'Ime Prodavača' FROM korisnikKarta kk JOIN karta kar ON kar.idKarta = kk.idKarta JOIN korisnik k ON kk.idKorisnik = k.idKorisnika;";
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
