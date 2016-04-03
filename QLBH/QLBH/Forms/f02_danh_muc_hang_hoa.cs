using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Forms
{
    public partial class f02_danh_muc_hang_hoa : Form
    {
        public f02_danh_muc_hang_hoa()
        {
            InitializeComponent();
            
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            facebookService1.ConnectToFacebook();
        }
    }
}
