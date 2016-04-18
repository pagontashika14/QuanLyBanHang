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
        [WebMethod]
        #region Quản lý danh mục hàng hóa
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void DanhSachLoaiHang()
        {
            try
            {
                var data = Function.DanhMucLoaiHang();
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
                var ma_hang_hoa = Context.Request["ma_hang_hoa"];
                var ten_hang_hoa = Context.Request["ten_hang_hoa"];
                var list_id_loai_tag = Context.Request["list_id_loai_tag"];
                var data = Function.TimKiemHangHoa(ma_hang_hoa, ten_hang_hoa, list_id_loai_tag);
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
        public void TinhTrangKinhDoanhMatHang(decimal id_hang_hoa, DateTime thoi_gian_bat_dau, DateTime thoi_gian_ket_thuc)
        {
            try
            {
                var data = Function.tinh_trang_kinh_doanh(id_hang_hoa, thoi_gian_bat_dau, thoi_gian_ket_thuc);
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
        public void BaoCaoPhanHoiKhachHang(DateTime bat_dau, int so_thang, decimal id_hang_hoa)
        {
            try
            {
                var data = Function.bao_cao_phan_hoi_khach_hang(bat_dau, so_thang, id_hang_hoa);
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
        public void TinhTrangKinhDoanhHangHoa(decimal id_hang_hoa,DateTime bat_dau,DateTime ket_thuc)
        {
            try
            {
                var data = Function.ThongTinKinhDoanhHangHoa(id_hang_hoa, bat_dau, ket_thuc);
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
        public void ThemHangHoa(string list_hang_hoa)
        {
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var listHangHoa = js.Deserialize<List<ThemHangHoa>>(list_hang_hoa);
                Function.ThemHangHoa(listHangHoa);
                var result = new KetQuaTraVe(true, "Thành công", null);
                TraKetQua(result);
            }
            catch (Exception e)
            {
                var result = new KetQuaTraVe(false, e.Message, null);
                TraKetQua(result);
            }
        }
        #endregion
        #region Quản lý khách hàng
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void ChiTietThanhVien(decimal id_thanh_vien)
        {
            try
            {
                var data = Function.ChiTietThanhVien(id_thanh_vien);
                var result = new KetQuaTraVe(true, "Thành công", data);
                TraKetQua(result);
            }
            catch (Exception e)
            {
                var result = new KetQuaTraVe(false, "Thất bại", e.Message);
                TraKetQua(result);
            }
        }
        #endregion

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
