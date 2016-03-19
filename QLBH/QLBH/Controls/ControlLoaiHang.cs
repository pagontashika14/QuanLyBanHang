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

namespace QLBH
{
    public partial class ControlLoaiHang : UserControl
    {
        public ControlLoaiHang()
        {
            InitializeComponent();
            //BackColor = Color.FromArgb(5, Color.BlanchedAlmond);
        }

       
        internal void get_thong_tin(LOAI_HANG_CHI_TIET item)
        {
            this.simpleButton1.Text= item.ten_tag;
            this.simpleButton1.Image = Common.get_image(item.link_anh);
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
