using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Help;

namespace CardBringer2
{
    public partial class ObjaviOglas : Form
    {

        public ObjaviOglas()
        {
            InitializeComponent();
            HelpClass.TrenutnaForma = 8;
            ControlBox = false;
        }

        private void ObjaviOglas_Load(object sender, EventArgs e)
        {
            kartaBindingSource.DataSource = karta.DohvatiKarte();
            DohvatiSadrzaj();
        }

        private void DohvatiSadrzaj()
        {
            // Dohvaća sve podatke potrebne za ovu formu
            if (dgvObjaviOglasSveKarte.SelectedRows.Count <= 0) return;
            lblObjaviOglasNazivKarte.Text = dgvObjaviOglasSveKarte.SelectedRows[0].Cells[1].Value.ToString();
            rtboxObjaviOglasOpisKarte.Text = dgvObjaviOglasSveKarte.SelectedRows[0].Cells[2].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(dgvObjaviOglasSveKarte.SelectedRows[0].Cells[3].Value.ToString());
            pboxObjaviOglasSlikaKarte.Image = Image.FromStream(slikaKarte);
            pboxObjaviOglasSlikaKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tboxObjaviOglasCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Omogućava samo upis brojki i točke
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tboxObjaviOglasKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Omogućava samo upis brojki
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnObjaviOglasObjaviOglas_Click(object sender, EventArgs e)
        {
            objaviOglas();
        }

        private void objaviOglas()
        {
            // Verificiranje da podatci koji su uneseni u textboxeve su prihvatljivi
            if (tboxObjaviOglasCijena.Text == "" || tboxObjaviOglasKolicina.Text == "")
            {
                MessageBox.Show("Cijena ili količina su krivo uneseni", "Greška", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToDecimal(tboxObjaviOglasCijena.Text) <= 0 || Convert.ToInt32(tboxObjaviOglasKolicina.Text) <= 0)
            {
                MessageBox.Show("Cijena ili količina su krivo uneseni", "Greška", MessageBoxButtons.OK);
                return;
            }
            var idKarta = (int)dgvObjaviOglasSveKarte.SelectedRows[0].Cells[0].Value;
            var cijena = Convert.ToDecimal(tboxObjaviOglasCijena.Text);
            var kolicina = Convert.ToInt32(tboxObjaviOglasKolicina.Text);

            oglas o = new oglas();
            o.idKorisnik = korisnik.PrijavljeniKorisnik.idKorisnika;
            o.idKarta = idKarta;
            o.cijena = cijena;
            o.kolicina = kolicina;
            o.aktivan = 1;
            o.Spremi();
            MessageBox.Show("Vaš oglas je uspješno objavljen", "Oglas objavljen", MessageBoxButtons.OK);
        }

        private void tboxObjaviOglasCijena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objaviOglas();
            }
        }

        private void tboxObjaviOglasKolicina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objaviOglas();
            }
        }

        private void dgvObjaviOglasSveKarte_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DohvatiSadrzaj();
        }
    }
}
