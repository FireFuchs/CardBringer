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
            this.ControlBox = false;
            
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oglas.DohvatiSveAktivneOglase();
        }
        
        private void PocetanGumbDodajUKosaricu_Click(object sender, EventArgs e)
        {
            string imeProdavaca;
            int brojKarataNaProdaju;
            int brojKarataZaKosaricu;
            int idOglas;
            int novaKolicina;

            imeProdavaca = dataGridView1.SelectedRows[0].Cells["ime"].Value.ToString();
            if (imeProdavaca == korisnik.PrijavljeniKorisnik.ime)
            {
                MessageBox.Show("Ne možete kupiti vlastiti oglas!", "Greška", MessageBoxButtons.OK);
                return;
            }

            brojKarataNaProdaju = (int) dataGridView1.SelectedRows[0].Cells["kolicina"].Value;
            brojKarataZaKosaricu = int.Parse(PocetnaBrojKarataZaKosaricu.Text);
            if (brojKarataZaKosaricu > brojKarataNaProdaju)
            {
                MessageBox.Show("Ne možete uzeti više karata nego što se prodaje!", "Greška", MessageBoxButtons.OK);
                return;
            }

            idOglas = (int)dataGridView1.SelectedRows[0].Cells["idOglas"].Value;
            novaKolicina = brojKarataNaProdaju - brojKarataZaKosaricu;
            oglas.UpdateKolicinuUOglasu(idOglas, novaKolicina);

            kosharica k = new kosharica();
            k.idOglas = idOglas;
            k.kolicina = brojKarataZaKosaricu;
            k.Spremi();


            dataGridView1.DataSource = oglas.DohvatiSveAktivneOglase();
        }

        private void PocetnaResetGumb_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oglas.DohvatiSveAktivneOglase();
        }
        

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            imeKarte.Text = dataGridView1.SelectedRows[0].Cells["imeKarte"].Value.ToString();
            cijenaKarte.Text = dataGridView1.SelectedRows[0].Cells["cijena"].Value.ToString();
            kolicinaKarata.Text = dataGridView1.SelectedRows[0].Cells["kolicina"].Value.ToString();
            prodavacKarte.Text = dataGridView1.SelectedRows[0].Cells["ime"].Value.ToString();
            opisKarte.Text = dataGridView1.SelectedRows[0].Cells["opisKarte"].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(dataGridView1.SelectedRows[0].Cells["slikaKarte"].Value.ToString());
            pictureBoxSlikaKarte.Image = Image.FromStream(slikaKarte);
            pictureBoxSlikaKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PocetnaPretragaGumbTrazi_Click(object sender, EventArgs e)
        {
            Trazi();
        }

        private void PocetnaPretragaText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Trazi();
            }
        }

        private void Trazi()
        {
            var pretrazivaniString = PocetnaPretragaText.Text;
            dataGridView1.DataSource = oglas.TraziOglase(pretrazivaniString);
        }
    }
}
