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

        private void unosGumbHelpGlavniIzbornikForma_Click(object sender, EventArgs e)
        {
            string Help = "pocetna verzija help sustava, probni pokusaj";
            HelpForm helpFrm = new HelpForm(Help);
            helpFrm.Show();
        }

        private void GlavniIzbornikForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string Help = "pocetna verzija help sustava, probni pokusaj, ali ovaj puta s glavnog izbornika tak da mora biti malo drukčiji text.";
                HelpForm helpFrm = new HelpForm(Help);
                helpFrm.Show();
            }
        }
    }
}
