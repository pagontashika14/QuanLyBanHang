using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApi;
using System.IO;
using DevExpress.XtraEditors;
namespace QLBH.Controls
{
    public partial class c01_hang_hoa_chi_tiet : UserControl
    {
        #region public member
        public c01_hinh_anh_minh_hoa v_c01_hinh_anh = new c01_hinh_anh_minh_hoa();
        public c01_mo_ta_hang_hoa v_c01_mo_ta = new c01_mo_ta_hang_hoa();
        public c01_quan_ly_gia_hang_hoa v_c01_quan_ly_gia = new c01_quan_ly_gia_hang_hoa();
        public c01_nhan_xet_khach_hang v_c01_nhan_xet_khach_hang = new c01_nhan_xet_khach_hang();
        public c01_chi_tiet_khuyen_mai v_c01_chi_tiet_khuyen_mai = new c01_chi_tiet_khuyen_mai();
        public c01_tinh_trang_kinh_doanh v_c01_tinh_tinh_trang_kinh_doanh = new c01_tinh_trang_kinh_doanh();
        
        #endregion

        #region data binding type
        public HangHoa v_hang_hoa { get; set; }
        public HangHoaMaster v_hang_hoa_master { get; set; }
        #endregion

        #region public event handler
        public event EventHandler ButtonDeleteClick;
        #endregion

        #region public and private method

        public c01_hang_hoa_chi_tiet()
        {
            InitializeComponent();
        }

        public c01_hang_hoa_chi_tiet(HangHoa v_hh, HangHoaMaster v_hhm)
        {
            InitializeComponent();
            //
            v_hang_hoa = v_hh;
            v_hang_hoa_master = v_hhm;
            //
            get_data_for_member();
            data_to_control();
            data_2_mo_ta();
        }

        public c01_hang_hoa_chi_tiet(HangHoa v_hh)
        {
            InitializeComponent();
            v_hang_hoa = v_hh;
            //
            get_data_for_member();
            data_to_control();
            data_2_mo_ta_v2();
        }

        public void get_data_for_member()
        {
            get_gia_data();
            get_hinh_anh_data();
            get_khuyen_mai_data();
            get_mo_ta_data();
            get_nhan_xet_data();
            get_kinh_doanh_data();
        }

        private void get_khuyen_mai_data()
        {
            v_c01_chi_tiet_khuyen_mai = new c01_chi_tiet_khuyen_mai(v_hang_hoa);
        }
        private void get_hinh_anh_data()
        {
            v_c01_hinh_anh = new c01_hinh_anh_minh_hoa(v_hang_hoa);
        }
        private void get_mo_ta_data()
        {
            v_c01_mo_ta = new c01_mo_ta_hang_hoa(v_hang_hoa);
        }
        private void get_gia_data()
        {
            v_c01_quan_ly_gia = new c01_quan_ly_gia_hang_hoa(v_hang_hoa);
        }
        private void get_kinh_doanh_data()
        {
            v_c01_tinh_tinh_trang_kinh_doanh = new c01_tinh_trang_kinh_doanh(v_hang_hoa);
        }
        private void get_nhan_xet_data()
        {
            v_c01_nhan_xet_khach_hang = new c01_nhan_xet_khach_hang(v_hang_hoa);
        }

        public void data_to_control()
        {
            m_xtra_scroll.Controls.Add(v_c01_hinh_anh);
            m_xtra_scroll.Controls.Add(v_c01_mo_ta);
            m_xtra_scroll.Controls.Add(v_c01_nhan_xet_khach_hang);
            m_xtra_scroll.Controls.Add(v_c01_quan_ly_gia);
            m_xtra_scroll.Controls.Add(v_c01_tinh_tinh_trang_kinh_doanh);
            m_xtra_scroll.Controls.Add(v_c01_chi_tiet_khuyen_mai);
            //
            //v_c01_hinh_anh.Dock = DockStyle.Left;
            //v_c01_mo_ta.Dock = DockStyle.Left;
            //v_c01_nhan_xet_khach_hang.Dock = DockStyle.Left;
            //v_c01_quan_ly_gia.Dock = DockStyle.Left;
            //v_c01_chi_tiet_khuyen_mai.Dock = DockStyle.Left;
            //v_c01_tinh_tinh_trang_kinh_doanh.Dock = DockStyle.Left;
            //
            v_c01_hinh_anh.Dock = DockStyle.Top;
            v_c01_mo_ta.Dock = DockStyle.Top;
            v_c01_nhan_xet_khach_hang.Dock = DockStyle.Top;
            v_c01_quan_ly_gia.Dock = DockStyle.Top;
            v_c01_chi_tiet_khuyen_mai.Dock = DockStyle.Top;
            v_c01_tinh_tinh_trang_kinh_doanh.Dock = DockStyle.Top;
        }

        public void data_2_mo_ta()
        {
            m_lbl_ten_san_pham.Text = v_hang_hoa_master.ten_hang_hoa;
            m_lbl_hang_hoa_master.Text = "Mã sản phẩm: " + v_hang_hoa_master.ma_hang_hoa + " - Xuất xứ : " + v_hang_hoa_master.nha_san_xuat + " - Chất liệu: " + v_hang_hoa_master.chat_lieu;
        }
        public void data_2_mo_ta_v2()
        {
            m_lbl_ten_san_pham.Text = v_hang_hoa.ten;
            m_lbl_hang_hoa_master.Text = "Mã sản phẩm: " + v_hang_hoa.ma_hang_hoa + " - Xuất xứ : " + v_hang_hoa.nha_cung_cap;
        }

        #endregion

        #region event handler
        private void m_btn_xoa_san_pham_Click(object sender, EventArgs e)
        {
            try
            {
                decimal p = v_hang_hoa.id;
                if (this.ButtonDeleteClick != null)
                {
                    this.ButtonDeleteClick(p, e);
                }
            }
            catch (Exception v_E)
            {
                Common.exception_handle(v_E);
            }           
        }
        #endregion
    }
}
