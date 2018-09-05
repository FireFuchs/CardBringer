
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
using CardBringer2.Database;

namespace CardBringer2
{
    public partial class NovaKartaAdmin : Form
    {
        
        public NovaKartaAdmin()
        {
            InitializeComponent();
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
            var karta = new KartaDB();
            karta.imeKarte = this.unosImeKarte.Text;
            karta.opisKarte = this.unosOpisKarte.Text;
            karta.slikaKarte = AzureStorageKarata.PrenesiSlikuKarte(_imgLocation);
            karta.Spremi();
        }
    }
}
