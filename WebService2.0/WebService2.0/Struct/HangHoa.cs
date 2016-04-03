using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService2._0.Struct
{
    public class HangHoa
    {
        DM_HANG_HOA hangHoa;
        TKHTQuanLyBanHangEntities context;
        public HangHoa(DM_HANG_HOA hh,TKHTQuanLyBanHangEntities ct)
        {
            hangHoa = hh;
            context = ct;
        }
        public object GetDonGian()
        {
            return new
            {
                id,
                ma_hang_hoa,
                ten,
                link_anh,
            };
        }
        public decimal id
        {
            get
            {
                return hangHoa.ID;
            }
        }
        public string ma_hang_hoa
        {
            get
            {
                return hangHoa.MA_HANG_HOA;
            }
        }
        public string ma_vach
        {
            get
            {
                return hangHoa.MA_VACH;
            }
        }
        public string ten
        {
            get
            {
                return hangHoa.TEN_HANG_HOA;
            }
        }
        public string mo_ta
        {
            get
            {
                return hangHoa.MO_TA;
            }
            set
            {
                mo_ta = value;
            }
        }
        public NhaCungCap nha_cung_cap
        {
            get
            {
                var nhaCungCap = new NhaCungCap(hangHoa.DM_NHA_CUNG_CAP);
                return nhaCungCap;
            }
            set
            {
                nha_cung_cap = value;
            }
        }
        public List<string> link_anh
        {
            get
            {
                var link = new List<string>();
                foreach (var item in hangHoa.DM_LINK_ANH)
                {
                    link.Add(item.LINK_ANH);
                }
                return link;
            }
        }
        public List<Tag> ds_tag
        {
            get
            {
                using (var context = new TKHTQuanLyBanHangEntities())
                {
                    var list = new List<Tag>();
                    var id = hangHoa.ID;
                    var dsTag = context.GD_HANG_HOA_TAG.Where(s => s.ID_HANG_HOA == id);
                    foreach (var item in dsTag)
                    {
                        list.Add(new Tag(item.GD_TAG));
                    }
                    return list;
                }
            }
        }
        public decimal gia
        {
            get
            {
                var gia = hangHoa.GD_GIA.OrderByDescending(s => s.NGAY_LUU_HANH).FirstOrDefault();
                if (gia == null)
                {
                    return 0;
                }
                return gia.GIA;
            }
        }
        public decimal khuyen_mai
        {
            get
            {
                using (var context = new TKHTQuanLyBanHangEntities())
                {
                    var toDay = DateTime.Now;
                    var khuyenMai = context.GD_KHUYEN_MAI
                        .Where(s => s.THOI_GIAN_BAT_DAU < toDay && toDay < s.THOI_GIAN_KET_THUC).ToList();
                    decimal kq = 0;
                    foreach (var km in khuyenMai)
                    {
                        var kmai = km.GD_KHUYEN_MAI_CHI_TIET.Where(s => s.ID_HANG_HOA == id).ToList();
                        if (kmai.Count == 0)
                        {
                            continue;
                        }
                        kq = kmai[0].MUC_KHUYEN_MAI;
                    }
                    return kq;
                }
            }
        }
        public decimal luot_xem
        {
            get
            {
                using (var context = new TKHTQuanLyBanHangEntities())
                {
                    var id = hangHoa.ID;
                    return context.GD_CLICK_HANG_HOA.Where(s => s.ID_HANG_HOA == id).Count();
                }
            }
        }
        public decimal diem_danh_gia
        {
            get
            {
                using (var context = new TKHTQuanLyBanHangEntities())
                {
                    var id = hangHoa.ID;
                    var dsDanhGia = context.GD_DANH_GIA
                    .Where(s => s.ID_HANG_HOA == id)
                    .ToList();
                    if (dsDanhGia.Count == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return dsDanhGia.Average(s => s.DIEM);
                    }
                }
            }
        }
        public List<NhanXetHangHoa> nhan_xet
        {
            get
            {
                using (var context = new TKHTQuanLyBanHangEntities())
                {
                    var listNhanXet = new List<NhanXetHangHoa>();
                    var id = hangHoa.ID;
                    var dsNhanXet = context.GD_NHAN_XET.Where(s => s.ID_HANG_HOA == id).ToList();
                    foreach (var item in dsNhanXet)
                    {
                        var nhanXet = new NhanXetHangHoa(item);
                        listNhanXet.Add(nhanXet);
                    }
                    return listNhanXet;
                }
            }
        }
        public List<TonKho> cua_hang
        {
            get
            {
                using (var context = new TKHTQuanLyBanHangEntities())
                {
                    var listCuaHang = new List<TonKho>();
                    var dsCuaHang = context.DM_CUA_HANG.ToList();
                    foreach (var cuaHang in dsCuaHang)
                    {
                        var ch = new TonKho();
                        ch.id_cua_hang = cuaHang.ID;
                        ch.ten_cua_hang = cuaHang.TEN_CUA_HANG;
                        var listSoLuong = new List<SoLuong>();
                        var dsSize = context.DM_LOAI_TAG.Where(s => s.MA_LOAI_TAG == Common.SIZE).First().GD_TAG;
                        foreach (var item in dsSize)
                        {
                            var soLuong = new SoLuong();
                            var idSize = item.ID;
                            soLuong.id_size = idSize;
                            soLuong.ten_size = item.TEN_TAG;
                            var sl = context.GD_TON_KHO
                                .Where(s => s.ID_HANG_HOA == id && s.ID_SIZE == idSize)
                                .ToList();
                            if (sl.Count == 0)
                            {
                                soLuong.so_luong = 0;
                            }
                            else
                            {
                                soLuong.so_luong = sl[0].SO_LUONG_TON_KHO;
                            }
                            listSoLuong.Add(soLuong);
                        }
                        ch.ton_kho = listSoLuong;
                        listCuaHang.Add(ch);
                    }
                    return listCuaHang;
                }
            }
        }
    }
    public class NhaCungCap
    {
        DM_NHA_CUNG_CAP nhaCungCap;
        public NhaCungCap(DM_NHA_CUNG_CAP ncc)
        {
            nhaCungCap = ncc;
        }
        public decimal id
        {
            get
            {
                return nhaCungCap.ID;
            }
            set
            {
                id = value;
            }
        }
        public string ten
        {
            get
            {
                return nhaCungCap.TEN_NHA_CUNG_CAP;
            }
            set
            {
                ten = value;
            }
        }
        public string ten_nguoi_dai_dien
        {
            get
            {
                return nhaCungCap.TEN_NGUOI_DAI_DIEN;
            }
            set
            {
                ten_nguoi_dai_dien = value;
            }
        }
        public string so_dien_thoai
        {
            get
            {
                return nhaCungCap.SO_DIEN_THOAI;
            }
            set
            {
                so_dien_thoai = value;
            }
        }
        public string email
        {
            get
            {
                return nhaCungCap.EMAIL;
            }
            set
            {
                email = value;
            }
        }
    }
    public class Tag
    {
        GD_TAG tag;
        public Tag(GD_TAG t)
        {
            tag = t;
        }
        public decimal id
        {
            get
            {
                return tag.ID;
            }
            set
            {
                id = value;
            }
        }
        public string ma_tag
        {
            get
            {
                return tag.MA_TAG;
            }
            set
            {
                ma_tag = value;
            }
        }
        public string ten_tag
        {
            get
            {
                return tag.TEN_TAG;
            }
            set
            {
                ten_tag = value;
            }
        }
        public string link_anh
        {
            get
            {
                return tag.LINK_ANH;
            }
        }
    }
    public class LoaiTag
    {
        DM_LOAI_TAG loaiTag;
        public LoaiTag(DM_LOAI_TAG lt)
        {
            loaiTag = lt;
        }
        public decimal id
        {
            get
            {
                return loaiTag.ID;
            }
        }
        public string ma_loai_tag
        {
            get
            {
                return loaiTag.MA_LOAI_TAG;
            }
        }
        public string ten_loai_tag
        {
            get
            {
                return loaiTag.TEN_LOAI_TAG;
            }
        }
        public List<Tag> ds_tag
        {
            get
            {
                var list = new List<Tag>();
                foreach (var item in loaiTag.GD_TAG)
                {
                    list.Add(new Tag(item));
                }
                return list;
            }
        }
    }
    public class TonKho
    {
        public decimal id_cua_hang { get; set; }
        public string ten_cua_hang { get; set; }
        public List<SoLuong> ton_kho { get; set; }
    }
    public class SoLuong
    {
        public decimal id_size { get; set; }
        public string ten_size { get; set; }
        public decimal so_luong { get; set; }
    }
    public class NhanXetHangHoa
    {
        GD_NHAN_XET nhanXet;
        public NhanXetHangHoa(GD_NHAN_XET nx)
        {
            nhanXet = nx;
        }
        public string ten_tai_khoan
        {
            get
            {
                using (var context = new TKHTQuanLyBanHangEntities())
                {
                    var id = nhanXet.ID;
                    var nx = context.GD_NHAN_XET.Where(s => s.ID == id).FirstOrDefault().DM_TAI_KHOAN.TEN_TAI_KHOAN;
                    return nx;
                }
            }
        }
        public decimal id_tai_khoan
        {
            get
            {
                return nhanXet.ID_TAI_KHOAN;
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