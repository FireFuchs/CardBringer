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
    public partial class Pocetna : Form
    {
        int IDkorisnik;
        public Pocetna(int korIme)
        {
            InitializeComponent();
            IDkorisnik = korIme;
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet.korisnikKarta' table. You can move, or remove it, as needed.
            this.korisnikKartaTableAdapter.FillBySveKarte(this.database2DataSet.korisnikKarta);
            dataGridView1.AutoGenerateColumns = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PocetanGumbDodajUKosaricu_Click(object sender, EventArgs e)
        {
            int ponuda = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            Database2DataSetTableAdapters.kosaricaTableAdapter kosarica;
            kosarica = new Database2DataSetTableAdapters.kosaricaTableAdapter();
            int KosaricaBroj = (int)kosarica.returnKosaricaId(IDkorisnik);
            dodajMedjuspremnik(KosaricaBroj, ponuda);
            
            
        }
        private void dodajMedjuspremnik(int Broj, int ponud)
        {
            int KosaricaBroj = Broj;
            int ponuda = ponud;
            Database2DataSet myDataSet;
            myDataSet = new Database2DataSet();
            DataTable t;
            t = myDataSet.Tables["medjuspremnikKosarica"];

            DataRow myRow;
            myRow = t.NewRow();
            myRow["idKorisnikKarta"] = ponuda;
            myRow["idKosarica"] = IDkorisnik;
            myRow["Kolicina"] = 1;
            myRow["Datum"] = 1;
            /*
        Database2DataSetTableAdapters.medjuspremnikKosaricaTableAdapter medjuspremnik;
        medjuspremnik = new Database2DataSetTableAdapters.medjuspremnikKosaricaTableAdapter();
        medjuspremnik.InsertQuery(ponuda, KosaricaBroj, 1, DateTime.Now.ToString());
        */
            t.Rows.Add(myRow);
            myDataSet.AcceptChanges();

            Database2DataSetTableAdapters.korisnikKartaTableAdapter korKarta;
            korKarta = new Database2DataSetTableAdapters.korisnikKartaTableAdapter();
            int kolicina = (int)korKarta.KosaricaDohvatiKolicinu(ponuda);
            kolicina -= 1;
            korKarta.KosaricaSpremiKolicinu(kolicina, ponuda);
        }
    }
}
