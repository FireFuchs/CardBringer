
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
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
using Help;

namespace CardBringer2
{
    public partial class NovaKartaAdmin : Form
    {
        
        public NovaKartaAdmin()
        {
            InitializeComponent();
            HelpClass.TrenutnaForma = 7;
            this.KeyPreview = true;
        }
        private string _imgLocation = "";

        private void btnNovaKartaAdminHelp_Click(object sender, EventArgs e)
        {
            Help();
        }

        private void NovaKartaAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help();
            }
        }

        private static void Help()
        {
            var help = new HelpForm();
            help.Show();
        }

        private void btnNovaKartaAdminIzaberiSliku_Click(object sender, EventArgs e)
        {
            // Otvara formu za dodavanje slike karte
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _imgLocation = dialog.FileName.ToString();
                pboxNovaKartaAdminSlikaKarte.ImageLocation = _imgLocation;
            }
        }

        private void btnNovaKartaAdminSpremiKartu_Click(object sender, EventArgs e)
        {
            // Sprema sve upisane podatke u bazu podataka te sliku uploada na Azure Storage
            karta k = new karta();
            k.imeKarte = tboxNovaKartaAdminImeKarte.Text;
            k.opisKarte = this.rtboxNovaKartaAdminOpisKarte.Text;
            k.slikaKarte = AzureStorageKarata.PrenesiSlikuKarte(_imgLocation);
            k.Spremi();
        }
    }
}
