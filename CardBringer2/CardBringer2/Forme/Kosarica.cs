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
        private readonly int _nekupljeno = 0;

        public Kosarica()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Kosarica_Load(object sender, EventArgs e)
        {
            //prikazuje nekupljene 
            dgKarteUKosarici.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);
        }

        private void GumbKupi_Click(object sender, EventArgs e)
        {
            int idKosarica = (int)dgKarteUKosarici.SelectedRows[0].Cells["idKosarica"].Value;
            int idOglas = (int)dgKarteUKosarici.SelectedRows[0].Cells["idOglas"].Value;

            // stavka kosarica se oznacava kao kupljena
            kosharica.StavkaKupljenaIliNe(idKosarica, 1);
            // ukoliko u oglasu vise nema kolicine, tj nema preostalih karata, deaktivira se
            oglas.DeaktivirajOglas(idOglas);

            dgKarteUKosarici.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);
        }


        private void GumbMakni(object sender, EventArgs e)
        {
            int idKosarica = (int)dgKarteUKosarici.SelectedRows[0].Cells["idKosarica"].Value;
            int idOglas = (int)dgKarteUKosarici.SelectedRows[0].Cells["idOglas"].Value;
            int kolicina = (int)dgKarteUKosarici.SelectedRows[0].Cells["kolicina"].Value;
            oglas.UpdateKolicinuUOglasu(idOglas, kolicina, true);
            kosharica.UkloniStavkuKosarice(idKosarica);
            dgKarteUKosarici.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);

        }
    }
}
