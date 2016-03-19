using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Drawing.Imaging;
using LibraryApi;
using System.Drawing;


namespace QLBH
{
    class Common
    {
        public static Image get_image(string link)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(link);

                using (MemoryStream mem = new MemoryStream(data))
                {
                    return Image.FromStream(mem);
                }

            }
        }
    }
}
