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
        readonly int _idKorisnika;
        public GlavniIzbornikForma()
        {
            InitializeComponent();
        }
        public GlavniIzbornikForma(int id)
        {
            InitializeComponent();
            _idKorisnika = id;
        }

        private void GlavniIzbornikForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var help = new HelpClass(_helpTekst);
            }

        }

        private void unosGumbHelpGlavniIzbornikForma_Click(object sender, EventArgs e)
        {
            var help = new HelpClass(_helpTekst);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void početnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var novaPocetna = new Pocetna(_idKorisnika);
            novaPocetna.MdiParent = this;
            novaPocetna.WindowState = FormWindowState.Maximized;
            novaPocetna.Show();
            _helpTekst = "Help Početne stranice";
        }

        private void mojProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var noviMojProfil = new MojProfil(_idKorisnika);
            noviMojProfil.MdiParent = this;
            noviMojProfil.WindowState = FormWindowState.Maximized;
            noviMojProfil.Show();
            _helpTekst = "Help MojProfil stranice";
        }

        private void košaricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var novaKosarica = new Kosarica(_idKorisnika);
            novaKosarica.MdiParent = this;
            novaKosarica.WindowState = FormWindowState.Maximized;
            novaKosarica.Show();
            _helpTekst = "Help Kosarice";
        }

        private void listaŽeljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var novaListaZelja = new ListaZelja(_idKorisnika);
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
            var novaPocetna = new Pocetna(_idKorisnika);
            novaPocetna.MdiParent = this;
            novaPocetna.WindowState = FormWindowState.Maximized;
            novaPocetna.Show();
            _helpTekst = "Help Početne stranice";
        }

        private void dodajPonuduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var noviOglas = new ObjaviOglas(_idKorisnika);
            noviOglas.MdiParent = this;
            noviOglas.WindowState = FormWindowState.Maximized;
            noviOglas.Show();
            _helpTekst = "Help Početne stranice";
        }

        private void mojeKupnjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mojeKupnje = new MojeKupnje(_idKorisnika);
            mojeKupnje.MdiParent = this;
            mojeKupnje.WindowState = FormWindowState.Maximized;
            mojeKupnje.Show();
            _helpTekst = "Help Početne stranice";
        }
    }
}
