using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

namespace WebService3
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class QLBanHang : System.Web.Services.WebService
    {

        void TraKetQua(KetQuaTraVe result)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.Write(js.Serialize(result));
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void HelloName(string first_name)
        {
            string last_name = Context.Request["last_name"];
            string name = first_name + " " + last_name;
            var result = new KetQuaTraVe(true, "Thành công", "Xin chào " + name);
            TraKetQua(result);
        }
        public void DanhSachLoaiHang()
        {
            try
            {
                var data = Function.DanhMucMenu();
                var result = new KetQuaTraVe(true, "Thành công", data);
                TraKetQua(result);
            }
            catch (Exception e)
            {
                var result = new KetQuaTraVe(false, "Thất bại", e.Message);
                TraKetQua(result);
            }
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void TimKiemHangHoa()
        {
            try
            {
                var key_search = Context.Request["tim_kiem"];
                var list_id_loai_tag = Context.Request["list_tag"];
                int length = Context.Request["length"] == null ? 20 : int.Parse(Context.Request["length"]);
                int page = Context.Request["page"] == null ? 1 : int.Parse(Context.Request["page"]);
                object data;
                if (key_search != null)
                {
                    data = Function.TimKiemHangHoa(key_search, length, page);
                }
                else
                {
                    data = Function.TimKiemHangHoa(list_id_loai_tag);
                }
                var result = new KetQuaTraVe(true, "Thành công", data);
                TraKetQua(result);
            }
            catch (Exception e)
            {
                var result = new KetQuaTraVe(false, "Thất bại", e.Message);
                TraKetQua(result);
            }
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void DanhSachLoaiTag()
        {
            try
            {
                var data = Function.LayDanhSachTag();
                var result = new KetQuaTraVe(true, "Thành công", data);
                TraKetQua(result);
            }
            catch (Exception e)
            {
                var result = new KetQuaTraVe(false, "Thất bại", e.Message);
                TraKetQua(result);
            }
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void ChiTietHangHoa(decimal id_hang_hoa)
        {
            try
            {
                var data = Function.ChiTietHangHoa(id_hang_hoa);
                var result = new KetQuaTraVe(true, "Thành công", data);
                TraKetQua(result);
            }
            catch (Exception e)
            {
                var result = new KetQuaTraVe(false, "Thất bại", e.Message);
                TraKetQua(result);
            }
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void LayDanhSachHangHoaTheoLoaiHangHoa(decimal id_loai_hang_hoa)
        {
            try
            {
                var data = Function.DanhSachHangHoa(id_loai_hang_hoa);
                var result = new KetQuaTraVe(true, "Thành công", data);
                TraKetQua(result);
            }
            catch (Exception e)
            {
                var result = new KetQuaTraVe(false, "Thất bại", e.Message);
                TraKetQua(result);
            }
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void ChiTietThanhVien(decimal id_thanh_vien)
        {
            try
            {
                var data = Function.ChiTietKhachHang(id_thanh_vien);
                var result = new KetQuaTraVe(true, "Thành công", data);
                TraKetQua(result);
            }
            catch (Exception e)
            {
                var result = new KetQuaTraVe(false, "Thất bại", e.Message);
                TraKetQua(result);
            }
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void TinhTrangKinhDoanhMatHang(decimal id_hang_hoa, DateTime thoi_gian_bat_dau, DateTime thoi_gian_ket_thuc)
        {
            try
            {
                var data = Function.TinhTrangKinhDoanh(id_hang_hoa, thoi_gian_bat_dau, thoi_gian_ket_thuc);
                var result = new KetQuaTraVe(true, "Thành công", data);
                TraKetQua(result);
            }
            catch (Exception e)
            {
                var result = new KetQuaTraVe(false, "Thất bại", e.Message);
                TraKetQua(result);
            }
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void UploadFile(string binary, string file_name)
        {
            try
            {
                var data = Function.upLoadFile(binary, file_name);
                var result = new KetQuaTraVe(true, "Thành công", data);
                TraKetQua(result);
            }
            catch (Exception e)
            {
                var result = new KetQuaTraVe(false, "Thất bại", e.Message);
                TraKetQua(result);
            }
        }
    }
}
