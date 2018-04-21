using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardBringer_applikacija
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void unosGumbRegistrirajPocetnaForma_Click(object sender, EventArgs e)
        {
            FormaRegistriraj frmRegistriraj = new FormaRegistriraj();
            frmRegistriraj.ShowDialog();
        }

        private void unosGumbLoginPocetnaForma_Click(object sender, EventArgs e)
        {
            FormaLogin frmLogin = new FormaLogin();
            frmLogin.ShowDialog();
        }
    }
}
