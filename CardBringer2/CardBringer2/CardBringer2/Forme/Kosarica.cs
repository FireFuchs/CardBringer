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
            obradiDGV();
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
        private void obradiDGV()
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            dataGridView1.Columns["imeKarte"].HeaderText = "Ime karte";
            dataGridView1.Columns["opisKarte"].HeaderText = "Opis karte";
            dataGridView1.Columns["cijena"].HeaderText = "Cijena";
            dataGridView1.Columns["kolicina"].HeaderText = "Količina";
            dataGridView1.Columns["ime"].HeaderText = "Prodavač";
            dataGridView1.Columns["idOglas"].Visible = false;
            dataGridView1.Columns["slikaKarte"].Visible = false;
            dataGridView1.Columns["aktivan"].Visible = false;
        }
    }
}
