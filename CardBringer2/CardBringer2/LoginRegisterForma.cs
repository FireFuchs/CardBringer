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
    public partial class LoginRegisterForma : Form
    {
        string helpTekst = "pocetna verzija help sustava, probni pokusaj";

        GlavniIzbornikForma GlavniFrm = new GlavniIzbornikForma();

        public LoginRegisterForma()
        {
            InitializeComponent();
        }

        private void unosKorisnickoImeLoginLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosKorisnickoImeLoginLoginRegisterForma.Text == "Korisnicko Ime")
            {
                unosKorisnickoImeLoginLoginRegisterForma.Text = "";
                unosKorisnickoImeLoginLoginRegisterForma.ForeColor = Color.Black;
            }
        }

        private void unosKorisnickoImeLoginLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosKorisnickoImeLoginLoginRegisterForma.Text == "")
            {
                unosKorisnickoImeLoginLoginRegisterForma.Text = "Korisnicko Ime";
                unosKorisnickoImeLoginLoginRegisterForma.ForeColor = Color.Gray;
            }
        }

        private void unosPasswordLoginLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosPasswordLoginLoginRegisterForma.Text == "Lozinka")
            {
                unosPasswordLoginLoginRegisterForma.Text = "";
                unosPasswordLoginLoginRegisterForma.ForeColor = Color.Black;
            }
        }

        private void unosPasswordLoginLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosPasswordLoginLoginRegisterForma.Text == "")
            {
                unosPasswordLoginLoginRegisterForma.Text = "Lozinka";
                unosPasswordLoginLoginRegisterForma.ForeColor = Color.Gray;
            }
        }

        private void unosEmailRegisterLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosEmailRegisterLoginRegisterForma.Text == "E-Mail")
            {
                unosEmailRegisterLoginRegisterForma.Text = "";
                unosEmailRegisterLoginRegisterForma.ForeColor = Color.Black;
            }
        }

        private void unosEmailRegisterLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosEmailRegisterLoginRegisterForma.Text != "") return;
            unosEmailRegisterLoginRegisterForma.Text = "E-Mail";
            unosEmailRegisterLoginRegisterForma.ForeColor = Color.Gray;
        }

        private void unosKorisnickoImeRegisterLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosKorisnickoImeRegisterLoginRegisterForma.Text != "Korisnicko Ime") return;
            unosKorisnickoImeRegisterLoginRegisterForma.Text = "";
            unosKorisnickoImeRegisterLoginRegisterForma.ForeColor = Color.Black;
        }

        private void unosKorisnickoImeRegisterLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosKorisnickoImeRegisterLoginRegisterForma.Text != "") return;
            unosKorisnickoImeRegisterLoginRegisterForma.Text = "Korisnicko Ime";
            unosKorisnickoImeRegisterLoginRegisterForma.ForeColor = Color.Gray;
        }

        private void unosPasswordRegisterLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosPasswordRegisterLoginRegisterForma.Text != "Lozinka") return;
            unosPasswordRegisterLoginRegisterForma.Text = "";
            unosPasswordRegisterLoginRegisterForma.ForeColor = Color.Black;
        }

        private void unosPasswordRegisterLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosPasswordRegisterLoginRegisterForma.Text == "")
            {
                unosPasswordRegisterLoginRegisterForma.Text = "Lozinka";
                unosPasswordRegisterLoginRegisterForma.ForeColor = Color.Gray;
            }
        }

        private void unosPonovljeniPasswordRegisterLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosPonovljeniPasswordRegisterLoginRegisterForma.Text != "Ponovljena Lozinka") return;
            unosPonovljeniPasswordRegisterLoginRegisterForma.Text = "";
            unosPonovljeniPasswordRegisterLoginRegisterForma.ForeColor = Color.Black;
        }

        private void unosPonovljeniPasswordRegisterLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosPonovljeniPasswordRegisterLoginRegisterForma.Text != "") return;
            unosPonovljeniPasswordRegisterLoginRegisterForma.Text = "Ponovljena Lozinka";
            unosPonovljeniPasswordRegisterLoginRegisterForma.ForeColor = Color.Gray;
        }

        private void unosGumbLoginLoginRegisterForma_Click(object sender, EventArgs e)
        {
            var db = new DbInteraction();
            db.connection.Open();

            SqlDataReader dataReader;
            SqlCommand command;
            string sql, output="";


            var username = unosKorisnickoImeLoginLoginRegisterForma.Text;
            var password = unosPasswordLoginLoginRegisterForma.Text;


            sql = $"SELECT lozinka FROM korisnik WHERE ime = '{username}';";
            command = new SqlCommand(sql, db.connection);
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                var realPassword = dataReader.GetString(0);
                if (password == realPassword)
                {
                    //funkcija za dohvacanje ID-a i njegovo passanje u GlavniForm
                    OtvoriGlavnuFormu(username);
                }
                else
                {
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show("Kriva lozinka", "Greška", button);
                }
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Ne postoji taj korisnik", "Greška", button);
            }
                
            
            //int loginBroj;
            //loginBroj = (int)korisnikTableAdapter.Login(korIme, korLozinka);
            //if (loginBroj == 1)
            //{

            //    idKorisnika = (int)korisnikTableAdapter.idReturn(korIme);
            //    GlavniIzbornikForma GlavniFrm = new GlavniIzbornikForma(idKorisnika);
            //    GlavniFrm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBoxButtons button = MessageBoxButtons.OK;
            //    MessageBox.Show("Kriva kombinacija Lozinke i Imena", "Greška", button);
            //}


            db.connection.Close();
        }

        private void unosGumbRegistrirajLoginRegisterForma_Click(object sender, EventArgs e)
        {
            //GlavniFrm.Show();
            //this.Hide();

            var db = new DbInteraction();
            db.connection.Open();
            db.connection.Close();
        }

        private void unosGumbHelpLoginRegisterForma_Click(object sender, EventArgs e)
        {
            var help = new HelpClass(helpTekst);
        }

        private void LoginRegisterForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var help = new HelpClass(helpTekst);
            }
        }

        private void UnosGumbGostLoginRegisterForma_Click(object sender, EventArgs e)
        {
            GlavniFrm.Show();
            this.Hide();
        }

        private void LoginRegisterForma_Load(object sender, EventArgs e)
        {
        }

        // FUNKCIJE

        private void OtvoriGlavnuFormu(string username)
        {
            var db = new DbInteraction();
            db.connection.Open();

            var output = "";

            var sql = $"SELECT idKorisnika FROM korisnik WHERE ime = '{username}';";
            var command = new SqlCommand(sql, db.connection);
            var dataReader = command.ExecuteReader();
            dataReader.Read();
            var idKorisnika = dataReader.GetInt32(0);
            var GlavniFrm = new GlavniIzbornikForma(idKorisnika);
            GlavniFrm.Show();
            this.Hide();
        }
    }
    
}