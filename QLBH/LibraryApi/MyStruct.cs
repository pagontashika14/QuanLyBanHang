using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApi
{
    public class LOAI_HANG
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public LOAI_HANG_CHI_TIET[] Data { get; set; }
    }

    public class LOAI_HANG_CHI_TIET
    {
        public int id { get; set; }
        public string ma_tag { get; set; }
        public string ten_tag { get; set; }
        public string link_anh { get; set; }
    }

}
