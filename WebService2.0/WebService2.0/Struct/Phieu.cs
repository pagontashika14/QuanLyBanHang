using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService2._0.Struct
{
    public class HoaDon
    {
        GD_HOA_DON hoaDon;
        TKHTQuanLyBanHangEntities context;
        public HoaDon(GD_HOA_DON hd,TKHTQuanLyBanHangEntities con)
        {
            hoaDon = hd;
            context = con;
        }
        public decimal id { get { return hoaDon.ID; } }
        public string ma_hoa_don { get { return hoaDon.MA_HOA_DON; } }
        public decimal id_cua_hang { get { return hoaDon.ID_CUA_HANG; } }
        public decimal? id_tai_khoan { get { return hoaDon.ID_TAI_KHOAN; } }
        public DateTime thoi_gian_tao { get { return hoaDon.THOI_GIAN_TAO; } }
        public string loai_thanh_toan { get { return hoaDon.LOAI_THANH_TOAN; } }
        public List<HoaDonChiTiet> chi_tiet
        {
            get
            {
                var list = new List<HoaDonChiTiet>();
                foreach (var item in hoaDon.GD_HOA_DON_CHI_TIET)
                {
                    list.Add(new HoaDonChiTiet(item,context));
                }
                return list;
            }
        }
    }
    public class HoaDonChiTiet
    {
        GD_HOA_DON_CHI_TIET hoaDon;
        TKHTQuanLyBanHangEntities context;
        public HoaDonChiTiet(GD_HOA_DON_CHI_TIET ct,TKHTQuanLyBanHangEntities con)
        {
            hoaDon = ct;
            context = con;
        }
        public object hang_hoa
        {
            get
            {
                return new HangHoa(hoaDon.DM_HANG_HOA,context).GetDonGian();
            }
        }
        public decimal id_size { get { return hoaDon.ID_SIZE; } }
        public decimal so_luong { get { return hoaDon.SO_LUONG; } }
        public decimal gia_ban
        {
            get
            {
                return hoaDon.GIA_BAN;
            }
        }
    }
    public class PhieuNhapXuat
    {
        GD_PHIEU_NHAP_XUAT phieu;
        TKHTQuanLyBanHangEntities context;
        public PhieuNhapXuat(GD_PHIEU_NHAP_XUAT p,TKHTQuanLyBanHangEntities con)
        {
            phieu = p;
            context = con;
        }
        public decimal id { get { return phieu.ID; } }
        public string ma_phieu { get { return phieu.MA_PHIEU; } }
        public string loai_phieu { get { return phieu.LOAI_PHIEU; } }
        public DateTime ngay_nhap_xuat { get { return phieu.NGAY_NHAP; } }
        public List<PhieuNhapXuatChiTiet> thong_tin_chi_tiet
        {
            get
            {
                var list = new List<PhieuNhapXuatChiTiet>();
                foreach (var item in phieu.GD_PHIEU_NHAP_XUAT_CHI_TIET)
                {
                    list.Add(new PhieuNhapXuatChiTiet(item,context));
                }
                return list;
            }
        }
    }
    public class PhieuNhapXuatChiTiet
    {
        GD_PHIEU_NHAP_XUAT_CHI_TIET phieu;
        TKHTQuanLyBanHangEntities context;
        public PhieuNhapXuatChiTiet(GD_PHIEU_NHAP_XUAT_CHI_TIET ct,TKHTQuanLyBanHangEntities con)
        {
            phieu = ct;
            context = con;
        }
        public object hang_hoa
        {
            get
            {
                return new HangHoa(phieu.DM_HANG_HOA,context).GetDonGian();
            }
        }
        public decimal id_size { get { return phieu.ID_SIZE; } }
        public decimal so_luong { get { return phieu.SO_LUONG; } }
        public decimal gia_nhap_xuat
        {
            get
            {
                return phieu.GIA_NHAP_XUAT;
            }
        }
    }
}