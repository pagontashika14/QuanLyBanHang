using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Function
    {
        public const string DANH_MUC_SP = @"DANH_MUC_SAN_PHAM";
        public const string SIZE = @"SIZE_QUAN_AO";
        public static List<LoaiHang> DanhMucLoaiHang()
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var idLoaiTag = context.DM_LOAI_TAG.Where(s => s.MA_LOAI_TAG == DANH_MUC_SP).First().ID;
                var listDs = new List<LoaiHang>();
                var dsLoaiHang = context.GD_TAG.Where(s => s.ID_LOAI_TAG == idLoaiTag).ToList();
                foreach (var item in dsLoaiHang)
                {
                    var loaiHang = new LoaiHang();
                    loaiHang.id = item.ID;
                    loaiHang.ma_tag = item.MA_TAG;
                    loaiHang.ten_tag = item.TEN_TAG;
                    loaiHang.link_anh = item.LINK_ANH;
                    listDs.Add(loaiHang);
                }
                return listDs;
            }
        }
        public static List<HangHoaMaster> TimKiemHangHoa(string ma_hang_hoa, string ten_hang_hoa, string list_id_loai_tag)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                if (ma_hang_hoa != null && ma_hang_hoa != "")
                {
                    var listHangHoa = context.DM_HANG_HOA.Where(s => s.MA_HANG_HOA == ma_hang_hoa).ToList();
                    return toListHangHoaMaster(context, listHangHoa);
                }
                if (ten_hang_hoa != null && ten_hang_hoa != "")
                {
                    var listHangHoa = context.DM_HANG_HOA.Where(s => s.TEN_HANG_HOA.Contains(ten_hang_hoa)).ToList();
                    return toListHangHoaMaster(context, listHangHoa);
                }
                if (list_id_loai_tag != null && list_id_loai_tag != "")
                {
                    var listHangHoa = new List<DM_HANG_HOA>();
                    var listTag = Common.TachID(list_id_loai_tag);
                    listTag = layHetIDTag(listTag);
                    var dsHangHoa = context.DM_HANG_HOA.ToList();
                    foreach (var hangHoa in dsHangHoa)
                    {
                        var idHangHoa = hangHoa.ID;
                        var hangHoaTag = context.GD_HANG_HOA_TAG
                            .Where(s => s.ID_HANG_HOA == idHangHoa).ToList();
                        var listHhTag = new List<decimal>();
                        foreach (var tag in hangHoaTag)
                        {
                            listHhTag.Add(tag.ID_TAG);
                        }
                        int flag = 1;
                        foreach (var tag in listTag)
                        {
                            if (!listHhTag.Contains(tag))
                            {
                                flag = 0;
                                break;
                            }
                        }
                        if (flag == 0)
                        {
                            continue;
                        }
                        listHangHoa.Add(hangHoa);
                    }
                    return toListHangHoaMaster(context, listHangHoa);
                }
                return null;
            }
        }
        static List<HangHoaMaster> toListHangHoaMaster(TKHTQuanLyBanHangEntities context, List<DM_HANG_HOA> dsHangHoa)
        {
            var listHh = new List<HangHoaMaster>();
            foreach (var item in dsHangHoa)
            {
                listHh.Add(toHangHoaMaster(context, item));
            }
            return listHh;
        }
        static HangHoaMaster toHangHoaMaster(TKHTQuanLyBanHangEntities context, DM_HANG_HOA hh)
        {
            var hhMaster = new HangHoaMaster();
            var id = hh.ID;
            hhMaster.id = id;
            hhMaster.ma_hang_hoa = hh.MA_HANG_HOA;
            hhMaster.ten_hang_hoa = hh.TEN_HANG_HOA;
            hhMaster.nha_san_xuat = hh.DM_NHA_CUNG_CAP.TEN_NHA_CUNG_CAP;
            var listLink = new List<string>();
            var dsLink = context.DM_LINK_ANH.Where(s => s.ID_HANG_HOA == id).ToList();
            foreach (var link in dsLink)
            {
                listLink.Add(link.LINK_ANH);
            }
            hhMaster.ds_link = listLink;
            var dsTag = context.GD_HANG_HOA_TAG.Where(s => s.ID_HANG_HOA == id).ToList();
            var listTag = new List<Tag>();
            foreach (var tag in dsTag)
            {
                var t = new Tag();
                t.id = tag.ID_TAG;
                t.ma_tag = tag.GD_TAG.MA_TAG;
                t.ten_tag = tag.GD_TAG.TEN_TAG;
                listTag.Add(t);
            }
            hhMaster.ds_tag = listTag;
            hhMaster.gia = layGia(context, id);
            hhMaster.chat_lieu = "nil";
            return hhMaster;
        }

        static decimal layGia(TKHTQuanLyBanHangEntities context, decimal idHh)
        {
            var gia = context.GD_GIA.Where(s => s.ID_HANG_HOA == idHh)
                .OrderByDescending(s => s.NGAY_LUU_HANH)
                .ToList();
            if (gia.Count == 0)
            {
                return 0;
            }
            return gia[0].GIA;
        }
        static List<decimal> layHetIDTag(List<decimal> listTag)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var xet = new List<decimal>();
                foreach (var item in listTag)
                {
                    xet.Add(item);
                }
                while (xet.Count > 0)
                {
                    var id = xet[0];
                    var tagCon = context.GD_TAG_CHI_TIET.Where(s => s.ID_TAG_CHA == id).ToList();
                    foreach (var item in tagCon)
                    {
                        if (xet.Contains(item.ID_TAG_CON))
                        {
                            continue;
                        }
                        xet.Add(item.ID_TAG_CON);
                        listTag.Add(item.ID_TAG_CON);
                    }
                    xet.RemoveAt(0);
                }
                return listTag;
            }
        }
        public static List<LoaiTag> LayDanhSachTag()
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var dsloaiTag = context.DM_LOAI_TAG.ToList();
                var listLoaiTag = new List<LoaiTag>();
                foreach (var item in dsloaiTag)
                {
                    var loaiTag = new LoaiTag();
                    loaiTag.id = item.ID;
                    loaiTag.ma_loai_tag = item.MA_LOAI_TAG;
                    loaiTag.ten_loai_tag = item.TEN_LOAI_TAG;
                    var listTag = new List<Tag>();
                    foreach (var item2 in item.GD_TAG)
                    {
                        var tag = new Tag();
                        tag.id = item2.ID;
                        tag.ten_tag = item2.TEN_TAG;
                        tag.ma_tag = item2.MA_TAG;
                        listTag.Add(tag);
                    }
                    loaiTag.ds_tag = listTag;
                    listLoaiTag.Add(loaiTag);

                }
                return listLoaiTag;
            }
        }
        public static HangHoa ChiTietHangHoa(decimal id)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var dsHangHoa = context.DM_HANG_HOA.Where(s => s.ID == id).ToList();
                if (dsHangHoa.Count == 0)
                {
                    return null;
                }
                var hh = dsHangHoa[0];
                var hangHoa = new HangHoa();
                hangHoa.id = hh.ID;
                hangHoa.ma_hang_hoa = hh.MA_HANG_HOA;
                hangHoa.ma_vach = hh.MA_VACH;
                hangHoa.ten = hh.TEN_HANG_HOA;
                hangHoa.gia = layGia(context, id);
                hangHoa.mo_ta = hh.MO_TA;
                var dsDanhGia = context.GD_DANH_GIA
                    .Where(s => s.ID_HANG_HOA == id)
                    .ToList();
                if (dsDanhGia.Count == 0)
                {
                    hangHoa.diem_danh_gia = 0;
                }
                else
                {
                    hangHoa.diem_danh_gia = dsDanhGia.Average(s => s.DIEM);
                }
                hangHoa.luot_xem = context.GD_CLICK_HANG_HOA.Where(s => s.ID_HANG_HOA == id).Count();
                hangHoa.khuyen_mai = 0;
                var toDay = DateTime.Now;
                var khuyenMai = context.GD_KHUYEN_MAI
                    .Where(s => s.THOI_GIAN_BAT_DAU < toDay && toDay < s.THOI_GIAN_KET_THUC).ToList();
                foreach (var km in khuyenMai)
                {
                    var kmai = km.GD_KHUYEN_MAI_CHI_TIET.Where(s => s.ID_HANG_HOA == id).ToList();
                    if (kmai.Count == 0)
                    {
                        continue;
                    }
                    hangHoa.khuyen_mai = kmai[0].MUC_KHUYEN_MAI;
                }
                var nhaCungCap = new NhaCungCap();
                nhaCungCap.id = hh.DM_NHA_CUNG_CAP.ID;
                nhaCungCap.ten = hh.DM_NHA_CUNG_CAP.TEN_NHA_CUNG_CAP;
                nhaCungCap.ten_nguoi_dai_dien = hh.DM_NHA_CUNG_CAP.TEN_NGUOI_DAI_DIEN;
                nhaCungCap.so_dien_thoai = hh.DM_NHA_CUNG_CAP.SO_DIEN_THOAI;
                nhaCungCap.email = hh.DM_NHA_CUNG_CAP.EMAIL;
                hangHoa.nha_cung_cap = nhaCungCap;
                var link = new List<string>();
                foreach (var item in hh.DM_LINK_ANH)
                {
                    link.Add(item.LINK_ANH);
                }
                hangHoa.link_anh = link;
                var dsTag = context.GD_HANG_HOA_TAG.Where(s => s.ID_HANG_HOA == id).ToList();
                var listTag = new List<Tag>();
                foreach (var tag in dsTag)
                {
                    var t = new Tag();
                    t.id = tag.ID_TAG;
                    t.ma_tag = tag.GD_TAG.MA_TAG;
                    t.ten_tag = tag.GD_TAG.TEN_TAG;
                    listTag.Add(t);
                }
                hangHoa.ds_tag = listTag;
                var listNhanXet = new List<NhanXet>();
                var dsNhanXet = context.GD_NHAN_XET.Where(s => s.ID_HANG_HOA == id).ToList();
                foreach (var item in dsNhanXet)
                {
                    var nhanXet = new NhanXet();
                    nhanXet.id = item.ID;
                    nhanXet.id_tai_khoan = item.ID_TAI_KHOAN;
                    nhanXet.ten_tai_khoan = item.DM_TAI_KHOAN.TEN_TAI_KHOAN;
                    nhanXet.nhan_xet = item.NHAN_XET;
                    nhanXet.thoi_gian = item.THOI_GIAN;
                    listNhanXet.Add(nhanXet);
                }
                hangHoa.nhan_xet = listNhanXet;
                var listCuaHang = new List<CuaHang>();
                var dsCuaHang = context.DM_CUA_HANG.ToList();
                foreach (var cuaHang in dsCuaHang)
                {
                    var ch = new CuaHang();
                    ch.id = cuaHang.ID;
                    ch.ten_cua_hang = cuaHang.TEN_CUA_HANG;
                    var listSoLuong = new List<SoLuong>();
                    var dsSize = context.DM_LOAI_TAG.Where(s => s.MA_LOAI_TAG == SIZE).First().GD_TAG;
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
                hangHoa.cua_hang = listCuaHang;
                return hangHoa;
            }
        }
        public static List<HangHoa> lay_danh_sach_hang_hoa_theo_loai_hang_hoa(decimal id_loai_hang)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var ket_qua = new List<HangHoa>();
                var ket_qua1 = TimKiemHangHoa("", "", id_loai_hang.ToString());
                foreach (var item in ket_qua1)
                {
                    ket_qua.Add(ChiTietHangHoa(item.id));
                }
                return ket_qua;
            }
        }
    }
}