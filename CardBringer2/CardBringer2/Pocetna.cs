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
        readonly int _idKorisnika;
        public Pocetna(int id)
        {
            InitializeComponent();
            _idKorisnika = id;
            this.ControlBox = false;
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            LoadDatagridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDatagridView()
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
            int postoji = 0;
            while (dataReader.Read())
            {
                postoji = dataReader.GetInt32(0);
            }
            
            command.Dispose();
            if ( postoji == 1)
            {
                
                dataReader.Close();
                //------------------------------------UPDATE--------------------------------
                int kolicinaKarataKojeImamo = 0;
                sql = $"SELECT kolicina FROM medjuspremnikKosarica WHERE idKorisnikKarta = '{idKarteZaKosaricu}' and idKosarica = '{_idKorisnika}';";
                command = new SqlCommand(sql, db.Connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    kolicinaKarataKojeImamo = dataReader.GetInt32(0);
                }
                    command.Dispose();
                dataReader.Close();


                //------------------------------------UNOS------------------------------------
                var dataAdapter = new SqlDataAdapter();
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
                var dataAdapter = new SqlDataAdapter();
                dataAdapter = new SqlDataAdapter();
                sql = $"INSERT INTO medjuspremnikKosarica ( idKosarica, idKorisnikKarta, Kolicina, datum) VALUES('{_idKorisnika}', '{idKarteZaKosaricu}', '{1}', '{vrijeme}');";
                dataAdapter.InsertCommand = new SqlCommand(sql, db.Connection);
                dataAdapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                UpdatePocetnaDataGrid();
                db.Connection.Close();
            }
               
            

            


        }
        private void UpdatePocetnaDataGrid()
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
            
            LoadDatagridView();
        }
    }
}
