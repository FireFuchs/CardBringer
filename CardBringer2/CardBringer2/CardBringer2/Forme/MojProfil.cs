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

        public MojProfil()
        {
            InitializeComponent();
            this.ControlBox = false;

            if (korisnik.PrijavljeniKorisnik == null) return;
            MojProfilLabelID.Text = korisnik.PrijavljeniKorisnik.idKorisnika.ToString();
            MojProfilLabelNickname.Text = korisnik.PrijavljeniKorisnik.ime;
            MojProfilLabelEmail.Text = korisnik.PrijavljeniKorisnik.email;
            MojProfilLabelAdresa.Text = korisnik.PrijavljeniKorisnik.mjestoStanovanja;
            MojProfilLabelTipKorisnika.Text = uloga.DohvatiNazivUloge(korisnik.PrijavljeniKorisnik.idUloga);

            dataGridView1.DataSource = oglas.DohvatiSvojeOglase();
            dataGridView1.DataSource = oglas.DohvatiSveAktivneOglase();
            obradiDGV();
        }

        private void buttonUkloniOglas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            var idOglas = (int) dataGridView1.SelectedRows[0].Cells["idOglas"].Value;
            oglas.DeaktivirajOglas(idOglas);

            dataGridView1.DataSource = oglas.DohvatiSvojeOglase();
            pictureBoxSlikaKarte.Image = null;
            imeKarte.Text = "Naziv karte";
            opisKarte.Text = null;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            imeKarte.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            opisKarte.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(dataGridView1.SelectedRows[0].Cells["slikaKarte"].Value.ToString());
            pictureBoxSlikaKarte.Image = Image.FromStream(slikaKarte);
            pictureBoxSlikaKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void obradiDGV()
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            dataGridView1.Columns["imeKarte"].HeaderText = "Ime karte";
            dataGridView1.Columns["opisKarte"].HeaderText = "Opis karte";
            dataGridView1.Columns["cijena"].HeaderText = "Cijena";
            dataGridView1.Columns["kolicina"].HeaderText = "Količina";
            dataGridView1.Columns["ime"].HeaderText = "Prodavač";
            dataGridView1.Columns["idOglas"].Visible = false;
            dataGridView1.Columns["slikaKarte"].Visible = false;
            dataGridView1.Columns["aktivan"].Visible = false;

        }
    }
}
