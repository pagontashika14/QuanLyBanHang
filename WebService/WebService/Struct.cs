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
        public List<Tag> ds_tag { get; set; }
        public List<string> ds_link { get; set; }
    }
    public class Tag
    {
        public decimal id { get; set; }
        public string ma_tag { get; set; }
        public string ten_tag { get; set; }
    }
    public class LoaiTag
    {
        public decimal id { get; set; }
        public string ma_loai_tag { get; set; }
        public string ten_loai_tag { get; set; }
        public List<Tag> ds_tag { get; set; }
    }
    public class HangHoa
    {
        public decimal id { get; set; }
        public string ma_hang_hoa { get; set; }
        public string ma_vach { get; set; }
        public string ten { get; set; }
        public string mo_ta { get; set; }
        public NhaCungCap nha_cung_cap { get; set; }
        public List<string> link_anh { get; set; }
        public List<Tag> ds_tag { get; set; }
        public decimal gia { get; set; }
        public decimal khuyen_mai { get; set; }
        public decimal luot_xem { get; set; }
        public decimal diem_danh_gia { get; set; }
        public List<NhanXet> nhan_xet { get; set; }
        public List<CuaHang> cua_hang { get; set; }
    }
    public class NhaCungCap
    {
        public decimal id { get; set; }
        public string ten { get; set; }
        public string ten_nguoi_dai_dien { get; set; }
        public string so_dien_thoai { get; set; }
        public string email { get; set; }
    }
    public class CuaHang
    {
        public decimal id { get; set; }
        public string ten_cua_hang { get; set; }
        public List<SoLuong> ton_kho { get; set; }
    }
    public class SoLuong
    {
        public decimal id_size { get; set; }
        public string ten_size { get; set; }
        public decimal so_luong { get; set; }
    }
    public class NhanXet
    {
        public decimal id { get; set; }
        public decimal id_tai_khoan { get; set; }
        public string ten_tai_khoan { get; set; }
        public string nhan_xet { get; set; }
        public DateTime thoi_gian { get; set; }
    }
}