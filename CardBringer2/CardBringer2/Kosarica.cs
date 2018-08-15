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
    public partial class Kosarica : Form
    {
        int idKorisnik;
        public Kosarica(int id)
        {
            InitializeComponent();
            idKorisnik = id;
            this.ControlBox = false;
        }

        private void Kosarica_Load(object sender, EventArgs e)
        {

        }
    }
}
