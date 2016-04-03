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
    public partial class c01_chi_tiet_khuyen_mai : UserControl
    {
        private HangHoa v_hang_hoa;

        public c01_chi_tiet_khuyen_mai()
        {
            InitializeComponent();
        }

        public c01_chi_tiet_khuyen_mai(HangHoa v_hang_hoa)
        {
            InitializeComponent();
            this.v_hang_hoa = v_hang_hoa;
        }
    }
}
