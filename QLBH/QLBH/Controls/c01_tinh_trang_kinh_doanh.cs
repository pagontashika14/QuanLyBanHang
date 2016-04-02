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
    public partial class c01_tinh_trang_kinh_doanh : UserControl
    {
        private HangHoa v_hang_hoa;

        public c01_tinh_trang_kinh_doanh()
        {
            InitializeComponent();
        }

        public c01_tinh_trang_kinh_doanh(HangHoa v_hang_hoa)
        {
            InitializeComponent();
            this.v_hang_hoa = v_hang_hoa;
        }
    }
}
