using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardBringer2
{
    public partial class MojeKupnje : Form
    {
        public MojeKupnje()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void MojeKupnje_Load(object sender, EventArgs e)
        {
            int kupljeno = 1; // prikazuje kupljene
            DataGridZaKupljene.DataSource = kosharica.DohvatiKosaricu(kupljeno);
        }
    }
}
