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
    public partial class Pocetna : Form
    {
        
        public Pocetna()
        {
            InitializeComponent();
            HelpClass.TrenutnaForma = 9;
            this.ControlBox = false;
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            dgvPocetnaDatagridSviOglasi.DataSource = oglas.DohvatiSveAktivneOglase();
            ObradiDgv();
            sakrijGost();
        }
        
        private void DodajUKosaricu()
        {

            if (dgvPocetnaDatagridSviOglasi.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nije odabran niti jedan oglas!", "Greška", MessageBoxButtons.OK);
                return;
            };
            string imeProdavaca;
            int brojKarataNaProdaju;
            int brojKarataZaKosaricu;
            int idOglas;
            int novaKolicina;

            imeProdavaca = dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["ime"].Value.ToString();
            if (imeProdavaca == korisnik.PrijavljeniKorisnik.ime)
            {
                MessageBox.Show("Ne možete kupiti vlastiti oglas!", "Greška", MessageBoxButtons.OK);
                return;
            }

            // Provjera da Količina karata je pravilno unesena
            if (tboxPocetnaBrojKarataZaKosaricu.Text == "")
            {
                MessageBox.Show("Ne možete dodati 0 karata!", "Greška", MessageBoxButtons.OK);
                return;
            }

            brojKarataNaProdaju = (int)dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["kolicina"].Value;
            brojKarataZaKosaricu = int.Parse(tboxPocetnaBrojKarataZaKosaricu.Text);
            if (brojKarataZaKosaricu <= 0)
            {
                MessageBox.Show("Ne možete dodati 0 karata!", "Greška", MessageBoxButtons.OK);
                return;
            }
            if (brojKarataZaKosaricu > brojKarataNaProdaju)
            {
                MessageBox.Show("Ne možete uzeti više karata nego što se prodaje!", "Greška", MessageBoxButtons.OK);
                return;
            }

            idOglas = (int)dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["idOglas"].Value;
            novaKolicina = brojKarataNaProdaju - brojKarataZaKosaricu;
            oglas.UpdateKolicinuUOglasu(idOglas, novaKolicina, false);

            kosharica k = new kosharica();
            k.idOglas = idOglas;
            k.kolicina = brojKarataZaKosaricu;
            k.Spremi();

            dgvPocetnaDatagridSviOglasi.DataSource = oglas.DohvatiSveAktivneOglase();
            tboxPocetnaBrojKarataZaKosaricu.Text = 1.ToString();

        } 

        private void Trazi()
        {
            var pretrazivaniString = tboxPocetnaPretragabox.Text;
            dgvPocetnaDatagridSviOglasi.DataSource = oglas.TraziOglase(pretrazivaniString);
        }

        private void ObradiDgv()
        {
            // Sakrivanje svih nepotrebnih podataka i preimenovanje podataka koji su vidljivi
            if (dgvPocetnaDatagridSviOglasi.SelectedRows.Count <= 0) return;
            dgvPocetnaDatagridSviOglasi.Columns["cijena"].DefaultCellStyle.Format = "0.00";
            dgvPocetnaDatagridSviOglasi.Columns["imeKarte"].HeaderText = "Ime karte";
            dgvPocetnaDatagridSviOglasi.Columns["opisKarte"].HeaderText = "Opis karte";
            dgvPocetnaDatagridSviOglasi.Columns["cijena"].HeaderText = "Cijena";
            dgvPocetnaDatagridSviOglasi.Columns["kolicina"].HeaderText = "Količina";
            dgvPocetnaDatagridSviOglasi.Columns["ime"].HeaderText = "Prodavač";
            dgvPocetnaDatagridSviOglasi.Columns["idOglas"].Visible = false;
            dgvPocetnaDatagridSviOglasi.Columns["slikaKarte"].Visible = false;
            dgvPocetnaDatagridSviOglasi.Columns["aktivan"].Visible = false;
        }

        private void PocetnaBrojKarataZaKosaricu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void PocetnaBrojKarataZaKosaricu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                DodajUKosaricu();
            }
        }

        private void tboxPocetnaPretragabox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Trazi();
            }
        }

        private void btnPocetnaTrazigumb_Click(object sender, EventArgs e)
        {
            Trazi();
        }

        private void btnPocetnaResetgumb_Click(object sender, EventArgs e)
        {
            dgvPocetnaDatagridSviOglasi.DataSource = oglas.DohvatiSveAktivneOglase();
            ObradiDgv();
        }

        private void dgvPocetnaDatagridSviOglasi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Promjena detalja oglasa koji se nalaze na desnoj strani forme
            if (dgvPocetnaDatagridSviOglasi.SelectedRows.Count <= 0) return;
            lblPocetnaIspisImeKarte.Text = dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["imeKarte"].Value.ToString();
            lblPocetnaIspisCijenaKarte.Text = String.Format("{0:0.00}",dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["cijena"].Value);
            lblPocetnaIspisKolicina.Text = dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["kolicina"].Value.ToString();
            lblPocetnaIspisProdavac.Text = dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["ime"].Value.ToString();
            rtboxPocetnaOpisKarte.Text = dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["opisKarte"].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(dgvPocetnaDatagridSviOglasi.SelectedRows[0].Cells["slikaKarte"].Value.ToString());
            pboxPocetnaSlikaKarte.Image = Image.FromStream(slikaKarte);
            pboxPocetnaSlikaKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnPocetanGumbDodajUKosaricu_Click(object sender, EventArgs e)
        {
            DodajUKosaricu();
        }

        private void sakrijGost()
        {
            // Sakrivanje textboxa i gumba za košaricu koje gost ne bi trebao vidjeti
            if (korisnik.PrijavljeniKorisnik == null)
            {
                lblPocetnaBrojKarata.Visible = false;
                tboxPocetnaBrojKarataZaKosaricu.Visible = false;
                btnPocetanGumbDodajUKosaricu.Visible = false;
            }
        }
    }
}
