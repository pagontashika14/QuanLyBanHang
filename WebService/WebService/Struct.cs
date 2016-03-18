using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class LoaiHang
    {
        public decimal id { get; set; }
        public string ma_tag { get; set; }
        public string ten_tag { get; set; }
        public string link_anh { get; set; }
    }
    public class HangHoaMaster
    {
        public decimal id { get; set; }
        public string ma_hang_hoa { get; set; }
        public string ten_hang_hoa { get; set; }
        public string nha_san_xuat { get; set; }
        public string chat_lieu { get; set; }
        public decimal gia { get; set; }
        public List<string> ds_tag { get; set; }
        public List<string> ds_link { get; set; }
    }
}