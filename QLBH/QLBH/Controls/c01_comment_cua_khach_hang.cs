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
    public partial class c01_comment_cua_khach_hang : UserControl
    {
        public NhanXet v_nhan_xet;
        public c01_comment_cua_khach_hang()
        {
            InitializeComponent();
        }

        public void data_to_control()
        {
            m_lbl_user_name.Text = v_nhan_xet.ten_tai_khoan;
            m_lbl_time.Text = v_nhan_xet.thoi_gian.ToString();
            m_txt_comment.Text = v_nhan_xet.nhan_xet;
        }
    }
}
