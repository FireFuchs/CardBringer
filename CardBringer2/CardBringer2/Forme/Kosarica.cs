﻿using System;
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
            dgvKosaricaStavkeKosarice.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);
            ObradiDgv();
        }

        private void ObradiDgv()
        {
            if (dgvKosaricaStavkeKosarice.SelectedRows.Count <= 0) return;
            dgvKosaricaStavkeKosarice.Columns["imeKarte"].HeaderText = "Ime karte";
            dgvKosaricaStavkeKosarice.Columns["opisKarte"].HeaderText = "Opis karte";
            dgvKosaricaStavkeKosarice.Columns["cijena"].HeaderText = "Cijena";
            dgvKosaricaStavkeKosarice.Columns["kolicina"].HeaderText = "Količina";
            dgvKosaricaStavkeKosarice.Columns["ime"].HeaderText = "Prodavač";
            dgvKosaricaStavkeKosarice.Columns["idOglas"].Visible = false;
            dgvKosaricaStavkeKosarice.Columns["slikaKarte"].Visible = false;
            dgvKosaricaStavkeKosarice.Columns["kupljeno"].Visible = false;
            dgvKosaricaStavkeKosarice.Columns["idKosarica"].Visible = false;

        }

        private void btnKosaricaKupi_Click(object sender, EventArgs e)
        {
            if (dgvKosaricaStavkeKosarice.RowCount == 0)
            {
                MessageBox.Show("Vaša košarica je prazna.", "Greška", MessageBoxButtons.OK);
                return;
            }
            int idKosarica = (int)dgvKosaricaStavkeKosarice.SelectedRows[0].Cells["idKosarica"].Value;
            int idOglas = (int)dgvKosaricaStavkeKosarice.SelectedRows[0].Cells["idOglas"].Value;
            int kolicina = (int)dgvKosaricaStavkeKosarice.SelectedRows[0].Cells["kolicina"].Value;
            var popup = new UnosKartice();
            popup.ShowDialog();
            // stavka kosarica se oznacava kao kupljena
            kosharica.StavkaKupljenaIliNe(idKosarica, 1);
            // ukoliko u oglasu vise nema kolicine, tj nema preostalih karata, deaktivira se
            if (kolicina == 0) oglas.DeaktivirajOglas(idOglas);
            dgvKosaricaStavkeKosarice.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);
        }

        private void btnKosaricaMakni_Click(object sender, EventArgs e)
        {
            int idKosarica = (int)dgvKosaricaStavkeKosarice.SelectedRows[0].Cells["idKosarica"].Value;
            int idOglas = (int)dgvKosaricaStavkeKosarice.SelectedRows[0].Cells["idOglas"].Value;
            int kolicina = (int)dgvKosaricaStavkeKosarice.SelectedRows[0].Cells["kolicina"].Value;
            oglas.UpdateKolicinuUOglasu(idOglas, kolicina, true);
            kosharica.UkloniStavkuKosarice(idKosarica);
            dgvKosaricaStavkeKosarice.DataSource = kosharica.DohvatiKosaricu(_nekupljeno);
        }
    }
}
