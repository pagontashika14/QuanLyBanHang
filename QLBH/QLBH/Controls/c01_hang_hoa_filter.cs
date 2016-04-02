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
    public partial class c01_hang_hoa_filter : UserControl
    {
        public List<LoaiTag> v_list_loai_tag { get; set; } = new List<LoaiTag>();
        public List<Tag> v_list_tag { get; set; } = new List<LibraryApi.Tag>();
        public int max_height;
        public event EventHandler FilterButtonClick;
        public enum ControlState
        {
            IsClosing,
            IsOpenning,
        }
        private ControlState m_e_state = ControlState.IsOpenning;

        public c01_hang_hoa_filter()
        {
            InitializeComponent();
        }

        public c01_hang_hoa_filter(List<LoaiTag> ip_loai_tag)
        {
            InitializeComponent();
            //
            this.Height = panelControl1.Height;
            m_xtra_scroll.Controls.Clear();
            //
            this.v_list_loai_tag = ip_loai_tag;
            foreach (var item in v_list_loai_tag)
            {
                c01_tag_filter_element v_c = new c01_tag_filter_element(item);
                m_xtra_scroll.Controls.Add(v_c);
                v_c.Dock = DockStyle.Top;
                v_c.FilterValueChanged += V_c_FilterValueChanged;
                max_height += v_c.Height;
                if (max_height < 250)
                {
                    max_height = 250;
                }
            }
        }


        private void Button_Hover(object sender, EventArgs e)
        {
            if (this.Height <= panelControl1.Height)
            {
                return;
            }
            else
            {
                timer1.Start();
                m_e_state = ControlState.IsOpenning;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (m_e_state)
            {
                case ControlState.IsClosing:
                    if (this.Height > panelControl1.Height)
                    {
                        this.Height -= 42;
                    }
                    else
                    {
                        this.Height = panelControl1.Height;
                        timer1.Stop();
                    }
                    break;
                case ControlState.IsOpenning:
                    if (this.Height < max_height)
                    {
                        this.Height += 42;
                    }
                    else
                    {
                        this.Height = max_height;
                        timer1.Stop();
                    }
                    break;
                default:
                    break;
            }
        }

        private void m_btn_loc_Click(object sender, EventArgs e)
        {
            try
            {
                if (v_list_tag.Count == 0)
                {
                    return;
                }
                if (this.FilterButtonClick != null)
                {
                    this.FilterButtonClick(v_list_tag, e);
                }
            }
            catch (Exception v_e)
            {
                Common.exception_handle(v_e);
            }
        }

        private void get_filter_Tag()
        {
            throw new NotImplementedException();
        }

        private void m_btn_xem_bo_loc_Click(object sender, EventArgs e)
        {
            if (this.Height > panelControl1.Height)
            {
                m_e_state = ControlState.IsClosing;
                timer1.Start();
            }
            else
            {
                m_e_state = ControlState.IsOpenning;
                timer1.Start();
            }
        }
        private void V_c_FilterValueChanged(object sender, EventArgs e)
        {
            try
            {
                LibraryApi.Tag tag = sender as Tag;
                foreach (var item in v_list_tag)
                {
                    if (item == tag)
                    {
                        return;
                    }
                }
                v_list_tag.Add(tag);
            }
            catch (Exception v_e)
            {
                Common.exception_handle(v_e);
            }
        }
    }
}

