﻿using System;
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
    public partial class GlavniIzbornikForma : Form
    {
        string helpTekst = "Help glavne forme";

        public GlavniIzbornikForma()
        {
            InitializeComponent();
        }
        

        private void GlavniIzbornikForma_KeyDown(object sender, KeyEventArgs e)
        {
            HelpClass help = new HelpClass(helpTekst);
        }

        private void unosGumbHelpGlavniIzbornikForma_Click(object sender, EventArgs e)
        {
            HelpClass help = new HelpClass(helpTekst);

        }
    }
}
