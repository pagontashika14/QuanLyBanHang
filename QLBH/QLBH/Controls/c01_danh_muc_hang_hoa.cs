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
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraBars.Docking;


namespace QLBH.Controls
{
    public partial class c01_danh_muc_hang_hoa : UserControl
    {
        #region public member
        public bool is_closing { get; set; }
        //biến a để lúc mới vào ko check sự kiện page select
        private bool a = false;
        public XtraScrollableControl m_xtra_scroll = new XtraScrollableControl();
        public enum State
        {
            IsClosing,
            IsOpening,
        }
        public State m_e_state = State.IsClosing;
        public int max_width = 300;
        public int min_width = 30;
        #endregion

        #region data binding type
        public List<LoaiHang> v_list_loai_hang { get; set; }
        public List<HangHoa> v_list_hang_hoa { get; set; }
        #endregion

        #region public event handler
        public event EventHandler ButtonLoaiHangClick;
        public event EventHandler ButtonHangHoaClick;
        #endregion

        #region public and private method
        public c01_danh_muc_hang_hoa()
        {
            InitializeComponent();
        }

        public c01_danh_muc_hang_hoa(List<LoaiHang> v_list)
        {
            InitializeComponent();
            a = true;
            xtraTabControl1.TabPages.Clear();
            
            foreach (var item in v_list)
            {
                XtraTabPage v_xtra_page = new XtraTabPage();
                //
                v_xtra_page.Text = item.ten_tag;
                v_xtra_page.Tag = item.id;
                v_xtra_page.Image = Common.get_image(item.link_anh);
                v_xtra_page.Appearance.Header.Font = new Font(SystemInfo.font_chu_1, SystemInfo.font_size_1, FontStyle.Regular);
                v_xtra_page.Appearance.Header.ForeColor = Common.lay_mau_theo_ma_mau(SystemInfo.ma_mau_da_cam_dep);
                v_xtra_page.AutoScroll = true;
                //v_xtra_page.MouseLeave += V_xtra_page_MouseLeave;
                xtraTabControl1.TabPages.Add(v_xtra_page);
            }
            //
            this.Width = min_width;
            xtraTabControl1.SelectedTabPage = null;
            //   
            a = false;
        }


        private void V_c_filter_FilterButtonClick(object sender, EventArgs e)
        {
            try
            {
                List<HangHoa> filter_result = new List<HangHoa>();
                var p = sender as List<Tag>;
                foreach (var item in v_list_hang_hoa)
                {
                    if (!match_filter(item,p))
                    {
                        return;
                    }
                    filter_result.Add(item);
                }
                data_list_hang_hoa_to_control(xtraTabControl1.SelectedTabPage, filter_result);
            }
            catch (Exception v_e)
            {
                Common.exception_handle(v_e);
            }
        }
        private bool match_filter(HangHoa v_hang, List<Tag> filter)
        {
            foreach (var item in filter)
            {
                if (!v_hang.ds_tag.Contains(item))
                {
                    return false;
                }
            }        
            return true;
        }
        private List<LoaiTag> get_list_loai_tag()
        {
            List<LoaiTag> v_l = new List<LoaiTag>();
            LoaiTag a1 = new LoaiTag();
            a1.id = 1;
            a1.ten_loai_tag = "Màu sắc";
            v_l.Add(a1);
            LoaiTag a2 = new LoaiTag();
            a2.id = 2;
            a2.ten_loai_tag = "Size";
            v_l.Add(a2);
            LoaiTag a3 = new LoaiTag();
            a3.id = 3;
            a3.ten_loai_tag = "Thương hiệu";
            v_l.Add(a3);
            LoaiTag a4 = new LoaiTag();
            a1.id = 4;
            a1.ten_loai_tag = "Giá";
            v_l.Add(a4);
            return v_l;
        }

        private void data_list_hang_hoa_to_control(XtraTabPage xtra_page, List<HangHoa> v_list_hang_hoa)
        {
            xtra_page.Controls.Clear();
            if (v_list_hang_hoa.Count == 0)
            {
                //them filter
                c01_hang_hoa_filter filter = new c01_hang_hoa_filter(get_list_loai_tag());
                filter.FilterButtonClick += V_c_filter_FilterButtonClick;
                xtra_page.Controls.Add(filter);
                //them search
                c01_search_box search = new c01_search_box();
                xtra_page.Controls.Add(search);
                //
                search.Dock = DockStyle.Top;
                filter.Dock = DockStyle.Top;
                //
                return;
            }
            int i = 0;
            foreach (var item in v_list_hang_hoa)
            {
                if (i % 2 == 0)
                {
                    SimpleButton v_btn = new SimpleButton();
                    v_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
                    v_btn.BackColor = Common.lay_mau_theo_ma_mau(SystemInfo.ma_mau_den_dep);
                    v_btn.Height = 59;
                    v_btn.ForeColor = Common.lay_mau_theo_ma_mau(SystemInfo.ma_mau_da_cam_dep);
                    v_btn.Font = new Font(SystemInfo.font_chu_1, SystemInfo.font_size_1, FontStyle.Regular);
                    
                    xtra_page.Controls.Add(v_btn);
                    v_btn.Dock = DockStyle.Top;
                    //
                    //
                    v_btn.Text = item.ma_hang_hoa + " - " + item.ten;
                    v_btn.Tag = item.id;
                    //
                    v_btn.Click += V_btn_Click;
                }
                else
                {
                    SimpleButton v_btn = new SimpleButton();
                    v_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
                    v_btn.BackColor = Color.WhiteSmoke;
                    v_btn.Height = 59;
                    v_btn.ForeColor = Color.Sienna;
                    v_btn.Font = new Font(SystemInfo.font_chu_1, SystemInfo.font_size_1, FontStyle.Regular);         
                    xtra_page.Controls.Add(v_btn);
                    v_btn.Dock = DockStyle.Top;
                    //
                    //
                    v_btn.Text = item.ma_hang_hoa + " - " + item.ten;
                    v_btn.Tag = item.id;
                    //
                    v_btn.Click += V_btn_Click;
                }
                i++;
            }
            //them filter
            c01_hang_hoa_filter v_c_filter = new c01_hang_hoa_filter(get_list_loai_tag());
            v_c_filter.FilterButtonClick += V_c_filter_FilterButtonClick;
            xtra_page.Controls.Add(v_c_filter);
            //them search
            c01_search_box v_c_search = new c01_search_box();
            xtra_page.Controls.Add(v_c_search);
            //
            v_c_search.Dock = DockStyle.Top;
            v_c_filter.Dock = DockStyle.Top;
            //
        }

        private void add_search_control()
        {
            SearchControl m_sc = new SearchControl();
            
        }

      
        #endregion

        #region event handler

        private void V_btn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal id_hang_hoa = Convert.ToDecimal((sender as SimpleButton).Tag);
                if (this.ButtonHangHoaClick != null)
                {
                    this.ButtonHangHoaClick(id_hang_hoa, e);
                }
            }
            catch (Exception ex)
            {
                Common.exception_handle(ex);
            }
        }

        #endregion

        private void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (a) return;
            try
            {
                int id_loai_hang = Convert.ToInt16(e.Page.Tag);
                MyNetwork.LayDanhSachHangHoaTheoLoaiHangHoa(id_loai_hang, this.TopLevelControl as Form, (object data) =>
                {
                    v_list_hang_hoa = (data as DanhSachHangHoa).Data;
                    data_list_hang_hoa_to_control(e.Page, v_list_hang_hoa);            
                    if (this.ButtonLoaiHangClick != null)
                    {
                        this.ButtonLoaiHangClick(sender, e);
                    }
                });
            }
            catch (Exception ex)
            {
                Common.exception_handle(ex);
            }
        }
      
        private void xtraTabControl1_Selected(object sender, TabPageEventArgs e)
        {
            if (a) return;
            timer1.Start();
            m_e_state = State.IsOpening;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (m_e_state)
            {
                case State.IsClosing:
                    if (this.Width > min_width)
                    {
                        this.Width -= 42;
                    }
                    else
                    {
                        this.Width = min_width;
                        timer1.Stop();
                    }
                    break;
                case State.IsOpening:
                    if (this.Width < max_width)
                    {
                        this.Width += 42;
                    }
                    else
                    {
                        this.Width = max_width;
                        timer1.Stop();
                    }
                    break;
                default:
                    break;
            }
        }
        private void V_xtra_page_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                m_e_state = State.IsClosing;
                timer1.Start();
            }
            catch (Exception v_E)
            {
                Common.exception_handle(v_E);
            }
        }

    }
}
