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
    public partial class c01_danh_sach_hang_hoa : UserControl
    {
        public List<HangHoa> list_hang_hoa = new List<HangHoa>();
        public event EventHandler CellClick;
        public c01_danh_sach_hang_hoa()
        {
            InitializeComponent();
        }
        public void data_to_control()
        {
            m_grc_hang_hoa.DataSource = list_hang_hoa;
        }

        private void m_grv_danh_sach_hang_hoa_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var send = m_grv_danh_sach_hang_hoa.GetRowCellValue(e.RowHandle, "id");             
                    if (this.CellClick != null)
                    this.CellClick(send, e);
            }
            catch (Exception v_e)
            {
                Common.exception_handle(v_e);
            }       
        }
    }
}
