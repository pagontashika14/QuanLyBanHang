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

        public void get_thong_tin()
        {

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
