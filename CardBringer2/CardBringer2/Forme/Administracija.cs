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
    public partial class Administracija : Form
    {
        public Administracija()
        {
            InitializeComponent();
            HelpClass.TrenutnaForma = 1;
            this.ControlBox = false;
        }

        private void Administracija_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodajNovuKartu_Click(object sender, EventArgs e)
        {
            var Administracija = new NovaKartaAdmin();
            Administracija.Show();
        }

        private void buttonUlogeKorisnika_Click(object sender, EventArgs e)
        {
            var Administracija = new PromjenaUlogeKorisnika();
            Administracija.Show();
        }
    }
}
