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
    {
        
        public Pocetna()
        {
            InitializeComponent();
            HelpClass.TrenutnaForma = 9;
            this.ControlBox = false;
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            dgvPocetnaDatagridSviOglasi.DataSource = oglas.DohvatiSveAktivneOglase();
            ObradiDgv();
        }
        
        private void dodajUKosaricu()
        {

            if (dgvPocetnaDatagridSviOglasi.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nije odabran niti jedan oglas!", "Greška", MessageBoxButtons.OK);
                return;
            };
            string imeProdavaca;
            int brojKarataNaProdaju;
            int brojKarataZaKosaricu;
            int idOglas;
            int novaKolicina;

            imeProdavaca = dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["ime"].Value.ToString();
            if (imeProdavaca == korisnik.PrijavljeniKorisnik.ime)
            {
                MessageBox.Show("Ne možete kupiti vlastiti oglas!", "Greška", MessageBoxButtons.OK);
                return;
            }

            brojKarataNaProdaju = (int)dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["kolicina"].Value;
            brojKarataZaKosaricu = int.Parse(tboxPocetnaBrojKarataZaKosaricu.Text);
            if (brojKarataZaKosaricu > brojKarataNaProdaju)
            {
                MessageBox.Show("Ne možete uzeti više karata nego što se prodaje!", "Greška", MessageBoxButtons.OK);
                return;
            }

            idOglas = (int)dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["idOglas"].Value;
            novaKolicina = brojKarataNaProdaju - brojKarataZaKosaricu;
            oglas.UpdateKolicinuUOglasu(idOglas, novaKolicina, false);

            kosharica k = new kosharica();
            k.idOglas = idOglas;
            k.kolicina = brojKarataZaKosaricu;
            k.Spremi();

            dgvPocetnaDatagridSviOglasi.DataSource = oglas.DohvatiSveAktivneOglase();
            tboxPocetnaBrojKarataZaKosaricu.Text = 1.ToString();

        } 

        private void Trazi()
        {
            var pretrazivaniString = tboxPocetnaPretragabox.Text;
            dgvPocetnaDatagridSviOglasi.DataSource = oglas.TraziOglase(pretrazivaniString);
        }

        private void ObradiDgv()
        {
            if (dgvPocetnaDatagridSviOglasi.SelectedRows.Count <= 0) return;
            dgvPocetnaDatagridSviOglasi.Columns["imeKarte"].HeaderText = "Ime karte";
            dgvPocetnaDatagridSviOglasi.Columns["opisKarte"].HeaderText = "Opis karte";
            dgvPocetnaDatagridSviOglasi.Columns["cijena"].HeaderText = "Cijena";
            dgvPocetnaDatagridSviOglasi.Columns["kolicina"].HeaderText = "Količina";
            dgvPocetnaDatagridSviOglasi.Columns["ime"].HeaderText = "Prodavač";
            dgvPocetnaDatagridSviOglasi.Columns["idOglas"].Visible = false;
            dgvPocetnaDatagridSviOglasi.Columns["slikaKarte"].Visible = false;
            dgvPocetnaDatagridSviOglasi.Columns["aktivan"].Visible = false;
        }

        private void PocetnaBrojKarataZaKosaricu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void PocetnaBrojKarataZaKosaricu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                dodajUKosaricu();
            }
        }

        private void tboxPocetnaPretragabox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Trazi();
            }
        }

        private void btnPocetnaTrazigumb_Click(object sender, EventArgs e)
        {
            Trazi();
        }

        private void btnPocetnaResetgumb_Click(object sender, EventArgs e)
        {
            dgvPocetnaDatagridSviOglasi.DataSource = oglas.DohvatiSveAktivneOglase();
            ObradiDgv();
        }

        private void dgvPocetnaDatagridSviOglasi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPocetnaDatagridSviOglasi.SelectedRows.Count <= 0) return;
            lblPocetnaIspisImeKarte.Text = dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["imeKarte"].Value.ToString();
            lblPocetnaIspisCijenaKarte.Text = dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["cijena"].Value.ToString();
            lblPocetnaIspisKolicina.Text = dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["kolicina"].Value.ToString();
            lblPocetnaIspisProdavac.Text = dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["ime"].Value.ToString();
            rtboxPocetnaOpisKarte.Text = dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["opisKarte"].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["slikaKarte"].Value.ToString());
            pboxPocetnaSlikaKarte.Image = Image.FromStream(slikaKarte);
            pboxPocetnaSlikaKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnPocetanGumbDodajUKosaricu_Click(object sender, EventArgs e)
        {
            dodajUKosaricu();
        }
    }
}
