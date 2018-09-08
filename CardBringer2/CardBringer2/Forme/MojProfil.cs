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
    public partial class MojProfil : Form
    {

        public MojProfil()
        {
            InitializeComponent();
            HelpClass.TrenutnaForma = 6;
            this.ControlBox = false;

            if (korisnik.PrijavljeniKorisnik == null) return;
            lblMojProfilID.Text = korisnik.PrijavljeniKorisnik.idKorisnika.ToString();
            lblMojProfilNickname.Text = korisnik.PrijavljeniKorisnik.ime;
            lblMojProfilEmail.Text = korisnik.PrijavljeniKorisnik.email;
            lblMojProfilAdresa.Text = korisnik.PrijavljeniKorisnik.mjestoStanovanja;
            lblMojProfilTipKorisnika.Text = uloga.DohvatiNazivUloge(korisnik.PrijavljeniKorisnik.idUloga);

            dgvMojProfilMojiOglasi.DataSource = oglas.DohvatiSvojeOglase();

        }

        private void MojProfil_Load(object sender, EventArgs e)
        {
            obradiDGV();
        }

        private void obradiDGV()
        {
            if (dgvMojProfilMojiOglasi.SelectedRows.Count <= 0) return;
            dgvMojProfilMojiOglasi.Columns["imeKarte"].HeaderText = "Ime karte";
            dgvMojProfilMojiOglasi.Columns["opisKarte"].HeaderText = "Opis karte";
            dgvMojProfilMojiOglasi.Columns["cijena"].HeaderText = "Cijena";
            dgvMojProfilMojiOglasi.Columns["kolicina"].HeaderText = "Količina";
            dgvMojProfilMojiOglasi.Columns["ime"].HeaderText = "Prodavač";
            dgvMojProfilMojiOglasi.Columns["idOglas"].Visible = false;
            dgvMojProfilMojiOglasi.Columns["slikaKarte"].Visible = false;
            dgvMojProfilMojiOglasi.Columns["aktivan"].Visible = false;

        }

        private void btnMojProfilUkloniOglas_Click(object sender, EventArgs e)
        {
            if (dgvMojProfilMojiOglasi.SelectedRows.Count <= 0) return;
            var idOglas = (int)dgvMojProfilMojiOglasi.SelectedRows[0].Cells["idOglas"].Value;
            oglas.DeaktivirajOglas(idOglas);

            dgvMojProfilMojiOglasi.DataSource = oglas.DohvatiSvojeOglase();
            pboxListaZeljaSlikaKarte.Image = null;
            lblMojProfilNazivKarte.Text = "Naziv karte";
            rtboxListaZeljaOpisKarte.Text = null;
        }

        private void dgvMojProfilMojiOglasi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMojProfilMojiOglasi.SelectedRows.Count <= 0) return;
            lblMojProfilNazivKarte.Text = dgvMojProfilMojiOglasi.SelectedRows[0].Cells[1].Value.ToString();
            rtboxListaZeljaOpisKarte.Text = dgvMojProfilMojiOglasi.SelectedRows[0].Cells[2].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(dgvMojProfilMojiOglasi.SelectedRows[0].Cells["slikaKarte"].Value.ToString());
            pboxListaZeljaSlikaKarte.Image = Image.FromStream(slikaKarte);
            pboxListaZeljaSlikaKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
