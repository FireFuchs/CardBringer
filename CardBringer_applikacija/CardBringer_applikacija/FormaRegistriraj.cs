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
    public partial class FormaRegistriraj : Form
    {
        public FormaRegistriraj()
        {
            InitializeComponent();
        }

        private void unosGumbRegistrirajFormaRegistriraj_Click(object sender, EventArgs e)
        {
            FormaPocetnaStranica frmPocetStr = new FormaPocetnaStranica();
            frmPocetStr.Show();
            this.Close();
        }

        private void unogGumbPovratakFormaRegistriraj_Click(object sender, EventArgs e)
        {
            PocetnaForma pocetnaFrm = new PocetnaForma();
            pocetnaFrm.Show();
            this.Close();
        }
    }
}
