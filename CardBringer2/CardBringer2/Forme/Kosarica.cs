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
            HelpClass.TrenutnaForma = 2;
            this.ControlBox = false;
        }

        private void Kosarica_Load(object sender, EventArgs e)
        {
            //prikazuje nekupljene 
            dgvKosaricaDatagridview.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);
            obradiDGV();
        }

        private void obradiDGV()
        {
            if (dgvKosaricaDatagridview.SelectedRows.Count <= 0) return;
            dgvKosaricaDatagridview.Columns["imeKarte"].HeaderText = "Ime karte";
            dgvKosaricaDatagridview.Columns["opisKarte"].HeaderText = "Opis karte";
            dgvKosaricaDatagridview.Columns["cijena"].HeaderText = "Cijena";
            dgvKosaricaDatagridview.Columns["kolicina"].HeaderText = "Količina";
            dgvKosaricaDatagridview.Columns["ime"].HeaderText = "Prodavač";
            dgvKosaricaDatagridview.Columns["idOglas"].Visible = false;
            dgvKosaricaDatagridview.Columns["slikaKarte"].Visible = false;
            dgvKosaricaDatagridview.Columns["kupljeno"].Visible = false;
            dgvKosaricaDatagridview.Columns["idKosarica"].Visible = false;

        }

        private void btnKosaricaKupi_Click(object sender, EventArgs e)
        {
            int idKosarica = (int)dgvKosaricaDatagridview.SelectedRows[0].Cells["idKosarica"].Value;
            int idOglas = (int)dgvKosaricaDatagridview.SelectedRows[0].Cells["idOglas"].Value;
            int kolicina = (int)dgvKosaricaDatagridview.SelectedRows[0].Cells["kolicina"].Value;
            var popup = new UnosKartice();
            popup.ShowDialog();
            // stavka kosarica se oznacava kao kupljena
            kosharica.StavkaKupljenaIliNe(idKosarica, 1);
            // ukoliko u oglasu vise nema kolicine, tj nema preostalih karata, deaktivira se
            if (kolicina == 0) oglas.DeaktivirajOglas(idOglas);
            dgvKosaricaDatagridview.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);
        }

        private void btnKosaricaMakni_Click(object sender, EventArgs e)
        {
            int idKosarica = (int)dgvKosaricaDatagridview.SelectedRows[0].Cells["idKosarica"].Value;
            int idOglas = (int)dgvKosaricaDatagridview.SelectedRows[0].Cells["idOglas"].Value;
            int kolicina = (int)dgvKosaricaDatagridview.SelectedRows[0].Cells["kolicina"].Value;
            oglas.UpdateKolicinuUOglasu(idOglas, kolicina, true);
            kosharica.UkloniStavkuKosarice(idKosarica);
            dgvKosaricaDatagridview.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);
        }
    }
}
