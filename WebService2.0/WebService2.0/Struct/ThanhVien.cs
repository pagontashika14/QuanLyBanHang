using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService2._0.Struct
{
    public class KhachHang
    {
        DM_KHACH_HANG khachHang;
        public KhachHang(DM_KHACH_HANG kh)
        {
            khachHang = kh;
        }
        public object GetDonGian()
        {
            return new
            {
                id,
                ho_dem,
                ten,
                email,
                lien_lac,
                so_dien_thoai,
                ten_tai_khoan
            };
        }
        public decimal id { get { return khachHang.ID; } }
        public string ho_dem { get { return khachHang.DM_TAI_KHOAN.HO_DEM; } }
        public string ten { get { return khachHang.DM_TAI_KHOAN.TEN; } }
        public string so_dien_thoai { get { return khachHang.SO_DIEN_THOAI; } }
        public string email { get { return khachHang.DM_TAI_KHOAN.EMAIL; } }
        public string lien_lac { get { return khachHang.LIEN_LAC; } }
        public DateTime ngay_gia_nhap { get { return khachHang.NGAY_THAM_GIA; } }
        public string ten_tai_khoan { get { return khachHang.DM_TAI_KHOAN.TEN_TAI_KHOAN; } }
        public decimal diem { get { return khachHang.DIEM; } }
        public decimal tong_tien_da_mua { get { return khachHang.TONG_TIEN_DA_MUA; } }
        public List<HoaDon> hoa_don
        {
            get
            {
                using (var context = new TKHTQuanLyBanHangEntities())
                {
                    var list = new List<HoaDon>();
                    var id_tai_khoan = khachHang.DM_TAI_KHOAN.ID;
                    var dsHoaDon = context.GD_HOA_DON
                        .Where(s => s.ID_TAI_KHOAN == id_tai_khoan)
                        .OrderByDescending(s => s.THOI_GIAN_TAO);
                    foreach (var item in dsHoaDon)
                    {
                        list.Add(new HoaDon(item,context));
                    }
                    return list;
                }
            }
        }
        public List<object> san_pham_ua_thich
        {
            get
            {
                using (var context = new TKHTQuanLyBanHangEntities())
                {
                    var id_tai_khoan = khachHang.DM_TAI_KHOAN.ID;
                    var dsSanPhamUaThich = context.GD_SAN_PHAM_UA_THICH
                        .Where(s => s.ID_TAI_KHOAN == id_tai_khoan);
                    var listSput = new List<object>();
                    foreach (var item in dsSanPhamUaThich)
                    {
                        var hh = new HangHoa(item.DM_HANG_HOA,context).GetDonGian();
                        listSput.Add(hh);
                    }
                    return listSput;
                }
            }
        }
        public List<HangHoaDaXem> hang_hoa_da_xem
        {
            get
            {
                using (var context = new TKHTQuanLyBanHangEntities())
                {
                    var id_tai_khoan = khachHang.DM_TAI_KHOAN.ID;
                    var dshhDaXem = context.GD_CLICK_HANG_HOA
                        .Where(s => s.ID_TAI_KHOAN == id_tai_khoan)
                        .GroupBy(s => s.ID_HANG_HOA,
                        (key, g) => new
                        {
                            thoi_gian = g.Max(k => k.THOI_GIAN),
                            hang_hoa = g.FirstOrDefault().DM_HANG_HOA,
                            so_click = g.Count()
                        }).ToList();
                    var listDaXem = new List<HangHoaDaXem>();
                    foreach (var item in dshhDaXem)
                    {
                        var hhDaXem = new HangHoaDaXem();
                        hhDaXem.thoi_gian = item.thoi_gian;
                        hhDaXem.hang_hoa = new HangHoa(item.hang_hoa,context).GetDonGian();
                        hhDaXem.so_click = item.so_click;
                        listDaXem.Add(hhDaXem);
                    }
                    return listDaXem;
                }
            }
        }
        public List<NhanXet> nhan_xet
        {
            get
            {
                using (var context = new TKHTQuanLyBanHangEntities())
                {
                    var id_tai_khoan = khachHang.DM_TAI_KHOAN.ID;
                    var dsComment = context.GD_NHAN_XET.Where(s => s.ID_TAI_KHOAN == id_tai_khoan);
                    var listComment = new List<NhanXet>();
                    foreach (var item in dsComment)
                    {
                        var comment = new NhanXet(item,context);
                        listComment.Add(comment);
                    }
                    return listComment;
                }
            }
        }
    }
    
    public class HangHoaDaXem
    {
        public DateTime thoi_gian { get; set; }
        public object hang_hoa { get; set; }
        public decimal so_click { get; set; }
    }
    public class NhanXet
    {
        TKHTQuanLyBanHangEntities context;
        GD_NHAN_XET nhanXet;
        public NhanXet(GD_NHAN_XET nx,TKHTQuanLyBanHangEntities con)
        {
            nhanXet = nx;
            context = con;
        }
        public object hang_hoa
        {
            get
            {
                return new HangHoa(nhanXet.DM_HANG_HOA,context).GetDonGian();
            }
        }
        public string nhan_xet
        {
            get
            {
                return nhanXet.NHAN_XET;
            }
        }
        public DateTime thoi_gian
        {
            get
            {
                return nhanXet.THOI_GIAN;
            }
        }
    }
    
}