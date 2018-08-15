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
            if (unosPasswordRegisterLoginRegisterForma.Text != "") return;
            unosPasswordRegisterLoginRegisterForma.Text = "Lozinka";
            unosPasswordRegisterLoginRegisterForma.ForeColor = Color.Gray;
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
        private void unosMjestoStanovanjaRegisterLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosMjestoStanovanjaRegisterLoginRegisterForma.Text != "Mjesto stanovanja") return;
            unosMjestoStanovanjaRegisterLoginRegisterForma.Text = "";
            unosMjestoStanovanjaRegisterLoginRegisterForma.ForeColor = Color.Black;
        }

        private void unosMjestoStanovanjaRegisterLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosMjestoStanovanjaRegisterLoginRegisterForma.Text != "") return;
            unosMjestoStanovanjaRegisterLoginRegisterForma.Text = "Mjesto stanovanja";
            unosMjestoStanovanjaRegisterLoginRegisterForma.ForeColor = Color.Gray;
        }

        private void unosGumbLoginLoginRegisterForma_Click(object sender, EventArgs e)
        {

            var username = unosKorisnickoImeLoginLoginRegisterForma.Text;
            var password = unosPasswordLoginLoginRegisterForma.Text;

            var db = new DbInteraction();
            db.Connection.Open();
            
            var sql = $"SELECT lozinka FROM korisnik WHERE ime = '{username}';";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
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
                    const MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show("Kriva lozinka", "Greška", button);
                }
            }
            else
            {
                const MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Ne postoji taj korisnik", "Greška", button);
            }
            dataReader.Close();
            command.Dispose();
            db.Connection.Close();
        }

        private void unosGumbRegistrirajLoginRegisterForma_Click(object sender, EventArgs e)
        {
           
            var email = unosEmailRegisterLoginRegisterForma.Text;
            var username = unosKorisnickoImeRegisterLoginRegisterForma.Text;
            var password = unosPasswordRegisterLoginRegisterForma.Text;
            var rePassword = unosPonovljeniPasswordRegisterLoginRegisterForma.Text;
            var mjestoStanovanja = unosMjestoStanovanjaRegisterLoginRegisterForma.Text;

            if (password == rePassword)
            {
                var db = new DbInteraction();
                db.Connection.Open();

                var dataAdapter = new SqlDataAdapter();

                // HARDCODIRANO DA JE SAMO KUPAC (idUloga)
                var sql = $"INSERT INTO korisnik (ime, lozinka, email, mjestoStanovanja, idUloga) VALUES('{username}', '{password}', '{email}', '{mjestoStanovanja}', 1);";
                var command = new SqlCommand(sql, db.Connection);
                dataAdapter.InsertCommand = new SqlCommand(sql, db.Connection);
                dataAdapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                db.Connection.Close();
                OtvoriGlavnuFormu(username);
            }
            else
            {
                const MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Lozinke se ne podudaraju", "Greška", button);
            }

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



        // FUNKCIJE

        private void OtvoriGlavnuFormu(string username)
        {
            var db = new DbInteraction();
            db.Connection.Open();
            
            var sql = $"SELECT idKorisnika FROM korisnik WHERE ime = '{username}';";
            var command = new SqlCommand(sql, db.Connection);
            var dataReader = command.ExecuteReader();
            dataReader.Read();
            var idKorisnika = dataReader.GetInt32(0);
            var GlavniFrm = new GlavniIzbornikForma(idKorisnika);
            GlavniFrm.Show();
            this.Hide();

            db.Connection.Close();
        }
    }
    
}