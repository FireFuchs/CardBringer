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

        }

        private void PromjenaUlogeKorisnika_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = korisnik.DohvatiKorisnike();
            obradiDGV();
        }

        private void buttonDodajAdmina_Click(object sender, EventArgs e)
        {
            var idUloga = (int)dataGridView1.SelectedRows[0].Cells["idUloga"].Value;
            if (idUloga == 2)
            {
                MessageBox.Show("Korisnik već ima administratorske privilegije!", "Greška", MessageBoxButtons.OK);
                return;
            }
            var idKorisnik = (int)dataGridView1.SelectedRows[0].Cells["idKorisnika"].Value;
            korisnik.PromijeniUloguKorisnika(idKorisnik, 2);
            dataGridView1.DataSource = korisnik.DohvatiKorisnike();

        }

        private void buttonMakniAdmina_Click(object sender, EventArgs e)
        {
            var idUloga = (int)dataGridView1.SelectedRows[0].Cells[5].Value;
            if (idUloga == 1)
            {

                MessageBox.Show("Ne možete maknuti privilegije jer ih korisnik nema!", "Greška", MessageBoxButtons.OK);
                return;
            }

            var idKorisnik = (int)dataGridView1.SelectedRows[0].Cells["idKorisnika"].Value;
            korisnik.PromijeniUloguKorisnika(idKorisnik, 1);
            dataGridView1.DataSource = korisnik.DohvatiKorisnike();
        }
        private void obradiDGV()
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            dataGridView1.Columns["idUloga"].Visible = false;
            dataGridView1.Columns["idKorisnika"].HeaderText = "ID Korisnika";
            dataGridView1.Columns["ime"].HeaderText = "Korisničko ime";
            dataGridView1.Columns["email"].HeaderText = "E-Mail";
            dataGridView1.Columns["mjestoStanovanja"].HeaderText = "Adresa";
            dataGridView1.Columns["nazivUloge"].HeaderText = "Uloga";
        }
    }
}
