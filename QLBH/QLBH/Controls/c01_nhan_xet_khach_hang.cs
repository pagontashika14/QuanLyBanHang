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
    public partial class c01_nhan_xet_khach_hang : UserControl
    {
        private HangHoa v_hang_hoa;

        public c01_nhan_xet_khach_hang()
        {
            InitializeComponent();
        }

        public c01_nhan_xet_khach_hang(HangHoa v_hang_hoa)
        {
            InitializeComponent();
            this.v_hang_hoa = v_hang_hoa;
        }
    }
}
