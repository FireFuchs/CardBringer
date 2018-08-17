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
    public partial class MojeKupnje : Form
    {
        int _idKorisnika;
        public MojeKupnje(int id)
        {
            InitializeComponent();
            _idKorisnika = id;
            this.ControlBox = false;
        }

        private void MojeKupnje_Load(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.Connection.Open();

            var sql = $"SELECT idKupnje, kolicinaKarata, ukupnaCijena, datum FROM obavljenaKupnja WHERE idKorisnik = '{_idKorisnika}'";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            DataGridZaKupljene.AutoGenerateColumns = true;
            DataGridZaKupljene.DataSource = dt;
            DataGridZaKupljene.Refresh();
        }
    }
}
