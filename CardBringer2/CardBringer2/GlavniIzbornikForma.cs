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

        public GlavniIzbornikForma()
        {
            InitializeComponent();

        }
        

        private void GlavniIzbornikForma_KeyDown(object sender, KeyEventArgs e)
        {
            HelpClass help = new HelpClass(helpTekst);
        }

        private void unosGumbHelpGlavniIzbornikForma_Click(object sender, EventArgs e)
        {
            HelpClass help = new HelpClass(helpTekst);

        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void početnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pocetna novaPocetna = new Pocetna();
            novaPocetna.MdiParent = this;
            novaPocetna.WindowState = FormWindowState.Maximized;
            novaPocetna.Show();

        }

        private void mojProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MojProfil noviMojProfil = new MojProfil();
            noviMojProfil.MdiParent = this;
            noviMojProfil.WindowState = FormWindowState.Maximized;
            noviMojProfil.Show();
        }

        private void GlavniIzbornikForma_Load(object sender, EventArgs e)
        {
            Pocetna novaPocetna = new Pocetna();
            novaPocetna.MdiParent = this;
            novaPocetna.WindowState = FormWindowState.Maximized;
            novaPocetna.Show();

        }

        private void košaricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kosarica novaKosarica = new Kosarica();
            novaKosarica.MdiParent = this;
            novaKosarica.WindowState = FormWindowState.Maximized;
            novaKosarica.Show();
        }

        private void listaŽeljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaZelja novaListaZelja = new ListaZelja();
            novaListaZelja.MdiParent = this;
            novaListaZelja.WindowState = FormWindowState.Maximized;
            novaListaZelja.Show();

        }
    }
}
