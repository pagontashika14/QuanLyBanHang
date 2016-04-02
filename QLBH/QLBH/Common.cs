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
using System.Windows.Forms;
using Facebook;


namespace QLBH
{
    class Common
    {
        public static Image get_image(string link)
        {
            if (String.IsNullOrEmpty(link))
            {
                return Image.FromFile(@"C: \Users\Son Pham\Desktop\quan.jpeg");
            }
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(link);

                using (MemoryStream mem = new MemoryStream(data))
                {
                    return Image.FromStream(mem);
                }

            }
        }

        internal static string download_docx_file_from_link(string mo_ta, string file_name)
        {
                if (String.IsNullOrEmpty(mo_ta))
                {
                    return @"C:\Users\Son Pham\Desktop\New Text Document (3).txt";
                }
                if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    return @"C:\Users\Son Pham\Desktop\New Text Document (3).txt";                
                }
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    client.DownloadFileAsync(new Uri(mo_ta),
                    file_name);
                }
                return file_name;
        }

        public static void exception_handle(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        public static Color lay_mau_theo_ma_mau(string ma_mau_html)
        {
            return ColorTranslator.FromHtml(ma_mau_html);
        }

        
    }
}
