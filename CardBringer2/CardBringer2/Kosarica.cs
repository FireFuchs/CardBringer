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
    public partial class Kosarica : Form
    {
        public Kosarica()
        {
            InitializeComponent();
        }

        private void Kosarica_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = Database2; AttachDbFilename =C:\Users\Focho\Desktop\CardBringer2\Database2.mdf;Integrated Security = true";
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT mk.idKorisnikKarta, k.imeKarte FROM medjuspremnikKosarica as mk join korisnikKarta as kk on mk.idKorisnikKarta = kk.idKorisnikKarta join karta as k on k.idKarta = kk.idKarta ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = da;
            Database2DataSetTableAdapters.medjuspremnikKosaricaTableAdapter medjuspremnik;
            medjuspremnik = new Database2DataSetTableAdapters.medjuspremnikKosaricaTableAdapter();

        }
    }
}
