using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService2._0
{
    public class KetQuaTraVe
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public KetQuaTraVe(bool ip_b_trang_thai, string ip_str_trang_thai, object ip_data)
        {
            Success = ip_b_trang_thai;
            Message = ip_str_trang_thai;
            Data = ip_data;
        }
    }
}