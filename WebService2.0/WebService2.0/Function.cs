using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService2._0.Struct;
using System.IO;

namespace WebService2._0
{
    public class Function
    {
        public static List<Tag> DanhMucMenu()
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var idLoaiTag = context.DM_LOAI_TAG.Where(s => s.MA_LOAI_TAG == Common.DANH_MUC_SP).First().ID;
                var listDs = new List<Tag>();
                var dsLoaiHang = context.GD_TAG.Where(s => s.ID_LOAI_TAG == idLoaiTag).ToList();
                foreach (var item in dsLoaiHang)
                {
                    listDs.Add(new Tag(item));
                }
                return listDs;
            }
        }
        public static object TimKiemHangHoa(string keyword,int numberOfPage,int page)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var listHH = new List<object>();
                var dsHangHoa = context.DM_HANG_HOA
                    .Where(s => s.TEN_HANG_HOA.Contains(keyword) || s.MA_HANG_HOA == keyword).ToList();
                var length = dsHangHoa.Count();
                var start = page < length / numberOfPage + 2 ? (page - 1) * numberOfPage : 0;
                var end = start + numberOfPage < length ? start + numberOfPage : 0;
                for (int i = start; i < end; i++)
                {
                    listHH.Add(new HangHoa(dsHangHoa[i],context).GetDonGian());
                }
                return listHH;
            }
        }
        public static List<object> TimKiemHangHoaTheoTag(string list_tag)
        {
            using(var context = new TKHTQuanLyBanHangEntities())
            {
                var listHangHoa = new List<DM_HANG_HOA>();
                var listTag = Common.TachID(list_tag);
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
                var kq = new List<object>();
                foreach (var item in listHangHoa)
                {
                    kq.Add(new HangHoa(item,context).GetDonGian());
                }
                return kq;
            }
        }
        public static List<HangHoa> DanhSachHangHoa(decimal id_loai_hang)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var listHangHoa = new List<DM_HANG_HOA>();
                var listTag = Common.TachID(id_loai_hang.ToString());
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
                var kq = new List<HangHoa>();
                foreach (var item in listHangHoa)
                {
                    kq.Add(new HangHoa(item,context));
                }
                return kq;
            }
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
                    listLoaiTag.Add(new LoaiTag(item));
                }
                return listLoaiTag;
            }
        }
        public static HangHoa ChiTietHangHoa(decimal id)
        {
            using(var context = new TKHTQuanLyBanHangEntities())
            {
                var hangHoa = context.DM_HANG_HOA.Where(s => s.ID == id).FirstOrDefault();
                if (hangHoa==null)
                {
                    throw new Exception("Không có loại hàng hóa này");
                }
                return new HangHoa(hangHoa,context);
            }
        }
        public static KhachHang ChiTietKhachHang(decimal id)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var kh = context.DM_KHACH_HANG.Where(s => s.ID == id).FirstOrDefault();
                if (kh == null)
                {
                    throw new Exception("Không có tài khoản này");
                }
                return new KhachHang(kh);
            }
        }
        public static List<object> TimKiemThanhVienMuaNhieuNhat(int top)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var dsKh = context.DM_KHACH_HANG.OrderByDescending(s => s.TONG_TIEN_DA_MUA).Take(top);
                var list = new List<object>();
                foreach (var item in dsKh)
                {
                    list.Add(new KhachHang(item).GetDonGian());
                }
                return list;
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
            var adr = Common.WEB_PATH + path + @"\" + file_name;
            File.WriteAllBytes(path, bin);
            return Common.WEB_ADDRESS + path + @"/" + file_name;
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
                    list.Add(TinhTrangKinhDoanhTrongThang(id_hang_hoa, thang, nam));
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
        public static Dictionary<string, object> TinhTrangKinhDoanhTrongThang(decimal id_hang_hoa, int thang, int nam)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var ket_qua = new Dictionary<string, object>();
                ket_qua["thang"] = thang;
                ket_qua["nam"] = nam;
                ket_qua["thong_tin_nhap"] = ThongTinNhapXuatTrongThang(id_hang_hoa, thang, nam, "N");
                ket_qua["thong_tin_xuat"] = ThongTinNhapXuatTrongThang(id_hang_hoa, thang, nam, "X");
                return ket_qua;
            }
        }
        public static object ThongTinNhapXuatTrongThang(decimal id_hang_hoa, int thang, int nam, string nhap_or_xuat)
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
        public static PhieuNhapXuat thong_tin_phieu_nhap_xuat(decimal id_phieu)
        {
            using (var context = new TKHTQuanLyBanHangEntities())
            {
                var p = context.GD_PHIEU_NHAP_XUAT.Where(s => s.ID == id_phieu).FirstOrDefault();
                
                return new PhieuNhapXuat(p,context);
            }
        }
    }
}