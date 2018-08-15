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
    public partial class Pocetna : Form
    { int idKorisnika;
        public Pocetna(int id)
        {
            InitializeComponent();
            idKorisnika = id;
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {

        }
    }
}
