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
    public partial class ListaZelja : Form
    {
        int idKorisnika;
        public ListaZelja(int id)
        {
            InitializeComponent();
            idKorisnika = id;
            this.ControlBox = false;
        }

        private void ListaZelja_Load(object sender, EventArgs e)
        {

        }
    }
}
