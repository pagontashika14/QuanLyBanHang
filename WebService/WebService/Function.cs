using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Function
    {
        public const string DANH_MUC_SP = @"DANH_MUC_SAN_PHAM";
        #region for hang hoa

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
                    var listTag = Common.TachID(list_id_loai_tag);
                    var listHangHoaTag = context.DM_HANG_HOA.ToList();
                    foreach (var hangHoa in listHangHoaTag)
                    {

                    }

                }
                return null;
            }
        }

        // Private
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
            var listTag = new List<string>();
            foreach (var tag in dsTag)
            {
                listTag.Add(tag.GD_TAG.TEN_TAG);
            }
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
        #endregion
    }
}