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
using Help;

namespace CardBringer2
{
    public partial class ListaZelja : Form
    {

    
        public ListaZelja()
        {
            InitializeComponent();
            HelpClass.TrenutnaForma = 3;
            this.ControlBox = false;

        }

        private void ListaZelja_Load(object sender, EventArgs e)
        {
            kartaBindingSource.DataSource = karta.DohvatiKarte();
            dgvListaZeljaKarteNaListi.DataSource = wishlist.DohvatiWishlist();
            DohvatiSadrzaj();
            ObradiDgv();
        }

        private void GumbResetListaZelja_Click(object sender, EventArgs e)
        {
            dgvListaZeljaSveKarteDGV.DataSource = karta.DohvatiKarte();
            tboxListaZeljaTraziSveKarteTbox.Text = "";
        }

        private void Trazi()
        {
            var pretrazivaniString = tboxListaZeljaTraziSveKarteTbox.Text;
            dgvListaZeljaSveKarteDGV.DataSource = karta.TraziKarte(pretrazivaniString);
        }
        private void ObradiDgv()
        {
            // Sakriva nepotrebne podatke iz Datagridviewa
            if (dgvListaZeljaKarteNaListi.SelectedRows.Count <= 0) return;
            dgvListaZeljaKarteNaListi.Columns["idWishlist"].Visible = false;
            dgvListaZeljaKarteNaListi.Columns["slikaKarte"].Visible = false;
            dgvListaZeljaKarteNaListi.Columns["idKorisnik"].Visible = false;
            dgvListaZeljaKarteNaListi.Columns["imeKarte"].HeaderText = "Ime karte";
            dgvListaZeljaKarteNaListi.Columns["opisKarte"].HeaderText = "Opis karte";
        }
        private void DohvatiSadrzaj()
        {
            // Dohvaćanje Potrebnih podataka iz baze podataka
            if (dgvListaZeljaKarteNaListi.SelectedRows.Count <= 0) return;
            lblListaZeljaImeKarte.Text = dgvListaZeljaKarteNaListi.SelectedRows[0].Cells[1].Value.ToString();
            rtboxListaZeljaOpisKarte.Text = dgvListaZeljaKarteNaListi.SelectedRows[0].Cells[2].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(dgvListaZeljaKarteNaListi.SelectedRows[0].Cells[3].Value.ToString());
            pboxListaZeljaSlikaKarte.Image = Image.FromStream(slikaKarte);
            pboxListaZeljaSlikaKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnListaZeljaDodajGumb_Click(object sender, EventArgs e)
        {
            var idKarta = (int)dgvListaZeljaSveKarteDGV.SelectedRows[0].Cells[0].Value;
            wishlist w = new wishlist();
            w.idKarta = idKarta;
            w.idKorisnik = (int)korisnik.PrijavljeniKorisnik.idKorisnika;
            if (!w.Spremi())
            {
                MessageBox.Show("Karta se već nalazi u listi želja!", "Greška", MessageBoxButtons.OK);
                return;
            }
            dgvListaZeljaKarteNaListi.DataSource = wishlist.DohvatiWishlist();
            DohvatiSadrzaj();
            ObradiDgv();
        }

        private void ListaZeljaGumbMakni_Click(object sender, EventArgs e)
        {
            var idWishlist = (int)dgvListaZeljaKarteNaListi.SelectedRows[0].Cells["idWishlist"].Value;
            wishlist.UkloniKartuSListeZelja(idWishlist);
            dgvListaZeljaKarteNaListi.DataSource = wishlist.DohvatiWishlist();
            DohvatiSadrzaj();
            ObradiDgv();
        }

        private void dgvListaZeljaKarteNaListi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DohvatiSadrzaj();
        }

        private void tboxListaZeljaTraziSveKarteTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Trazi();
            }
        }

        private void btnListaZeljaTrazigumb_Click(object sender, EventArgs e)
        {
            Trazi();
        }

        private void btnListaZeljaResetGumb_Click(object sender, EventArgs e)
        {
            dgvListaZeljaSveKarteDGV.DataSource = karta.DohvatiKarte();
            tboxListaZeljaTraziSveKarteTbox.Text = "";
        }

        private void dgvListaZeljaSveKarteDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Dohvaćanje novih podataka kod promjene selekcije u Datagridviewu
            if (dgvListaZeljaSveKarteDGV.SelectedRows.Count <= 0) return;
            lblListaZeljaSveKarteIme.Text = dgvListaZeljaSveKarteDGV.SelectedRows[0].Cells[1].Value.ToString();
            rtboxListaZeljaOpisKarteSveKarte.Text = dgvListaZeljaSveKarteDGV.SelectedRows[0].Cells[2].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(dgvListaZeljaSveKarteDGV.SelectedRows[0].Cells[3].Value.ToString());
            pboxListaZeljaSlikaSveKarte.Image = Image.FromStream(slikaKarte);
            pboxListaZeljaSlikaSveKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
