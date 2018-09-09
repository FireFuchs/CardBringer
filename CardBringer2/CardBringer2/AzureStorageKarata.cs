using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace CardBringer2
{
   
    internal class AzureStorageKarata
    {
        public static string PrenesiSlikuKarte(string imgLocation)
        {
            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=cardbringerimgs;AccountKey=DkVG4V899EeJr2eAp87jSCuQrTpCUaPWK8xVsInT/NXlVZ9AG5ayu4vCTpNcUnlxYAR2jvXLqs0eln0AlA4TDw==;EndpointSuffix=core.windows.net");

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve reference to a previously created container.
            CloudBlobContainer container = blobClient.GetContainerReference("karte");

            // Retrieve reference to a blob named "myblob".
            var fileExtension = imgLocation.Substring(imgLocation.LastIndexOf('.'));
            var fileName = Guid.NewGuid().ToString();
            var blobName = fileName + fileExtension;
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(blobName);

            // Create or overwrite the blob with contents from a local file.
            using (var fileStream = System.IO.File.OpenRead(imgLocation))
            {
                blockBlob.UploadFromStream(fileStream);
            }

            return blobName;
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
