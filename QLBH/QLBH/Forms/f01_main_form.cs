using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Docking2010;
using QLBH.Forms;
using QLBH.Controls;
using LibraryApi;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraEditors;

namespace QLBH.Forms
{
    public partial class f01_main_form : Form
    {
        #region member
        public static List<LoaiTag> list_loai_tag { get; set; } = new List<LoaiTag>();

        bool v_menu_detail_is_opened;
        public List<XtraTabPage> m_opening_control { get; set; } = new List<XtraTabPage>();

        #endregion
        #region public methods
        public f01_main_form()
        {
            InitializeComponent();
            set_init_form_load();
            format_control();
        }


        #endregion
        #region private methods
        private void format_control()
        {
            m_pnl_status.BackColor = Color.FromArgb(50, Color.White);
            m_tabcontrol_main_view.TabPages.Clear();
        }
        private void set_init_form_load()
        {
            v_menu_detail_is_opened = false;
            set_menu_detail_status();
        }
        private void set_menu_detail_status()
        {
            m_pnl_menu_detail.Visible = v_menu_detail_is_opened;
        }
        #endregion
        #region event handlers
        private void m_btn_open_menu_MouseHover(object sender, EventArgs e)
        {
            m_btn_open_menu.BackColor = Color.Transparent;
        }

        private void m_btn_khach_hang_Click(object sender, EventArgs e)
        {

        }

        private void m_btn_menu_tong_quan_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void m_btn_open_menu_Click(object sender, EventArgs e)
        {
            v_menu_detail_is_opened = !v_menu_detail_is_opened;
            set_menu_detail_status();
        }

        private void m_btn_menu_hang_hoa_Click(object sender, EventArgs e)
        {
            var p = check_exist(typeof(c01_quan_ly_hang_hoa));
            //vtp.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            if (p != null)
            {
                m_tabcontrol_main_view.SelectedTabPage = p;
            }
            else
            {      
                try
                {
                    MyNetwork.GetDanhSachLoaiHang(this, (object data) =>
                    {
                        var loai_hang = (data as LOAI_HANG).Data;
                        XtraTabPage vtp = new XtraTabPage();
                        vtp.Name = typeof(c01_quan_ly_hang_hoa).ToString();
                        m_opening_control.Add(vtp);
                        //
                        c01_quan_ly_hang_hoa v_ql = new c01_quan_ly_hang_hoa(loai_hang);
                        vtp.Controls.Add(v_ql);
                        v_ql.Dock = DockStyle.Fill;
                        vtp.Text = "Quản lý hàng hóa";
                        m_tabcontrol_main_view.TabPages.Add(vtp);
                    });
                }
                catch (Exception)
                {
                    throw;
                }
            }




        }

        private XtraTabPage check_exist(Type type)
        {
            foreach (var item in m_opening_control)
            {
                if (item.Name == type.ToString())
                {
                    return item;
                }

            }
            return null;
        }

        private void m_tabcontrol_main_view_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            m_opening_control.Remove(arg.Page as XtraTabPage);
            m_tabcontrol_main_view.TabPages.Remove(arg.Page as XtraTabPage);
        }

        private void m_btn_menu_tong_quan_MouseHover(object sender, EventArgs e)
        {
            var p = sender as SimpleButton;
            p.BackColor = Common.lay_mau_theo_ma_mau(SystemInfo.ma_mau_da_cam_dep);
        }
    }
}
