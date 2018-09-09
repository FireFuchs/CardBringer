using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardBringer2
{
    public partial class GlavniIzbornikForma : Form
    {
        public GlavniIzbornikForma()
        {
            InitializeComponent();
        }

        private void GlavniIzbornikForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var help = new HelpForm();
                help.Show();
            }
            
        }

        private void unosGumbHelpGlavniIzbornikForma_Click(object sender, EventArgs e)
        {
            var help = new HelpForm();
            help.Show();
        }

        private void početnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var novaPocetna = new Pocetna();
            novaPocetna.MdiParent = this;
            novaPocetna.WindowState = FormWindowState.Maximized;
            novaPocetna.Show();
        }

        private void GlavniIzbornikForma_Load(object sender, EventArgs e)
        {
            var novaPocetna = new Pocetna();
            novaPocetna.MdiParent = this;
            novaPocetna.WindowState = FormWindowState.Maximized;
            novaPocetna.Show();
            if (korisnik.PrijavljeniKorisnik == null)
            {
                ProvjeraUloge(0);
                return;
            }
            ProvjeraUloge(korisnik.PrijavljeniKorisnik.idUloga);

        }

        private void ProvjeraUloge(int idPrijavljenog)
        {
            if (idPrijavljenog < 1)
            {
                btnGlavniIzbornikFormaKosarica.Visible = false;
                btnGlavniIzbornikFormaMojProfil.Visible = false;
                btnGlavniIzbornikFormaObjaviOglase.Visible = false;
                btnGlavniIzbornikFormaListaZelja.Visible = false;
                btnGlavniIzbornikFormaMojeKupnje.Visible = false;
                btnGlavniIzbornikFormaPocetna.Margin = new System.Windows.Forms.Padding(0, 0, 440, 0);
            }
            if (idPrijavljenog < 2)
            {
                btnGlavniIzbornikFormaAdministrator.Visible = false;
                btnGlavniIzbornikFormaOdjava.Margin = new System.Windows.Forms.Padding(350, 0, 0, 0);
            }
        }

        private void btnGlavniIzbornikFormaPocetna_Click(object sender, EventArgs e)
        {
            var novaPocetna = new Pocetna();
            novaPocetna.MdiParent = this;
            novaPocetna.WindowState = FormWindowState.Maximized;
            novaPocetna.Show();
        }

        private void btnGlavniIzbornikFormaMojProfil_Click(object sender, EventArgs e)
        {
            var noviMojProfil = new MojProfil();
            noviMojProfil.MdiParent = this;
            noviMojProfil.WindowState = FormWindowState.Maximized;
            noviMojProfil.Show();
        }

        private void btnGlavniIzbornikFormaObjaviOglase_Click(object sender, EventArgs e)
        {
            var noviOglas = new ObjaviOglas();
            noviOglas.MdiParent = this;
            noviOglas.WindowState = FormWindowState.Maximized;
            noviOglas.Show();
        }

        private void btnGlavniIzbornikFormaKosarica_Click(object sender, EventArgs e)
        {
            var novaKosarica = new Kosarica();
            novaKosarica.MdiParent = this;
            novaKosarica.WindowState = FormWindowState.Maximized;
            novaKosarica.Show();
        }

        private void btnGlavniIzbornikFormaListaZelja_Click(object sender, EventArgs e)
        {
            var novaListaZelja = new ListaZelja();
            novaListaZelja.MdiParent = this;
            novaListaZelja.WindowState = FormWindowState.Maximized;
            novaListaZelja.Show();
        }

        private void btnGlavniIzbornikFormaMojeKupnje_Click(object sender, EventArgs e)
        {
            var mojeKupnje = new MojeKupnje();
            mojeKupnje.MdiParent = this;
            mojeKupnje.WindowState = FormWindowState.Maximized;
            mojeKupnje.Show();
        }

        private void btnGlavniIzbornikFormaAdministrator_Click(object sender, EventArgs e)
        {
            var administracija = new Administracija();
            administracija.MdiParent = this;
            administracija.WindowState = FormWindowState.Maximized;
            administracija.Show();
        }
    }
}
