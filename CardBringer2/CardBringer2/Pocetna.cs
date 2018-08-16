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
    { int idKorisnika;
        public Pocetna(int id)
        {
            InitializeComponent();
            idKorisnika = id;
            this.ControlBox = false;
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            loadDatagridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadDatagridView()
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var sql = $"SELECT kk.idKorisnikKarta AS 'ID Ponude', kar.imeKarte AS 'Ime Karte' , kar.opisKarte AS 'Opis Karte', kk.cijena AS 'Cijena', kk.kolicina AS 'Kolicina', k.ime AS 'Ime Prodavača' FROM korisnikKarta kk JOIN karta kar ON kar.idKarta = kk.idKarta JOIN korisnik k ON kk.idKorisnik = k.idKorisnika;";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();


            command.Dispose();
            db.Connection.Close();
        }
        private void PocetanGumbDodajUKosaricu_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();
            string vrijeme = DateTime.Today.ToString("yyyy-MM-dd");
            int idKarteZaKosaricu = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            
            var sql = $"SELECT COUNT(1) FROM medjuspremnikKosarica where idkorisnikKarta = '{idKarteZaKosaricu}';";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            
            command.Dispose();
            if (dataReader.HasRows)
            {
                dataReader.Close();
                //------------------------------------UPDATE--------------------------------
                int KolicinaKarataKojeImamo = 0;
                sql = $"SELECT kolicina FROM medjuspremnikKosarica WHERE idKorisnikKarta = '{idKarteZaKosaricu}' and idKosarica = '{idKorisnika}';";
                command = new SqlCommand(sql, db.Connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    KolicinaKarataKojeImamo = dataReader.GetInt32(0);
                }
                    command.Dispose();
                dataReader.Close();


                //------------------------------------UNOS------------------------------------
                var dataAdapter = new SqlDataAdapter();
                KolicinaKarataKojeImamo += 1;
                sql = $"UPDATE medjuspremnikKosarica SET kolicina = '{KolicinaKarataKojeImamo}' WHERE idKorisnikKarta = '{idKarteZaKosaricu}'";
                dataAdapter.UpdateCommand = new SqlCommand(sql, db.Connection);
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                updatePocetnaDataGrid();
                dataReader.Close();

            }
            else
            {
                var dataAdapter = new SqlDataAdapter();
                dataAdapter = new SqlDataAdapter();
                sql = $"INSERT INTO medjuspremnikKosarica ( idKosarica, idKorisnikKarta, Kolicina, datum) VALUES('{idKorisnika}', '{idKarteZaKosaricu}', '{1}', '{vrijeme}');";
                dataAdapter.InsertCommand = new SqlCommand(sql, db.Connection);
                dataAdapter.InsertCommand.ExecuteNonQuery();

                updatePocetnaDataGrid();
                
            }
               
            

            


        }
        private void updatePocetnaDataGrid()
        {
            var db = new DbInteraction();
            db.Connection.Open();
            var dataAdapter = new SqlDataAdapter();
            int idKarteZaKosaricu = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var sql = "";
            int kolicinaUpdate = (int)dataGridView1.SelectedRows[0].Cells[4].Value;
            kolicinaUpdate -= 1;
            sql = "UPDATE korisnikKarta SET kolicina = " + kolicinaUpdate + " where idKorisnikKarta = " + idKarteZaKosaricu + ";";
            var command = new SqlCommand(sql, db.Connection);
            dataAdapter.UpdateCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            db.Connection.Close();
            loadDatagridView();
        }
        private void PocetanGumbDodajUKosaricu_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var dataAdapter = new SqlDataAdapter();
            int idKarteZaKosaricu = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            string vrijeme = DateTime.Today.ToString("yyyy-MM-dd");
            var sql = $"INSERT INTO medjuspremnikKosarica ( idKosarica, idKorisnikKarta, Kolicina, datum) VALUES('{idKorisnika}', '{idKarteZaKosaricu}', '{1}', '{vrijeme}');";
            var command = new SqlCommand(sql, db.Connection);
            dataAdapter.InsertCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();


            int kolicinaUpdate = (int)dataGridView1.SelectedRows[0].Cells[4].Value;
            kolicinaUpdate -= 1;
            sql = "UPDATE korisnikKarta SET kolicina = " + kolicinaUpdate + " where idKorisnikKarta = " + idKarteZaKosaricu + ";";
            dataAdapter.UpdateCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            db.Connection.Close();
            loadDatagridView();
        }
    }
}
