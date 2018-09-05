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
    public partial class PromjenaUlogeKorisnika : Form
    {
        private readonly string _reloadSql = $"SELECT k.idKorisnika AS id, k.ime AS Ime, k.email, k.mjestoStanovanja AS Adresa, u.nazivUloge AS Uloga, k.idUloga FROM korisnik k JOIN uloga u ON k.idUloga = u.idUloga";
        private const MessageBoxButtons Button = MessageBoxButtons.OK;
        private readonly int idPrijavljenog;
        public PromjenaUlogeKorisnika(int id)
        {
            InitializeComponent();
            idPrijavljenog = id;
        }

        private void PromjenaUlogeKorisnika_Load(object sender, EventArgs e)
        {
            //FormControls.LoadDatagridView(dataGridView1, _reloadSql);
            dataGridView1.Columns["idUloga"].Visible = false;
        }

        private void buttonDodajAdmina_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var dataAdapter = new SqlDataAdapter();
            var idUloga = (int)dataGridView1.SelectedRows[0].Cells[5].Value;
            if (idUloga == 2)
            {
                MessageBox.Show("Korisnik već ima administratorske privilegije!", "Greška", Button);
                return;
            }
            var idKorisnik = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var sql = $"UPDATE korisnik SET idUloga = 2 WHERE idKorisnika = '{idKorisnik}';";
            var command = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            db.Connection.Close();
            //FormControls.LoadDatagridView(dataGridView1, _reloadSql);
            dataGridView1.Columns["idUloga"].Visible = false;
        }

        private void buttonMakniAdmina_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var dataAdapter = new SqlDataAdapter();
            var idUloga = (int)dataGridView1.SelectedRows[0].Cells[5].Value;
            if (idUloga == 1)
            {
                
                MessageBox.Show("Ne možete maknuti privilegije jer ih kornisnik nema!", "Greška", Button);
                return;
            }
            var idKorisnik = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var sql = $"UPDATE korisnik SET idUloga = 1 WHERE idKorisnika = '{idKorisnik}';";
            var command = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            db.Connection.Close();
            //FormControls.LoadDatagridView(dataGridView1, _reloadSql);
            dataGridView1.Columns["idUloga"].Visible = false;
        }

        private void buttonIzbrisiKorisnika_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var dataAdapter = new SqlDataAdapter();
            
            var idKorisnik = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            if (idKorisnik == idPrijavljenog)
            {
                MessageBox.Show("Ne možete izbrisati sami sebe!", "Greška", Button);
                return;
            }
            var sql = $"DELETE korisnikKarta WHERE idKorisnik = '{idKorisnik}';";
            var command = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();

            sql = $"DELETE medjuspremnikKosarica WHERE idKorisnika = '{idKorisnik}';";
            command = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();

            sql = $"DELETE wishlist WHERE idKorisnik = '{idKorisnik}';";
            command = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();

            sql = $"DELETE korisnik WHERE idKorisnika = '{idKorisnik}';";
            command = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand = new SqlCommand(sql, db.Connection);
            dataAdapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();

            db.Connection.Close();
            //FormControls.LoadDatagridView(dataGridView1, _reloadSql);
            dataGridView1.Columns["idUloga"].Visible = false;
        }
    }
}
