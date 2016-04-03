using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebService3
{
    public class Function
    {
        public const string DANH_MUC_SP = @"DANH_MUC_SAN_PHAM";
        public const string SIZE = @"SIZE_QUAN_AO";
        public const string WEB_PATH = @"d:\DZHosts\LocalUser\pagontashika31\www.quanlybanhang.somee.com\";
        public const string WEB_ADDRESS = @"http://quanlybanhang.somee.com/";
        public static List<LoaiHang> DanhMucMenu()
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
        public static object TimKiemHangHoa(string keyword, int numberOfPage, int page)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var listHH = new List<HangHoaMaster>();
                var dsHangHoa = context.DM_HANG_HOA
                    .Where(s => s.TEN_HANG_HOA.Contains(keyword) || s.MA_HANG_HOA == keyword).ToList();
                var length = dsHangHoa.Count();
                var start = page < length / numberOfPage + 2 ? (page - 1) * numberOfPage : 0;
                var end = start + numberOfPage < length ? start + numberOfPage : 0;
                for (int i = start; i < end; i++)
                {
                    listHH.Add(toHangHoaMaster(dsHangHoa[i]));
                }
                return listHH;
            }
        }
        public static List<HangHoaMaster> TimKiemHangHoa(string list_id_loai_tag)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
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
                return toListHangHoaMaster(listHangHoa);
            }
        }
        static List<HangHoaMaster> toListHangHoaMaster(List<DM_HANG_HOA> dsHangHoa)
        {
            var listHh = new List<HangHoaMaster>();
            foreach (var item in dsHangHoa)
            {
                listHh.Add(toHangHoaMaster(item));
            }
            return listHh;
        }
        static HangHoaMaster toHangHoaMaster(DM_HANG_HOA hh)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
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
                return hhMaster;
            }
        }

        public static decimal layGia(TKHTQuanLyBanHangEntities context, decimal idHh)
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
        public static List<decimal> layHetIDTag(List<decimal> listTag)
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
                hangHoa.luot_xem = context.GD_CLICK_HANG_HOA
                    .Where(s => s.ID_HANG_HOA == id
                             && s.DM_TAI_KHOAN.DM_LOAI_TAI_KHOAN.MA_LOAI == "CUSTOMER")
                    .Count();
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
                //
                return hangHoa;
            }
        }
        public static List<HangHoa> DanhSachHangHoa(decimal id_loai_hang)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var ket_qua = new List<HangHoa>();
                var ket_qua1 = TimKiemHangHoa(id_loai_hang.ToString());
                foreach (var item in ket_qua1)
                {
                    ket_qua.Add(ChiTietHangHoa(item.id));
                }
                return ket_qua;
            }
        }
        public static ThanhVien ChiTietKhachHang(decimal id_thanh_vien)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var thanhVien = new ThanhVien();
                var tv = context.DM_KHACH_HANG.Where(s => s.ID == id_thanh_vien).FirstOrDefault();
                if (tv == null)
                {
                    throw new Exception("Không có thành viên này");
                }
                thanhVien.id = tv.ID;
                thanhVien.ho_dem = tv.DM_TAI_KHOAN.HO_DEM;
                thanhVien.ten = tv.DM_TAI_KHOAN.TEN;
                thanhVien.so_dien_thoai = tv.SO_DIEN_THOAI;
                thanhVien.email = tv.DM_TAI_KHOAN.EMAIL;
                thanhVien.lien_lac = tv.LIEN_LAC;
                thanhVien.ngay_gia_nhap = tv.NGAY_THAM_GIA;
                thanhVien.ten_tai_khoan = tv.DM_TAI_KHOAN.TEN_TAI_KHOAN;
                thanhVien.diem = tv.DIEM;
                thanhVien.tong_tien_da_mua = tv.TONG_TIEN_DA_MUA;
                var listHoaDon = new List<HoaDonMaster>();
                var id_tai_khoan = tv.DM_TAI_KHOAN.ID;
                var dsHoaDon = context.GD_HOA_DON
                    .Where(s => s.ID_TAI_KHOAN == id_tai_khoan)
                    .OrderByDescending(s => s.THOI_GIAN_TAO);
                foreach (var item in dsHoaDon)
                {
                    var hoaDon = new HoaDonMaster();
                    hoaDon.id = item.ID;
                    hoaDon.ngay_mua = item.THOI_GIAN_TAO;
                    var dsHangHoa = item.GD_HOA_DON_CHI_TIET;
                    var hd = new List<HoaDonSimple>();
                    foreach (var hh in dsHangHoa)
                    {
                        var hang = new HoaDonSimple();
                        hang.hang_hoa = toHangHoaMaster(hh.DM_HANG_HOA);
                        hang.id_size = hh.ID_SIZE;
                        hang.so_luong = hh.SO_LUONG;
                        hang.gia_ban = hh.GIA_BAN;
                        hd.Add(hang);
                    }
                    hoaDon.hang_hoa = hd;
                    listHoaDon.Add(hoaDon);
                }
                thanhVien.hoa_don = listHoaDon;
                var dsSanPhamUaThich = context.GD_SAN_PHAM_UA_THICH
                    .Where(s => s.ID_TAI_KHOAN == id_tai_khoan);
                var listSput = new List<HangHoaMaster>();
                foreach (var item in dsSanPhamUaThich)
                {
                    var hh = toHangHoaMaster(item.DM_HANG_HOA);
                    listSput.Add(hh);
                }
                thanhVien.san_pham_ua_thich = listSput;
                var dshhDaXem = context.GD_CLICK_HANG_HOA
                    .Where(s => s.ID_TAI_KHOAN == id_tai_khoan)
                    .GroupBy(s => s.ID_HANG_HOA,
                    (key, g) => new
                    {
                        thoi_gian = g.Max(k => k.THOI_GIAN),
                        hang_hoa = g.FirstOrDefault().DM_HANG_HOA,
                        so_click = g.Count()
                    });
                var listDaXem = new List<HangHoaDaXem>();
                foreach (var item in dshhDaXem)
                {
                    var hhDaXem = new HangHoaDaXem();
                    hhDaXem.thoi_gian = item.thoi_gian;
                    hhDaXem.hang_hoa = toHangHoaMaster(item.hang_hoa);
                    hhDaXem.so_click = item.so_click;
                    listDaXem.Add(hhDaXem);
                }
                thanhVien.hang_hoa_da_xem = listDaXem;
                var dsComment = context.GD_NHAN_XET.Where(s => s.ID_TAI_KHOAN == id_tai_khoan);
                var listComment = new List<CommentMaster>();
                foreach (var item in dsComment)
                {
                    var comment = new CommentMaster();
                    comment.hang_hoa = toHangHoaMaster(item.DM_HANG_HOA);
                    comment.thoi_gian = item.THOI_GIAN;
                    comment.comment = item.NHAN_XET;
                    listComment.Add(comment);
                }
                thanhVien.comment = listComment;
                return thanhVien;
            }
        }
        public static List<ThanhVienMaster> TimKiemThanhVienMuaNhieuNhat(int top)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var dsKh = context.DM_KHACH_HANG.OrderByDescending(s => s.TONG_TIEN_DA_MUA).Take(top);
                return toListThanhVienMaster(dsKh.ToList());
            }
        }
        static List<ThanhVienMaster> toListThanhVienMaster(List<DM_KHACH_HANG> dsKh)
        {
            var listTv = new List<ThanhVienMaster>();
            foreach (var item in dsKh)
            {
                listTv.Add(toThanhVienMaster(item));
            }
            return listTv;
        }
        static ThanhVienMaster toThanhVienMaster(DM_KHACH_HANG kh)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var khach_hang = new ThanhVienMaster();
                khach_hang.id = kh.ID;
                khach_hang.ho_dem = kh.DM_TAI_KHOAN.HO_DEM;
                khach_hang.ten = kh.DM_TAI_KHOAN.TEN;
                khach_hang.ten_tai_khoan = kh.DM_TAI_KHOAN.TEN_TAI_KHOAN;
                khach_hang.email = kh.DM_TAI_KHOAN.EMAIL;
                khach_hang.lien_lac = kh.LIEN_LAC;
                khach_hang.so_dien_thoai = kh.SO_DIEN_THOAI;
                khach_hang.diem = kh.DIEM;
                khach_hang.ngay_gia_nhap = kh.NGAY_THAM_GIA;
                khach_hang.tong_tien_da_mua = kh.TONG_TIEN_DA_MUA;
                return khach_hang;
            }
        }
        public static string upLoadFile(string binary, string file_name)
        {
            var list = new List<byte>();
            foreach (var item in binary.ToArray())
            {
                list.Add(byte.Parse(item.ToString()));
            }
            byte[] bin = list.ToArray();
            var type = file_name.Split('.').Last();
            string path = @"";
            if (type == "jpg" || type == "png")
            {
                path = @"image";
            }
            else if (type == "docx")
            {
                path = @"docx";
            }
            var adr = WEB_PATH + path + @"\" + file_name;
            File.WriteAllBytes(path, bin);
            return WEB_ADDRESS + path + @"/" + file_name;
        }
        public static object TinhTrangKinhDoanh(decimal id_hang_hoa, DateTime bd, DateTime kt)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var ket_qua = new Dictionary<string, object>();
                var list = new List<Dictionary<string, object>>();
                int thang_bd = bd.Month;
                int nam_bd = bd.Year;
                int thang_kt = kt.Month;
                int nam_kt = kt.Year;
                int so_thang = thang_kt - thang_bd + (nam_kt - nam_bd) * 12;
                int nam = nam_bd;
                int thang = thang_bd;
                for (int i = 0; i <= so_thang; i++)
                {
                    list.Add(TinhTrangKinhDoanhMatHangTrongThang(id_hang_hoa, thang, nam));
                    thang++;
                    if (thang % 13 == 0)
                    {
                        thang = 1;
                        nam += 1;
                    }
                }
                return ket_qua;
            }
        }
        public static Dictionary<string, object> TinhTrangKinhDoanhMatHangTrongThang(decimal id_hang_hoa, int thang, int nam)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var ket_qua = new Dictionary<string, object>();
                ket_qua["thang"] = thang;
                ket_qua["nam"] = nam;
                ket_qua["thong_tin_nhap"] = ThongTinNhapXuatHangTrongThang(id_hang_hoa, thang, nam, "N");
                ket_qua["thong_tin_xuat"] = ThongTinNhapXuatHangTrongThang(id_hang_hoa, thang, nam, "X");
                return ket_qua;
            }
        }

        public static object ThongTinNhapXuatHangTrongThang(decimal id_hang_hoa, int thang, int nam, string nhap_or_xuat)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var ket_qua = new Dictionary<string, object>();
                //lay het phieu NHAP trong thang va nam truyen vao
                var p1 = context.GD_PHIEU_NHAP_XUAT.Where(s => s.LOAI_PHIEU == nhap_or_xuat & s.NGAY_NHAP.Month == thang & s.NGAY_NHAP.Year == nam).Select(s => s.ID).ToList();
                //lay het thong tin phieu NHAP trong thang va nam truyen vao va co hang hoa can tim
                var p = context.GD_PHIEU_NHAP_XUAT_CHI_TIET.Where(s => s.ID_HANG_HOA == id_hang_hoa & p1.Contains(s.ID));
                ket_qua["so_luong"] = p.Sum(s => s.SO_LUONG);
                ket_qua["so_tien"] = p.Sum(s => s.SO_LUONG * s.GIA_NHAP_XUAT);
                return ket_qua;
            }
        }
        public static PhieuNhapXuat ThongTinPhieuNhapXuat(decimal id_phieu)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                PhieuNhapXuat kq = new PhieuNhapXuat();
                var p = context.GD_PHIEU_NHAP_XUAT.Where(s => s.ID == id_phieu).FirstOrDefault();
                kq.id = p.ID;
                kq.loai_phieu = p.LOAI_PHIEU;
                kq.ngay_nhap_xuat = p.NGAY_NHAP;
                kq.ma_phieu = p.MA_PHIEU;
                var p1 = p.GD_PHIEU_NHAP_XUAT_CHI_TIET;
                kq.thong_tin_chi_tiet = new List<HoaDonSimple>();
                foreach (var item in p1)
                {
                    HoaDonSimple hds = new HoaDonSimple();
                    hds.hang_hoa = toHangHoaMaster(item.DM_HANG_HOA);
                    hds.gia_ban = item.GIA_NHAP_XUAT;
                    hds.id_size = item.ID_SIZE;
                    hds.so_luong = item.SO_LUONG;
                    kq.thong_tin_chi_tiet.Add(hds);
                }
                return kq;
            }
        }
        public static void ThongTinKinhDoanhHangHoa(decimal id_hang_hoa,DateTime ngayBD,DateTime ngayKT)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var ketQua = new Dictionary<string, object>();
                // gia
                var lGia = new List<Dictionary<string, object>>();
                var dsGia = context.GD_GIA
                    .Where(s => s.ID_HANG_HOA == id_hang_hoa 
                             && s.NGAY_LUU_HANH >= ngayBD
                             && s.NGAY_LUU_HANH < ngayKT);
                foreach (var gia in dsGia)
                {
                    var dic = new Dictionary<string, object>();
                    dic["thoi_gian"] = gia.NGAY_LUU_HANH;
                    dic["gia"] = gia.GIA;
                    lGia.Add(dic);
                }
                ketQua["gia_ban"] = lGia;
                // soLuong

            }
        }
    }
}