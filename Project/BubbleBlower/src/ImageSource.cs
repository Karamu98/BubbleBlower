using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BubbleBlower
{
    internal class ImageSource
    {
        public string DefaultFile = ""; // Fallback, should always be set
        public string? SelectedFile; // Custom image file path
        public string? ExternalURL; // URL to external image
        public string? ImageDestination; // Destination for fetch


        public async Task FetchImage(bool allowDownload, CancellationToken token)
        {
            string dir = Path.GetDirectoryName(ImageDestination);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Is there a selected file
            if(SelectedFile != null && File.Exists(SelectedFile))
            {
                File.Copy(SelectedFile, ImageDestination, true);
            }

            // Emplace the default
            if(!File.Exists(DefaultFile))
            {
                MessageBox.Show($"{ImageDestination} No default image source set.");
            }

            // Is our source online
            if (allowDownload && ExternalURL != null && ExternalURL.StartsWith("http"))
            {
                bool success = await DownloadImageAsync(ExternalURL, ImageDestination, token);
                if (!success)
                {
                    File.Copy(DefaultFile, ImageDestination, true);
                }
            }
            else
            {
                File.Copy(DefaultFile, ImageDestination, true);
            }
        }

        public void CopyTo(string dest)
        {
            if(ImageDestination != null && File.Exists(ImageDestination))
            {
                File.Copy(ImageDestination, dest, true);
            }
        }

        private async Task<bool> DownloadImageAsync(string URL, string imageDestination, CancellationToken cancellationToken)
        {
            try
            {
                byte[]? byteArray = await Program.HttpClient.GetByteArrayAsync(URL, cancellationToken);
                using (FileStream? fileStream = new FileStream(imageDestination, FileMode.Create))
                {
                    await fileStream.WriteAsync(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
