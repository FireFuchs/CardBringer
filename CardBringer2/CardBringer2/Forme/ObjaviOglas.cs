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

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DohvatiSadrzaj();
        }
        private void DohvatiSadrzaj()
        {
            if (dgvObjaviOglasSveKarte.SelectedRows.Count <= 0) return;
            lblObjaviOglasNazivKarte.Text = dgvObjaviOglasSveKarte.SelectedRows[0].Cells[1].Value.ToString();
            rtboxObjaviOglasOpisKarte.Text = dgvObjaviOglasSveKarte.SelectedRows[0].Cells[2].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(dgvObjaviOglasSveKarte.SelectedRows[0].Cells[3].Value.ToString());
            pboxObjaviOglasSlikaKarte.Image = Image.FromStream(slikaKarte);
            pboxObjaviOglasSlikaKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tboxObjaviOglasCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tboxObjaviOglasKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnObjaviOglasObjaviOglas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tboxObjaviOglasCijena.Text) ||
                string.IsNullOrWhiteSpace(tboxObjaviOglasKolicina.Text))
            {
                MessageBox.Show("Niste unijeli podatke o oglasu!", "Greška", MessageBoxButtons.OK);
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
    }
}
