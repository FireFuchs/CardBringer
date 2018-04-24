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
    public partial class FormaLogin : Form
    {
        public FormaLogin()
        {
            InitializeComponent();
        }

        private void unosGumbLoginFormaLogin_Click(object sender, EventArgs e)
        {
            FormaPocetnaStranica frmPocetStr = new FormaPocetnaStranica();
            frmPocetStr.ShowDialog();
        }
    }
}
