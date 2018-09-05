
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
            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=cardbringerimgs;AccountKey=DkVG4V899EeJr2eAp87jSCuQrTpCUaPWK8xVsInT/NXlVZ9AG5ayu4vCTpNcUnlxYAR2jvXLqs0eln0AlA4TDw==;EndpointSuffix=core.windows.net");

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve reference to a previously created container.
            CloudBlobContainer container = blobClient.GetContainerReference("karte");

            // Retrieve reference to a blob named "myblob".
            var fileExtension = _imgLocation.Substring(_imgLocation.LastIndexOf('.'));
            var fileName = Guid.NewGuid().ToString();
            var blobName = fileName + fileExtension;
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(blobName);

            // Create or overwrite the "myblob" blob with contents from a local file.
            using (var fileStream = System.IO.File.OpenRead(_imgLocation))
            {
                blockBlob.UploadFromStream(fileStream);
            }
            

            var karta = new KartaDB();
            karta.imeKarte = this.unosImeKarte.Text;
            karta.opisKarte = this.unosOpisKarte.Text;
            karta.slikaKarte = blobName;
            karta.Spremi();

        }
    }
}
