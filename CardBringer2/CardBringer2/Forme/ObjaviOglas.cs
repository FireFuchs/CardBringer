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
            ControlBox = false;
        }

        private void ObjaviOglas_Load(object sender, EventArgs e)
        {
            kartaBindingSource.DataSource = karta.DohvatiKarte();
            dohvatiSadrzaj();
        }

        private void buttonObjaviOglas_Click(object sender, EventArgs e)
        {
            var idKarta = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var cijena = Convert.ToDecimal(unosCijeneKarteObjaviOglas.Text);
            var kolicina = Convert.ToInt32(unosKolicineKarteObjaviOglas.Text);

            oglas o = new oglas();
            o.idKorisnik = korisnik.PrijavljeniKorisnik.idKorisnika;
            o.idKarta = idKarta;
            o.cijena = cijena;
            o.kolicina = kolicina;
            o.aktivan = 1;
            o.Spremi();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dohvatiSadrzaj();
        }

        private void unosCijeneKarteObjaviOglas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void unosKolicineKarteObjaviOglas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dohvatiSadrzaj()
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            ImeKarte.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            OpisKarte.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            pictureBoxSlikaKarte.Image = Image.FromStream(slikaKarte);
            pictureBoxSlikaKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
