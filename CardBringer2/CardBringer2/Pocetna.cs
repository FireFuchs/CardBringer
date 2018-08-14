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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = Database2; AttachDbFilename =C:\Users\Focho\Desktop\CardBringer2\CardBringer2\bin\Debug\Database2.mdf;Integrated Security = true";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO medjuspremnikKosarica ([idKorisnikKarta], [idKosarica]) VALUES ('" + ponuda + "' , '" + KosaricaBroj +  "')" ; 
            /*cmd.Parameters.AddWithValue("idKorisnikKarta", ponuda);
            cmd.Parameters.AddWithValue("idKosarica", KosaricaBroj);
            cmd.Parameters.AddWithValue("Kolicina", 1);
            cmd.Parameters.AddWithValue("Datum", 1);
            */
            cmd.ExecuteNonQuery();
            conn.Close();
            /*DataRow myRow;
            myRow = t.NewRow();
            myRow["idKorisnikKarta"] = ponuda;
            myRow["idKosarica"] = IDkorisnik;
            myRow["Kolicina"] = 1;
            myRow["Datum"] = 1;
            */
            /*Database2DataSetTableAdapters.medjuspremnikKosaricaTableAdapter medjuspremnik;
            medjuspremnik = new Database2DataSetTableAdapters.medjuspremnikKosaricaTableAdapter();
                Database2DataSet.medjuspremnikKosaricaRow noviRed;
                noviRed = database2DataSet.medjuspremnikKosarica.NewmedjuspremnikKosaricaRow();
                noviRed.idKosarica = KosaricaBroj;
                noviRed.idKorisnikKarta = ponuda;
                noviRed.Kolicina = "1";
                noviRed.Datum = DateTime.Now.ToString();

                this.database2DataSet.medjuspremnikKosarica.Rows.Add(noviRed);
                medjuspremnik.Update(database2DataSet.medjuspremnikKosarica);
                */
            /* t.Rows.Add(myRow);

             myDataSet.AcceptChanges();
             */
            Database2DataSetTableAdapters.korisnikKartaTableAdapter korKarta;
            korKarta = new Database2DataSetTableAdapters.korisnikKartaTableAdapter();
            int kolicina = (int)korKarta.KosaricaDohvatiKolicinu(ponuda);
            kolicina -= 1;
            korKarta.KosaricaSpremiKolicinu(kolicina, ponuda);
            korKarta.Update(database2DataSet);
            database2DataSet.AcceptChanges();
        }
    }
}
