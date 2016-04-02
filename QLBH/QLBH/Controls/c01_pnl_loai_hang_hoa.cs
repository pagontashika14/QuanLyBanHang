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
    public partial class c01_pnl_loai_hang_hoa : UserControl
    {
        #region public member
        #endregion
        #region data binding type
        public LoaiHang loai_hang { get; set; } = new LoaiHang();
        #endregion
        #region public event handler
        public event EventHandler ButtonClick;
        #endregion
        #region public method

        #endregion
        #region event handler

        #endregion
        public c01_pnl_loai_hang_hoa()
        {
            InitializeComponent();
        }
        public void get_thong_tin(LoaiHang lh)
        {
            loai_hang = lh;
            data_to_control();
        }

        private void data_to_control()
        {
            simpleButton1.Text = loai_hang.ten_tag;
            simpleButton1.Image = Common.get_image(loai_hang.link_anh);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
