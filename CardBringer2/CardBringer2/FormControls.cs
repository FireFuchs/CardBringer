using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace CardBringer2
{
    internal class FormControls
    {
        public static void LoadDatagridView(DataGridView dataGridView, string sql)
        {
            //var db = new DbInteraction();
            //db.Connection.Open();

            
            //var command = new SqlCommand(sql, db.Connection);
            //var dataReader = command.ExecuteReader();
            //var dt = new DataTable();
            //dt.Load(dataReader);
            //dataGridView.AutoGenerateColumns = true;
            //dataGridView.DataSource = dt;
            //dataGridView.Refresh();

            //dataReader.Close();
            //command.Dispose();
            //db.Connection.Close();
        }

        public static MemoryStream DohvatiSlikuKarte(string imgName)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=cardbringerimgs;AccountKey=DkVG4V899EeJr2eAp87jSCuQrTpCUaPWK8xVsInT/NXlVZ9AG5ayu4vCTpNcUnlxYAR2jvXLqs0eln0AlA4TDw==;EndpointSuffix=core.windows.net");    
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("karte");
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(imgName);

            var memoryStream = new MemoryStream();
            blockBlob.DownloadToStream(memoryStream);

            return memoryStream;
        }
    }
}
