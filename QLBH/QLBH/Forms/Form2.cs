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

namespace QLBH
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pnl_loai_hang.Controls.Add(new ControlLoaiHang());
            data_hang_hoa_to_form();
        }
        public void data_loai han
        public void data_hang_hoa_to_form()
        {
            int so_hang;
            int so_san_pham = 17;          
            //add hang va cot
            tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i < so_san_pham; i++)
            {
               
                RowStyle row = new RowStyle(SizeType.AutoSize);
                tableLayoutPanel1.RowStyles.Add(row);
            }
            //add control hang hoa
            List<ControlThongTinHangHoa> lhh = new List<ControlThongTinHangHoa>();
            for (int i = 0; i < so_san_pham; i++)
            {
                lhh.Add(new ControlThongTinHangHoa());
            }
            //add vao table
            for (int i = 0; i < lhh.Count; i++)
            {
                tableLayoutPanel1.Controls.Add(lhh[i], 0, i);
                lhh[i].Dock = DockStyle.Fill;
                lhh[i].get_thong_tin(new HangHoaMaster());
            }
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
           // tableLayoutPanel1.ColumnCount = tableLayoutPanel1.Width / 473;
        }
    }
}
