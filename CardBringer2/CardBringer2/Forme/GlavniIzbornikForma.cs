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
        string _helpTekst = "Help glavne forme";
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void početnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var novaPocetna = new Pocetna();
            novaPocetna.MdiParent = this;
            novaPocetna.WindowState = FormWindowState.Maximized;
            novaPocetna.Show();
            _helpTekst = "Help Početne stranice";
        }

        private void mojProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var noviMojProfil = new MojProfil();
            noviMojProfil.MdiParent = this;
            noviMojProfil.WindowState = FormWindowState.Maximized;
            noviMojProfil.Show();
            _helpTekst = "Help MojProfil stranice";
            
        }

        private void košaricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var novaKosarica = new Kosarica();
            novaKosarica.MdiParent = this;
            novaKosarica.WindowState = FormWindowState.Maximized;
            novaKosarica.Show();
            _helpTekst = "Help Kosarice";
            
        }

        private void listaŽeljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var novaListaZelja = new ListaZelja();
            novaListaZelja.MdiParent = this;
            novaListaZelja.WindowState = FormWindowState.Maximized;
            novaListaZelja.Show();
            _helpTekst = "Help ListeŽelja";
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GlavniIzbornikForma_Load(object sender, EventArgs e)
        {
            var novaPocetna = new Pocetna();
            novaPocetna.MdiParent = this;
            novaPocetna.WindowState = FormWindowState.Maximized;
            novaPocetna.Show();
            _helpTekst = "Help Početne stranice";
            if (korisnik.PrijavljeniKorisnik == null)
            {
                ProvjeraUloge(0);
                return;
            }
            ProvjeraUloge((int)korisnik.PrijavljeniKorisnik.idUloga);

        }

        private void dodajPonuduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var noviOglas = new ObjaviOglas();
            noviOglas.MdiParent = this;
            noviOglas.WindowState = FormWindowState.Maximized;
            noviOglas.Show();
            _helpTekst = "Help Početne stranice";
        }

        private void mojeKupnjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mojeKupnje = new MojeKupnje();
            mojeKupnje.MdiParent = this;
            mojeKupnje.WindowState = FormWindowState.Maximized;
            mojeKupnje.Show();
            _helpTekst = "Help Početne stranice";
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Administracija = new Administracija();
            Administracija.MdiParent = this;
            Administracija.WindowState = FormWindowState.Maximized;
            Administracija.Show();
            _helpTekst = "Help administracijske stranice";
        }

        private void ProvjeraUloge(int idPrijavljenog)
        {
            if (idPrijavljenog < 1)
            {
                košaricaToolStripMenuItem.Visible = false;
                mojProfilToolStripMenuItem.Visible = false;
                dodajPonuduToolStripMenuItem.Visible = false;
                listaŽeljaToolStripMenuItem.Visible = false;
                mojeKupnjeToolStripMenuItem.Visible = false;
                početnaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 440, 0);
            }
            if (idPrijavljenog < 2)
            {
                administratorToolStripMenuItem.Visible = false;
                odjavaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(350, 0, 0, 0);
            }
        }
    }
}
