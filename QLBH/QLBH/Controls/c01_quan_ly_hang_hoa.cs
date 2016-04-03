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

namespace QLBH.Controls
{
    public partial class c01_quan_ly_hang_hoa : UserControl
    {
        #region public member
        public c01_danh_muc_hang_hoa v_c01_danh_muc_hang_hoa = new c01_danh_muc_hang_hoa();
        public c01_hang_hoa_chi_tiet v_c01_chi_tiet_hang_hoa = new c01_hang_hoa_chi_tiet();
        #endregion
        #region data binding type
        public List<HangHoa> list_hang_hoa { get; set; }
        public List<HangHoaMaster> list_hang_hoa_master { get; set; }
        public List<LoaiHang> list_loai_hang { get; set; }
        #endregion
        #region public event handler

        #endregion
        #region public method
        public c01_quan_ly_hang_hoa()
        {
            InitializeComponent();
        }

        public c01_quan_ly_hang_hoa(List<LoaiHang> loai_hang)
        {
            InitializeComponent();
            list_loai_hang = loai_hang;
            v_c01_danh_muc_hang_hoa = new c01_danh_muc_hang_hoa(list_loai_hang);
            m_pnl_danh_muc.Controls.Add(v_c01_danh_muc_hang_hoa);
            v_c01_danh_muc_hang_hoa.Dock = DockStyle.Left;
            v_c01_danh_muc_hang_hoa.ButtonHangHoaClick += V_danh_muc_hang_hoa_ButtonHangHoaClick;
        }

        #endregion

        #region event handler

        #endregion

        private void V_danh_muc_hang_hoa_ButtonHangHoaClick(object sender, EventArgs e)
        {
            try
            {
                xtraScrollableControl1.Controls.Clear();
                int id_hang_hoa = Convert.ToInt16(sender);
                HangHoa p = v_c01_danh_muc_hang_hoa.v_list_hang_hoa.Where(s => s.id == id_hang_hoa).First();
                v_c01_chi_tiet_hang_hoa = new c01_hang_hoa_chi_tiet(p);
                // m_tab_page_danh_muc_hang_hoa.Controls.Add(v_c01_chi_tiet_hang_hoa);
                xtraScrollableControl1.Controls.Add(v_c01_chi_tiet_hang_hoa);
                v_c01_chi_tiet_hang_hoa.Dock = DockStyle.Fill;
                v_c01_chi_tiet_hang_hoa.ButtonDeleteClick += V_c_ButtonDeleteClick;
            }
            catch (Exception v_e)
            {
                Common.exception_handle(v_e); 
            }
        }

        private void V_c_ButtonDeleteClick(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception v_e)
            {
                Common.exception_handle(v_e);
            }
        }
    }
}
