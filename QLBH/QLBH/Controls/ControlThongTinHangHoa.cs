using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Controls
{
    public partial class ControlThongTinHangHoa : UserControl
    {
        #region Properties
        public ControlThongTinHangHoa()
        {
            InitializeComponent();
            timer_doi_hinh_anh.Start();
        }

        public void get_thong_tin(HangHoaMaster hang_hoa)
        {
            lbl_ma_hang.Text += hang_hoa.ma_hang_hoa;
            lbl_ten_san_pham.Text += hang_hoa.ten_hang_hoa;
            lbl_chat_lieu.Text += hang_hoa.chat_lieu;
            lbl_gia.Text += hang_hoa.gia;
            lbl_nha_san_xuat.Text += hang_hoa.nha_san_xuat;
            pictureBox1.Image = img_list_anh_hang_hoa.Images[0];

        }
        #endregion
        #region Methods
        #endregion
        #region Event Handlers
        private void timer_doi_hinh_anh_Tick(object sender, EventArgs e)
        {
            
        }
        #endregion



    }
}
