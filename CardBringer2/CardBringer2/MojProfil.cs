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
        int idKorisnika;
        public MojProfil(int id)
        {
            InitializeComponent();
            idKorisnika = id;
            var db = new DbInteraction();
            db.Connection.Open();

            var sql = $"SELECT k.ime, k.email, k.mjestoStanovanja, u.nazivUloge FROM korisnik k JOIN uloga u ON k.idUloga = u.idUloga WHERE k.idKorisnika = '{idKorisnika}';";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                var username = dataReader.GetString(0);
                var email = dataReader.GetString(1);
                var mjestoStanovanja = dataReader.GetString(2);
                var tipKorisnika = dataReader.GetString(3);

                MojProfilLabelID.Text = idKorisnika.ToString();
                MojProfilLabelNickname.Text = username;
                MojProfilLabelEmail.Text = email;
                MojProfilLabelAdresa.Text = mjestoStanovanja;
                MojProfilLabelTipKorisnika.Text = tipKorisnika;
                dataReader.Close();
                command.Dispose();
            }
            db.Connection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
