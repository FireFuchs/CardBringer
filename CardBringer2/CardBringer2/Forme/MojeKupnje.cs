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
using Help;

namespace CardBringer2
{
    public partial class MojeKupnje : Form
    {
        private const int _kupljeno = 1;

        public MojeKupnje()
        {
            InitializeComponent();
            HelpClass.TrenutnaForma = 5;
            this.ControlBox = false;
        }

        private void MojeKupnje_Load(object sender, EventArgs e)
        {
            // Prikazuje kupljene oglase u košarici
            dgvMojeKupnjeDatagrid.DataSource = kosharica.DohvatiKosaricu(_kupljeno);
            ObradiDgv();
        }
        private void ObradiDgv()
        {

            // Sakrije sve nepotrebne podatke, i preimenuje sve vidljive stupce
            if (dgvMojeKupnjeDatagrid.SelectedRows.Count <= 0) return;
            dgvMojeKupnjeDatagrid.Columns["cijena"].DefaultCellStyle.Format = "0.00";
            dgvMojeKupnjeDatagrid.Columns["imeKarte"].HeaderText = "Ime karte";
            dgvMojeKupnjeDatagrid.Columns["opisKarte"].HeaderText = "Opis karte";
            dgvMojeKupnjeDatagrid.Columns["cijena"].HeaderText = "Cijena";
            dgvMojeKupnjeDatagrid.Columns["kolicina"].HeaderText = "Količina";
            dgvMojeKupnjeDatagrid.Columns["ime"].HeaderText = "Prodavač";
            dgvMojeKupnjeDatagrid.Columns["idOglas"].Visible = false;
            dgvMojeKupnjeDatagrid.Columns["slikaKarte"].Visible = false;
            dgvMojeKupnjeDatagrid.Columns["kupljeno"].Visible = false;
            dgvMojeKupnjeDatagrid.Columns["idKosarica"].Visible = false;

        }
    }
}
