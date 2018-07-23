using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardBringer2
{   
    public partial class LoginRegisterForma : Form
    {
        Database2DataSetTableAdapters.korisnikTableAdapter korisnikTableAdapter;
        string helpTekst = "pocetna verzija help sustava, probni pokusaj";
        static int idKorisnika = 0;
        public LoginRegisterForma()
        {
            InitializeComponent();
            korisnikTableAdapter = new Database2DataSetTableAdapters.korisnikTableAdapter();
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
            if (unosEmailRegisterLoginRegisterForma.Text == "")
            {
                unosEmailRegisterLoginRegisterForma.Text = "E-Mail";
                unosEmailRegisterLoginRegisterForma.ForeColor = Color.Gray;
            }
        }

        private void unosKorisnickoImeRegisterLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosKorisnickoImeRegisterLoginRegisterForma.Text == "Korisnicko Ime")
            {
                unosKorisnickoImeRegisterLoginRegisterForma.Text = "";
                unosKorisnickoImeRegisterLoginRegisterForma.ForeColor = Color.Black;
            }
        }

        private void unosKorisnickoImeRegisterLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosKorisnickoImeRegisterLoginRegisterForma.Text == "")
            {
                unosKorisnickoImeRegisterLoginRegisterForma.Text = "Korisnicko Ime";
                unosKorisnickoImeRegisterLoginRegisterForma.ForeColor = Color.Gray;
            }
        }

        private void unosPasswordRegisterLoginRegisterForma_Enter(object sender, EventArgs e)
        {
            if (unosPasswordRegisterLoginRegisterForma.Text == "Lozinka")
            {
                unosPasswordRegisterLoginRegisterForma.Text = "";
                unosPasswordRegisterLoginRegisterForma.ForeColor = Color.Black;
            }
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
            if (unosPonovljeniPasswordRegisterLoginRegisterForma.Text == "Ponovljena Lozinka")
            {
                unosPonovljeniPasswordRegisterLoginRegisterForma.Text = "";
                unosPonovljeniPasswordRegisterLoginRegisterForma.ForeColor = Color.Black;
            }
        }

        private void unosPonovljeniPasswordRegisterLoginRegisterForma_Leave(object sender, EventArgs e)
        {
            if (unosPonovljeniPasswordRegisterLoginRegisterForma.Text == "")
            {
                unosPonovljeniPasswordRegisterLoginRegisterForma.Text = "Ponovljena Lozinka";
                unosPonovljeniPasswordRegisterLoginRegisterForma.ForeColor = Color.Gray;
            }
        }

        private void unosGumbLoginLoginRegisterForma_Click(object sender, EventArgs e)
        {
            
            string korIme = unosKorisnickoImeLoginLoginRegisterForma.Text;
            string korLozinka = unosPasswordLoginLoginRegisterForma.Text;
            int loginBroj;
            loginBroj = (int)korisnikTableAdapter.Login(korIme, korLozinka);
            if (loginBroj == 1)
            {

                idKorisnika = (int)korisnikTableAdapter.idReturn(korIme);
                GlavniIzbornikForma GlavniFrm = new GlavniIzbornikForma(idKorisnika);
                GlavniFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Kriva kombinacija Lozinke i Imena", "Greška", button);
            }
        }

        private void unosGumbRegistrirajLoginRegisterForma_Click(object sender, EventArgs e)
        {
            GlavniIzbornikForma GlavniFrm = new GlavniIzbornikForma(idKorisnika);
            GlavniFrm.Show();
            this.Hide();
        }

        private void unosGumbHelpLoginRegisterForma_Click(object sender, EventArgs e)
        {
            HelpClass help = new HelpClass(helpTekst);
        }

        private void LoginRegisterForma_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                HelpClass help = new HelpClass(helpTekst);
            }
        }
        
        private void UnosGumbGostLoginRegisterForma_Click(object sender, EventArgs e)
        {
            GlavniIzbornikForma GlavniFrm = new GlavniIzbornikForma(idKorisnika);
            GlavniFrm.Show();
            this.Hide();
        }

        private void LoginRegisterForma_Load(object sender, EventArgs e)
        {
            


        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
