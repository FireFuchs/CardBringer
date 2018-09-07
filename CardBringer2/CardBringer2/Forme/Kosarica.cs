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
    public partial class Kosarica : Form
    {
        public Kosarica()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Kosarica_Load(object sender, EventArgs e)
        {
            int nekupljeno = 0;    //prikazuje nekupljene 
            dataGridView1.DataSource = kosharica.DohvatiKosaricu(nekupljeno);
        }

        private void GumbKupi_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Refresaj()
        {
           
        }

        private void GumbMakni(object sender, EventArgs e)
        {
            
        }
    }
}
