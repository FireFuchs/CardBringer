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
        string helpTekst = "Help glavne forme";
        int idKorisnika;
        public GlavniIzbornikForma()
        {
            InitializeComponent();
        }
        public GlavniIzbornikForma(int id)
        {
            InitializeComponent();
            idKorisnika = id;
        }

        private void GlavniIzbornikForma_KeyDown(object sender, KeyEventArgs e)
        {
            var help = new HelpClass(helpTekst);
        }

        private void unosGumbHelpGlavniIzbornikForma_Click(object sender, EventArgs e)
        {
            var help = new HelpClass(helpTekst);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void početnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pocetna novaPocetna = new Pocetna(idKorisnika);
            novaPocetna.MdiParent = this;
            novaPocetna.WindowState = FormWindowState.Maximized;
            novaPocetna.Show();
            helpTekst = "Help Početne stranice";
        }

        private void mojProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MojProfil noviMojProfil = new MojProfil(idKorisnika);
            noviMojProfil.MdiParent = this;
            noviMojProfil.WindowState = FormWindowState.Maximized;
            noviMojProfil.Show();
            helpTekst = "Help MojProfil stranice";
        }

        private void košaricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kosarica novaKosarica = new Kosarica(idKorisnika);
            novaKosarica.MdiParent = this;
            novaKosarica.WindowState = FormWindowState.Maximized;
            novaKosarica.Show();
            helpTekst = "Help Kosarice";
        }

        private void listaŽeljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaZelja novaListaZelja = new ListaZelja(idKorisnika);
            novaListaZelja.MdiParent = this;
            novaListaZelja.WindowState = FormWindowState.Maximized;
            novaListaZelja.Show();
            helpTekst = "Help ListeŽelja";
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GlavniIzbornikForma_Load(object sender, EventArgs e)
        {
            Pocetna novaPocetna = new Pocetna(idKorisnika);
            novaPocetna.MdiParent = this;
            novaPocetna.WindowState = FormWindowState.Maximized;
            novaPocetna.Show();
            helpTekst = "Help Početne stranice";
        }
    }
}
