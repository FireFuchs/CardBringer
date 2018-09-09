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
    public partial class Kosarica : Form
    {
        private const int _nekupljeno = 0;
        public Kosarica()
        {
            InitializeComponent();
            HelpClass.TrenutnaForma = 2;
            this.ControlBox = false;
        }

        private void Kosarica_Load(object sender, EventArgs e)
        {
            // Dohvaća samo nekupljene stavke koje su u košarici 
            dgvKosaricaStavkeKosarice.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);
            ObradiDgv();
        }

        private void ObradiDgv()
        {

            // Računanje i ispis ukupnog iznosa karata i koliko karata je u košarici u tom trenutku
            double cijena;
            int kolicina;
            double rezultat = 0;
            int ukupnaKolicina = 0; 
            foreach (DataGridViewRow stavka in dgvKosaricaStavkeKosarice.Rows)
            {
                cijena = Convert.ToDouble(stavka.Cells["cijena"].Value);
                kolicina = (int)stavka.Cells["kolicina"].Value;
                rezultat = rezultat + (cijena * kolicina);
                ukupnaKolicina += kolicina;
            }
            dgvKosaricaStavkeKosarice.Columns["cijena"].DefaultCellStyle.Format = "0.00";
            lblKosaricaCijenaKarataCijena.Text = String.Format("{0:0.00}", rezultat);
            lblKosaricaBrojKarataBroj.Text = ukupnaKolicina.ToString();

            // Sakrivanje nepotrebnih podataka iz datagrida dgvKosarica
            if (dgvKosaricaStavkeKosarice.SelectedRows.Count <= 0) return;
            dgvKosaricaStavkeKosarice.Columns["imeKarte"].HeaderText = "Ime karte";
            dgvKosaricaStavkeKosarice.Columns["opisKarte"].HeaderText = "Opis karte";
            dgvKosaricaStavkeKosarice.Columns["cijena"].HeaderText = "Cijena";
            dgvKosaricaStavkeKosarice.Columns["kolicina"].HeaderText = "Količina";
            dgvKosaricaStavkeKosarice.Columns["ime"].HeaderText = "Prodavač";
            dgvKosaricaStavkeKosarice.Columns["idOglas"].Visible = false;
            dgvKosaricaStavkeKosarice.Columns["slikaKarte"].Visible = false;
            dgvKosaricaStavkeKosarice.Columns["kupljeno"].Visible = false;
            dgvKosaricaStavkeKosarice.Columns["idKosarica"].Visible = false;
            

        }


        private void btnKosaricaKupi_Click(object sender, EventArgs e)
        {
            
            if (dgvKosaricaStavkeKosarice.RowCount == 0)
            {
                MessageBox.Show("Vaša košarica je prazna.", "Greška", MessageBoxButtons.OK);
                return;
            }

            int idKosarica;
            int idOglas;
            int kolicina;
            var popup = new UnosKartice();
            popup.ShowDialog();

            foreach (DataGridViewRow stavka in dgvKosaricaStavkeKosarice.Rows)
            {
                idKosarica = (int)stavka.Cells["idKosarica"].Value;
                idOglas = (int)stavka.Cells["idOglas"].Value;
                kolicina = (int)stavka.Cells["kolicina"].Value;
                // Stavka košarice se označava kao kupljena
                kosharica.StavkaKupljenaIliNe(idKosarica, 1);
                // Ukoliko u oglasu više nema količine, tj nema preostalih karata, deaktivira se
                if (kolicina == 0) oglas.DeaktivirajOglas(idOglas);
                
            }

            dgvKosaricaStavkeKosarice.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);
        }


        private void btnKosaricaMakni_Click(object sender, EventArgs e)
        {
            if (dgvKosaricaStavkeKosarice.RowCount == 0)
            {
                MessageBox.Show("Vaša košarica je prazna.", "Greška", MessageBoxButtons.OK);
                return;
            }
            // Miče odabranu stavku iz košarice i vraća ih u oglas iz kojeg su uzete
            int idKosarica = (int)dgvKosaricaStavkeKosarice.SelectedRows[0].Cells["idKosarica"].Value;
            int idOglas = (int)dgvKosaricaStavkeKosarice.SelectedRows[0].Cells["idOglas"].Value;
            int kolicina = (int)dgvKosaricaStavkeKosarice.SelectedRows[0].Cells["kolicina"].Value;
            oglas.UpdateKolicinuUOglasu(idOglas, kolicina, true);
            kosharica.UkloniStavkuKosarice(idKosarica);
            dgvKosaricaStavkeKosarice.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);
        }
    }
}
