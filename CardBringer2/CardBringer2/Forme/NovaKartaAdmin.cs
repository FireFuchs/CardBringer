
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

namespace CardBringer2
{
    public partial class NovaKartaAdmin : Form
    {
        
        public NovaKartaAdmin()
        {
            InitializeComponent();
            HelpClass.TrenutnaForma = 7;
        }
        private string _imgLocation = "";

        private void buttonIzaberiSliku_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _imgLocation = dialog.FileName.ToString();
                pictureBoxSlikaKarte.ImageLocation = _imgLocation;
            }
        }

        private void buttonSpremiKartu_Click(object sender, EventArgs e)
        {
            karta k = new karta();
            k.imeKarte = unosImeKarte.Text;
            k.opisKarte = this.unosOpisKarte.Text;
            k.slikaKarte = AzureStorageKarata.PrenesiSlikuKarte(_imgLocation);
            k.Spremi();
        }
    }
}
