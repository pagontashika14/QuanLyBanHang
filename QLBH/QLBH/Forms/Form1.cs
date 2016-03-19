using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApi;

namespace QLBH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //MyNetwork.requstLogin("admin1", "123",this, (object data) =>
                //{
                //    textBox1.Text = (data as DangNhap).Data.user_name;
                //});
            }
            catch (Exception)
            {

                throw;
            }    
        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                object dong_dathang = new object();
            }
           
        }
    }
}
