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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            rtboxHelpFormaHelp.Text = HelpClass.DohvatiHelpTekst();
            rtboxHelpFormaHelp.Select(rtboxHelpFormaHelp.SelectionStart, 0);

        }
    }
}
