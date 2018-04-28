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
            GlavniIzbornikForma GlavniFrm = new GlavniIzbornikForma();
            GlavniFrm.Show();
            this.Hide();
        }

        private void unosGumbRegistrirajLoginRegisterForma_Click(object sender, EventArgs e)
        {
            GlavniIzbornikForma GlavniFrm = new GlavniIzbornikForma();
            GlavniFrm.Show();
            this.Hide();
        }

        private void LoginRegisterForma_Load(object sender, EventArgs e)
        {

        }
    }
}
