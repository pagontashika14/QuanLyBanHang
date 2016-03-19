using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.Controls;
using LibraryApi;

namespace QLBH
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            //pnl_loai_hang.BackColor = Color.FromArgb(25, Color.BlanchedAlmond);
            data_hang_hoa_to_form();
            data_loai_hang_to_form();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
        }
        public void data_loai_hang_to_form()
        {
            MyNetwork.GetDanhSachLoaiHang(this, (object data) =>
                {
                    var dm = data as LOAI_HANG;
                    foreach (var item in dm.Data)
                    {
                        var ctl = new ControlLoaiHang();
                        pnl_loai_hang.Controls.Add(ctl);
                        ctl.Dock = DockStyle.Top;
                        ctl.get_thong_tin(item);
                    }
                });
        }
        public void data_hang_hoa_to_form()
        {
            int so_san_pham = 17;
            List<ControlThongTinHangHoa> lhh = new List<ControlThongTinHangHoa>();
            tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 0; i < so_san_pham; i++)
            {
                lhh.Add(new ControlThongTinHangHoa());
            }
            //add vao table
            for (int i = 0; i < lhh.Count; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableLayoutPanel1.Controls.Add(lhh[i],0,i);
                lhh[i].Dock = DockStyle.Fill;    
            }
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            // tableLayoutPanel1.ColumnCount = tableLayoutPanel1.Width / 473;
        }
    }
}
