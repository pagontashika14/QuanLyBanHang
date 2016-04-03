using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService3
{
    public class ThanhVien
    {
        public decimal id { get; set; }
        public string ho_dem { get; set; }
        public string ten { get; set; }
        public string so_dien_thoai { get; set; }
        public string email { get; set; }
        public string lien_lac { get; set; }
        public DateTime ngay_gia_nhap { get; set; }
        public string ten_tai_khoan { get; set; }
        public decimal diem { get; set; }
        public decimal tong_tien_da_mua { get; set; }
        public List<HoaDonMaster> hoa_don { get; set; }
        public List<HangHoaMaster> san_pham_ua_thich { get; set; }
        public List<HangHoaDaXem> hang_hoa_da_xem { get; set; }
        public List<CommentMaster> comment { get; set; }
    }
    public class HoaDonMaster
    {
        public decimal id { get; set; }
        public DateTime ngay_mua { get; set; }
        public List<HoaDonSimple> hang_hoa { get; set; }
    }
    public class HoaDonSimple
    {
        public HangHoaMaster hang_hoa { get; set; }
        public decimal id_size { get; set; }
        public decimal so_luong { get; set; }
        public decimal gia_ban { get; set; }
    }
    public class HangHoaDaXem
    {
        public DateTime thoi_gian { get; set; }
        public HangHoaMaster hang_hoa { get; set; }
        public decimal so_click { get; set; }
    }
    public class CommentMaster
    {
        public HangHoaMaster hang_hoa { get; set; }
        public string comment { get; set; }
        public DateTime thoi_gian { get; set; }
    }
    public class PhieuNhapXuat
    {
        public decimal id { get; set; }
        public string ma_phieu { get; set; }
        public string loai_phieu { get; set; }
        public DateTime ngay_nhap_xuat { get; set; }
        public List<HoaDonSimple> thong_tin_chi_tiet { get; set; }
    }

    public class ThanhVienMaster
    {
        public decimal id { get; set; }
        public string ho_dem { get; set; }
        public string ten { get; set; }
        public string so_dien_thoai { get; set; }
        public string email { get; set; }
        public string lien_lac { get; set; }
        public DateTime ngay_gia_nhap { get; set; }
        public string ten_tai_khoan { get; set; }
        public decimal diem { get; set; }
        public decimal tong_tien_da_mua { get; set; }
    }
}