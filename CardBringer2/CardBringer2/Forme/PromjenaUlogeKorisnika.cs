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
        
        private const MessageBoxButtons Button = MessageBoxButtons.OK;
        public PromjenaUlogeKorisnika()
        {
            InitializeComponent();
            
        }

        private void PromjenaUlogeKorisnika_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = korisnik.DohvatiKorisnike();
        }

        private void buttonDodajAdmina_Click(object sender, EventArgs e)
        {
            var idUloga = (int)dataGridView1.SelectedRows[0].Cells["idUloga"].Value;
            if (idUloga == 2)
            {
                MessageBox.Show("Korisnik već ima administratorske privilegije!", "Greška", Button);
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

                MessageBox.Show("Ne možete maknuti privilegije jer ih korisnik nema!", "Greška", Button);
                return;
            }

            var idKorisnik = (int)dataGridView1.SelectedRows[0].Cells["idKorisnika"].Value;
            korisnik.PromijeniUloguKorisnika(idKorisnik, 1);
            dataGridView1.DataSource = korisnik.DohvatiKorisnike();
        }
    }
}
