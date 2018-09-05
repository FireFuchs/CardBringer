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
    public partial class Pocetna : Form
    {
        private readonly int _idKorisnika;
        private readonly string _reloadSql = $"SELECT kk.idKorisnikKarta AS 'ID Ponude', kar.imeKarte AS 'Ime Karte' , kar.opisKarte AS 'Opis Karte', kk.cijena AS 'Cijena', kk.kolicina AS 'Kolicina', k.ime AS 'Ime Prodavača', kar.slikaKarte FROM korisnikKarta kk JOIN karta kar ON kar.idKarta = kk.idKarta JOIN korisnik k ON kk.idKorisnik = k.idKorisnika;";
        public Pocetna(int id)
        {
            InitializeComponent();
            _idKorisnika = id;
            this.ControlBox = false;
            
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            //FormControls.LoadDatagridView(dataGridView1, _reloadSql);
            //dataGridView1.Columns["slikaKarte"].Visible = false;
        }
        
        private void PocetanGumbDodajUKosaricu_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();
            var dataAdapter = new SqlDataAdapter();

            var vrijeme = DateTime.Today.ToString("yyyy-MM-dd");
            var idKarteZaKosaricu = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var sql = $"SELECT COUNT(1) FROM medjuspremnikKosarica where idkorisnikKarta = '{idKarteZaKosaricu}';";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            var postoji = 0;
            while (dataReader.Read())
            {
                postoji = dataReader.GetInt32(0);
            }
            
            command.Dispose();
            if ((int)dataGridView1.SelectedRows[0].Cells[4].Value > 0)
            {
                if (postoji == 1)
                {
                    dataReader.Close();
                    //------------------------------------UPDATE--------------------------------
                    var kolicinaKarataKojeImamo = 0;
                    sql = $"SELECT kolicina FROM medjuspremnikKosarica WHERE idKorisnikKarta = '{idKarteZaKosaricu}' and idKorisnika = '{_idKorisnika}';";
                    command = new SqlCommand(sql, db.Connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        kolicinaKarataKojeImamo = dataReader.GetInt32(0);
                    }
                    command.Dispose();
                    dataReader.Close();


                    //------------------------------------UNOS------------------------------------

                    kolicinaKarataKojeImamo += 1;
                    sql = $"UPDATE medjuspremnikKosarica SET kolicina = '{kolicinaKarataKojeImamo}' WHERE idKorisnikKarta = '{idKarteZaKosaricu}'";
                    dataAdapter.UpdateCommand = new SqlCommand(sql, db.Connection);
                    dataAdapter.UpdateCommand.ExecuteNonQuery();

                    UpdatePocetnaDataGrid();
                    dataReader.Close();

                }
                else
                {
                    dataReader.Close();
                    dataAdapter = new SqlDataAdapter();
                    sql = $"INSERT INTO medjuspremnikKosarica ( idKorisnika, idKorisnikKarta, Kolicina, datum) VALUES('{_idKorisnika}', '{idKarteZaKosaricu}', '{1}', '{vrijeme}');";
                    dataAdapter.InsertCommand = new SqlCommand(sql, db.Connection);
                    dataAdapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    UpdatePocetnaDataGrid();
                    db.Connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Nema vise dostupnih karata!", "Greška", MessageBoxButtons.OK);
            }
            
        }

        private void UpdatePocetnaDataGrid()
        {
            var db = new DbInteraction();
            db.Connection.Open();
            var dataAdapter = new SqlDataAdapter();
            var idKarteZaKosaricu = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var kolicinaUpdate = (int)dataGridView1.SelectedRows[0].Cells[4].Value;
            if (kolicinaUpdate > 0) { 
            kolicinaUpdate -= 1;
            var sql = "UPDATE korisnikKarta SET kolicina = " + kolicinaUpdate + " where idKorisnikKarta = " + idKarteZaKosaricu + ";";
            var command = new SqlCommand(sql, db.Connection);
            dataAdapter.UpdateCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            db.Connection.Close();
            }
           

            //FormControls.LoadDatagridView(dataGridView1, _reloadSql);
            dataGridView1.Columns["slikaKarte"].Visible = false;
        }
        

        private void PocetnaResetGumb_Click(object sender, EventArgs e)
        {
            //FormControls.LoadDatagridView(dataGridView1, _reloadSql);

        }
        

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            imeKarte.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cijenaKarte.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            kolicinaKarata.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            prodavacKarte.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            opisKarte.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //var slikaKarte = FormControls.DohvatiSlikuKarte(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            //pictureBoxSlikaKarte.Image = Image.FromStream(slikaKarte);
            pictureBoxSlikaKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PocetnaPretragaGumbTrazi_Click(object sender, EventArgs e)
        {
            Trazi();
        }

        private void PocetnaPretragaText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Trazi();
            }
        }

        private void Trazi()
        {
            var imeTrazenja = PocetnaPretragaText.Text;
            var sql = $"SELECT kk.idKorisnikKarta AS 'ID Ponude', kar.imeKarte AS 'Ime Karte' , kar.opisKarte AS 'Opis Karte', kk.cijena AS 'Cijena', kk.kolicina AS 'Kolicina', k.ime AS 'Ime Prodavača' FROM korisnikKarta kk JOIN karta kar ON kar.idKarta = kk.idKarta JOIN korisnik k ON kk.idKorisnik = k.idKorisnika WHERE kar.imeKarte LIKE '%{imeTrazenja}%';";
            //FormControls.LoadDatagridView(dataGridView1, sql);
        }
        
    }
}
