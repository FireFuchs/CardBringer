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
using CardBringer2.Database;

namespace CardBringer2
{
    public partial class MojProfil : Form
    {
        private readonly string _reloadSql;

        public MojProfil()
        {
            InitializeComponent();
            this.ControlBox = false;
            
            if (KorisnikDB.PrijavljeniKorisnik == null) return;
            MojProfilLabelID.Text = KorisnikDB.PrijavljeniKorisnik.idKorisnika.ToString();
            MojProfilLabelNickname.Text = KorisnikDB.PrijavljeniKorisnik.ime;
            MojProfilLabelEmail.Text = KorisnikDB.PrijavljeniKorisnik.email;
            MojProfilLabelAdresa.Text = KorisnikDB.PrijavljeniKorisnik.mjestoStanovanja;
            MojProfilLabelTipKorisnika.Text = KorisnikDB.PrijavljeniKorisnik.idUloga.ToString();
            
            dataGridView1.DataSource = OglasDB.DohvatiOglase();
        }

        private void buttonUkloniOglas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                OglasDB odabraniOglas= row.DataBoundItem as OglasDB;
                odabraniOglas.Obrisi();
            }
        }
    }
}
