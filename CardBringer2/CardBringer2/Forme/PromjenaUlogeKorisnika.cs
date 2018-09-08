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
    public partial class PromjenaUlogeKorisnika : Form
    {
        
        public PromjenaUlogeKorisnika()
        {
            InitializeComponent();
            HelpClass.TrenutnaForma = 10;
            this.KeyPreview = true;
        }

        private void PromjenaUlogeKorisnika_Load(object sender, EventArgs e)
        {
            dgvPromjenaUlogeKorisnikaSviKorisnici.DataSource = korisnik.DohvatiKorisnike();
            obradiDGV();
        }
        private void obradiDGV()
        {
            if (dgvPromjenaUlogeKorisnikaSviKorisnici.SelectedRows.Count <= 0) return;
            dgvPromjenaUlogeKorisnikaSviKorisnici.Columns["idUloga"].Visible = false;
            dgvPromjenaUlogeKorisnikaSviKorisnici.Columns["idKorisnika"].HeaderText = "ID Korisnika";
            dgvPromjenaUlogeKorisnikaSviKorisnici.Columns["ime"].HeaderText = "Korisničko ime";
            dgvPromjenaUlogeKorisnikaSviKorisnici.Columns["email"].HeaderText = "E-Mail";
            dgvPromjenaUlogeKorisnikaSviKorisnici.Columns["mjestoStanovanja"].HeaderText = "Adresa";
            dgvPromjenaUlogeKorisnikaSviKorisnici.Columns["nazivUloge"].HeaderText = "Uloga";
        }

        private void btnPromjenaUlogeKorisnikaHelp_Click(object sender, EventArgs e)
        {
            help();
        }

        private void PromjenaUlogeKorisnika_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                help();
            }
        }

        private void help()
        {
            var help = new HelpForm();
            help.Show();
        }

        private void btnPromjenaUlogeKorisnikaDajPrivilegije_Click(object sender, EventArgs e)
        {
            var idUloga = (int)dgvPromjenaUlogeKorisnikaSviKorisnici.SelectedRows[0].Cells["idUloga"].Value;
            if (idUloga == 2)
            {
                MessageBox.Show("Korisnik već ima administratorske privilegije!", "Greška", MessageBoxButtons.OK);
                return;
            }
            var idKorisnik = (int)dgvPromjenaUlogeKorisnikaSviKorisnici.SelectedRows[0].Cells["idKorisnika"].Value;
            korisnik.PromijeniUloguKorisnika(idKorisnik, 2);
            dgvPromjenaUlogeKorisnikaSviKorisnici.DataSource = korisnik.DohvatiKorisnike();

        }

        private void btnPromjenaUlogeKorisnikaOduzmiPrivilegije_Click(object sender, EventArgs e)
        {
            var idUloga = (int)dgvPromjenaUlogeKorisnikaSviKorisnici.SelectedRows[0].Cells[5].Value;
            if (idUloga == 1)
            {

                MessageBox.Show("Ne možete maknuti privilegije jer ih korisnik nema!", "Greška", MessageBoxButtons.OK);
                return;
            }

            var idKorisnik = (int)dgvPromjenaUlogeKorisnikaSviKorisnici.SelectedRows[0].Cells["idKorisnika"].Value;
            korisnik.PromijeniUloguKorisnika(idKorisnik, 1);
            dgvPromjenaUlogeKorisnikaSviKorisnici.DataSource = korisnik.DohvatiKorisnike();
        }
    }
}
