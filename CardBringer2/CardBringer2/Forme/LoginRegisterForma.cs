using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using Help;

namespace CardBringer2
{
    public partial class LoginRegisterForma : Form
    {

        readonly GlavniIzbornikForma _glavniFrm = new GlavniIzbornikForma();

        public LoginRegisterForma()
        {
            HelpClass.TrenutnaForma = 4;
            InitializeComponent();
            
        }

        private void LoginRegisterForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var help = new HelpForm();
                help.Show();
            }
        }

        private void UnosGumbGostLoginRegisterForma_Click(object sender, EventArgs e)
        {
            _glavniFrm.Show();
            this.Hide();
        }

        private void Login()
        {
            var username = tboxLoginRegisterKorIme.Text;
            var password = tboxLoginRegisterLozinka.Text;
            

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
            var email = tboxLoginRegisterEmail.Text;
            var username = btnLoginRegisterKorImeReg.Text;
            var password = tboxLoginRegisterFormaLozinkaReg.Text;
            var rePassword = tboxLoginRegisterPonovljenaLozinka.Text;
            var mjestoStanovanja = tboxLoginRegisterMjestoStanovanja.Text;

            // Provjera forme Email adrese, je li napisana kako treba biti
            bool validnaAdresa = IsValidEmail(email);
            if (IsValidEmail(email))
            {
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
            else
            {
                MessageBox.Show("Pogrešna forma E-Maila", "Greška", MessageBoxButtons.OK);
            }
        }

        private void OtvoriGlavnuFormu()
        {
            var glavniFrm = new GlavniIzbornikForma();
            glavniFrm.Show();
            this.Hide();
        }

        private void btnLoginRegisterhelp_Click(object sender, EventArgs e)
        {
            var help = new HelpForm();
            help.Show();
        }

        private void tboxLoginRegisterKorIme_Enter(object sender, EventArgs e)
        {
            if (tboxLoginRegisterKorIme.Text != "Korisnicko Ime") return;
            tboxLoginRegisterKorIme.Text = "";
            tboxLoginRegisterKorIme.ForeColor = Color.Black;
        }

        private void tboxLoginRegisterKorIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void tboxLoginRegisterKorIme_Leave(object sender, EventArgs e)
        {
            if (tboxLoginRegisterKorIme.Text != "") return;
            tboxLoginRegisterKorIme.Text = "Korisnicko Ime";
            tboxLoginRegisterKorIme.ForeColor = Color.Gray;
        }

        private void tboxLoginRegisterLozinka_Enter(object sender, EventArgs e)
        {
            if (tboxLoginRegisterLozinka.Text != "Lozinka") return;
            tboxLoginRegisterLozinka.Text = "";
            tboxLoginRegisterLozinka.ForeColor = Color.Black;
            
            // kada se upisuje password napravi da nisu slova i brojke nego točka
            tboxLoginRegisterLozinka.PasswordChar = '•';
        }

        private void tboxLoginRegisterLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void tboxLoginRegisterLozinka_Leave(object sender, EventArgs e)
        {
            if (tboxLoginRegisterLozinka.Text != "") return;
            tboxLoginRegisterLozinka.Text = "Lozinka";
            tboxLoginRegisterLozinka.ForeColor = Color.Gray;

            // Ako se ne upiše ništa, vraća se u standardni oblik pisma, i nisu više točke
            tboxLoginRegisterLozinka.PasswordChar = '\0';
        }

        private void btnLoginRegisterPrijava_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnLoginRegisterKorImeReg_Enter(object sender, EventArgs e)
        {
            if (btnLoginRegisterKorImeReg.Text != "Korisnicko Ime") return;
            btnLoginRegisterKorImeReg.Text = "";
            btnLoginRegisterKorImeReg.ForeColor = Color.Black;
        }

        private void btnLoginRegisterKorImeReg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void btnLoginRegisterKorImeReg_Leave(object sender, EventArgs e)
        {
            if (btnLoginRegisterKorImeReg.Text != "") return;
            btnLoginRegisterKorImeReg.Text = "Korisnicko Ime";
            btnLoginRegisterKorImeReg.ForeColor = Color.Gray;
        }

        private void tboxLoginRegisterFormaLozinkaReg_Enter(object sender, EventArgs e)
        {
            if (tboxLoginRegisterFormaLozinkaReg.Text != "Lozinka") return;
            tboxLoginRegisterFormaLozinkaReg.Text = "";
            tboxLoginRegisterFormaLozinkaReg.ForeColor = Color.Black;

            // kada se upisuje password napravi da nisu slova i brojke nego točka
            tboxLoginRegisterFormaLozinkaReg.PasswordChar = '•';
        }

        private void tboxLoginRegisterFormaLozinkaReg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void tboxLoginRegisterFormaLozinkaReg_Leave(object sender, EventArgs e)
        {
            if (tboxLoginRegisterFormaLozinkaReg.Text != "") return;
            tboxLoginRegisterFormaLozinkaReg.Text = "Lozinka";
            tboxLoginRegisterFormaLozinkaReg.ForeColor = Color.Gray;
            // Ako se ne upiše ništa, vraća se u standardni oblik pisma, i nisu više točke
            tboxLoginRegisterFormaLozinkaReg.PasswordChar = '\0';
        }

        private void tboxLoginRegisterPonovljenaLozinka_Enter(object sender, EventArgs e)
        {
            if (tboxLoginRegisterPonovljenaLozinka.Text != "Ponovljena Lozinka") return;
            tboxLoginRegisterPonovljenaLozinka.Text = "";
            tboxLoginRegisterPonovljenaLozinka.ForeColor = Color.Black;
            // kada se upisuje password napravi da nisu slova i brojke nego točka
            tboxLoginRegisterPonovljenaLozinka.PasswordChar = '•';
        }

        private void tboxLoginRegisterPonovljenaLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void tboxLoginRegisterPonovljenaLozinka_Leave(object sender, EventArgs e)
        {
            if (tboxLoginRegisterPonovljenaLozinka.Text != "") return;
            tboxLoginRegisterPonovljenaLozinka.Text = "Ponovljena Lozinka";
            tboxLoginRegisterPonovljenaLozinka.ForeColor = Color.Gray;
            // Ako se ne upiše ništa, vraća se u standardni oblik pisma, i nisu više točke
            tboxLoginRegisterPonovljenaLozinka.PasswordChar = '\0';
        }

        private void tboxLoginRegisterMjestoStanovanja_Enter(object sender, EventArgs e)
        {
            if (tboxLoginRegisterMjestoStanovanja.Text != "Mjesto stanovanja") return;
            tboxLoginRegisterMjestoStanovanja.Text = "";
            tboxLoginRegisterMjestoStanovanja.ForeColor = Color.Black;
        }

        private void tboxLoginRegisterMjestoStanovanja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void tboxLoginRegisterMjestoStanovanja_Leave(object sender, EventArgs e)
        {
            if (tboxLoginRegisterMjestoStanovanja.Text != "") return;
            tboxLoginRegisterMjestoStanovanja.Text = "Mjesto stanovanja";
            tboxLoginRegisterMjestoStanovanja.ForeColor = Color.Gray;
        }

        private void btnLoginRegisterRegister_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void tboxLoginRegisterEmail_Enter(object sender, EventArgs e)
        {
            if (tboxLoginRegisterEmail.Text != "E-Mail") return;
            tboxLoginRegisterEmail.Text = "";
            tboxLoginRegisterEmail.ForeColor = Color.Black;
        }

        private void tboxLoginRegisterEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void tboxLoginRegisterEmail_Leave(object sender, EventArgs e)
        {
            if (tboxLoginRegisterEmail.Text != "") return;
            tboxLoginRegisterEmail.Text = "E-Mail";
            tboxLoginRegisterEmail.ForeColor = Color.Gray;
        }
        private bool IsValidEmail(string email)
        {
            
            try
            {
                var addr = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    
}