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

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = new List<ThemHangHoaPost>();
            for (int i = 0; i < 200; i++)
            {
                var hang = new ThemHangHoaPost();
                hang.tenHangHoa = "Hang hoa " + i;
                hang.id_nha_cung_cap = 1;
                list.Add(hang);
            }
            MyNetwork.ThemHangHoa(list, this, data =>
            {
                MessageBox.Show(data.Message);
            });
        }
    }
}
