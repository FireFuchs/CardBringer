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
    public partial class MojProfil : Form
    {
        private static int _idKorisnika;
        private readonly string _reloadSql;
        private readonly string _loggedInSql;

        public MojProfil(int id)
        {
            InitializeComponent();
            this.ControlBox = false;
            _idKorisnika = id;
            _loggedInSql = $"SELECT k.ime, k.email, k.mjestoStanovanja, u.nazivUloge FROM korisnik k JOIN uloga u ON k.idUloga = u.idUloga WHERE k.idKorisnika = '{_idKorisnika}';";
            _reloadSql = $"SELECT kk.idKorisnikKarta AS 'ID Ponude', kar.imeKarte AS 'Ime Karte' , kar.opisKarte AS 'Opis Karte', kk.cijena AS 'Cijena', kk.kolicina AS 'Kolicina', k.ime AS 'Ime Prodavača' FROM korisnikKarta kk JOIN karta kar ON kar.idKarta = kk.idKarta JOIN korisnik k ON kk.idKorisnik = k.idKorisnika WHERE k.idKorisnika = {_idKorisnika};";
            var db = new DbInteraction();
            db.Connection.Open();
            var command = new SqlCommand(_loggedInSql, db.Connection);
            var dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                var username = dataReader.GetString(0);
                var email = dataReader.GetString(1);
                var mjestoStanovanja = dataReader.GetString(2);
                var tipKorisnika = dataReader.GetString(3);

                MojProfilLabelID.Text = _idKorisnika.ToString();
                MojProfilLabelNickname.Text = username;
                MojProfilLabelEmail.Text = email;
                MojProfilLabelAdresa.Text = mjestoStanovanja;
                MojProfilLabelTipKorisnika.Text = tipKorisnika;

            }
            dataReader.Close();
            command.Dispose();

            FormControls.LoadDatagridView(dataGridView1, _reloadSql);

        }
        
        

        private void buttonUkloniOglas_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var dataAdapter = new SqlDataAdapter();
            var idKorisnikKarta = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var sql = $"DELETE korisnikKarta WHERE idKorisnikKarta = '{idKorisnikKarta}';";
            var command = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            db.Connection.Close();
            FormControls.LoadDatagridView(dataGridView1, _reloadSql);
        }

        private void MojProfil_Load(object sender, EventArgs e)
        {
            
        }
    }
}
