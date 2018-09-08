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
        readonly string _helpTekst = "pocetna verzija help sustava, probni pokusaj";

        readonly GlavniIzbornikForma _glavniFrm = new GlavniIzbornikForma();

        public LoginRegisterForma()
        {
            InitializeComponent();
            
        }

        private void unosKorisnickoImeLoginLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosKorisnickoImeLoginLoginRegisterForma.Text != "Korisnicko Ime") return;
            unosKorisnickoImeLoginLoginRegisterForma.Text = "";
            unosKorisnickoImeLoginLoginRegisterForma.ForeColor = Color.Black;
        }

        private void unosKorisnickoImeLoginLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosKorisnickoImeLoginLoginRegisterForma.Text != "") return;
            unosKorisnickoImeLoginLoginRegisterForma.Text = "Korisnicko Ime";
            unosKorisnickoImeLoginLoginRegisterForma.ForeColor = Color.Gray;
        }

        private void unosPasswordLoginLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosPasswordLoginLoginRegisterForma.Text != "Lozinka") return;
            unosPasswordLoginLoginRegisterForma.Text = "";
            unosPasswordLoginLoginRegisterForma.ForeColor = Color.Black;
            unosPasswordLoginLoginRegisterForma.PasswordChar = '•';
        }

        private void unosPasswordLoginLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosPasswordLoginLoginRegisterForma.Text != "") return;
            unosPasswordLoginLoginRegisterForma.Text = "Lozinka";
            unosPasswordLoginLoginRegisterForma.ForeColor = Color.Gray;
            unosPasswordLoginLoginRegisterForma.PasswordChar = '\0';
        }

        private void unosEmailRegisterLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosEmailRegisterLoginRegisterForma.Text != "E-Mail") return;
            unosEmailRegisterLoginRegisterForma.Text = "";
            unosEmailRegisterLoginRegisterForma.ForeColor = Color.Black;
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
            unosPasswordRegisterLoginRegisterForma.PasswordChar = '•';
        }

        private void unosPasswordRegisterLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosPasswordRegisterLoginRegisterForma.Text != "") return;
            unosPasswordRegisterLoginRegisterForma.Text = "Lozinka";
            unosPasswordRegisterLoginRegisterForma.ForeColor = Color.Gray;
            unosPasswordRegisterLoginRegisterForma.PasswordChar = '\0';
        }

        private void unosPonovljeniPasswordRegisterLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosPonovljeniPasswordRegisterLoginRegisterForma.Text != "Ponovljena Lozinka") return;
            unosPonovljeniPasswordRegisterLoginRegisterForma.Text = "";
            unosPonovljeniPasswordRegisterLoginRegisterForma.ForeColor = Color.Black;
            unosPonovljeniPasswordRegisterLoginRegisterForma.PasswordChar = '•';
        }

        private void unosPonovljeniPasswordRegisterLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosPonovljeniPasswordRegisterLoginRegisterForma.Text != "") return;
            unosPonovljeniPasswordRegisterLoginRegisterForma.Text = "Ponovljena Lozinka";
            unosPonovljeniPasswordRegisterLoginRegisterForma.ForeColor = Color.Gray;
            unosPonovljeniPasswordRegisterLoginRegisterForma.PasswordChar = '\0';
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
            Login();

        }

        private void unosGumbRegistrirajLoginRegisterForma_Click(object sender, EventArgs e)
        {

            Register();

        }

        private void unosGumbHelpLoginRegisterForma_Click(object sender, EventArgs e)
        {
            var help = new HelpClass(_helpTekst);
        }

        private void LoginRegisterForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var help = new HelpClass(_helpTekst);
            }
        }

        private void UnosGumbGostLoginRegisterForma_Click(object sender, EventArgs e)
        {
            _glavniFrm.Show();
            this.Hide();
        }

        private void unosKorisnickoImeLoginLoginRegisterForma_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void unosPasswordLoginLoginRegisterForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void unosEmailRegisterLoginRegisterForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void unosKorisnickoImeRegisterLoginRegisterForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void unosPasswordRegisterLoginRegisterForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void unosPonovljeniPasswordRegisterLoginRegisterForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void unosMjestoStanovanjaRegisterLoginRegisterForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void Login()
        {
            var username = unosKorisnickoImeLoginLoginRegisterForma.Text;
            var password = unosPasswordLoginLoginRegisterForma.Text;
            

            if (korisnik.Prijava(username, password) != null)
            {
                OtvoriGlavnuFormu();
                return;
            }
            const MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show("Ne postoji taj korisnik", "Greška", button);
        }

        private void Register()
        {
            var email = unosEmailRegisterLoginRegisterForma.Text;
            var username = unosKorisnickoImeRegisterLoginRegisterForma.Text;
            var password = unosPasswordRegisterLoginRegisterForma.Text;
            var rePassword = unosPonovljeniPasswordRegisterLoginRegisterForma.Text;
            var mjestoStanovanja = unosMjestoStanovanjaRegisterLoginRegisterForma.Text;

            if (password == rePassword)
            {
                korisnik k = new korisnik();
                k.ime = username;
                k.lozinka = password;
                k.email = email;
                k.mjestoStanovanja = mjestoStanovanja;
                k.idUloga = 1;
                if (k.Registracija() == null)
                {
                    MessageBox.Show("Korisničko ime ili E-Mail je zauzet!", "Greška", MessageBoxButtons.OK);
                    return;
                }
                OtvoriGlavnuFormu();
            }
            else
            {
                MessageBox.Show("Lozinke se ne podudaraju", "Greška", MessageBoxButtons.OK);
            }
        }

        private void OtvoriGlavnuFormu()
        {
            var glavniFrm = new GlavniIzbornikForma();
            glavniFrm.Show();
            this.Hide();
        }

        private void unosPasswordLoginLoginRegisterForma_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}