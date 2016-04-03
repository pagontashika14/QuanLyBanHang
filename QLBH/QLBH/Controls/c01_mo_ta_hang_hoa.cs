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
    public partial class c01_mo_ta_hang_hoa : UserControl
    {
        #region DataBindingType
        public HangHoa v_hang_hoa;
        #endregion
        #region public event handler
        public event EventHandler ButtonEditClick;
        #endregion
        #region public method
        public c01_mo_ta_hang_hoa()
        {
            InitializeComponent();
        }
        public c01_mo_ta_hang_hoa(HangHoa v_hh)
        {
            InitializeComponent();
            v_hang_hoa = v_hh;
            data_to_control();
        }
        public void data_to_control()
        {
            //
            //string file_name = SystemInfo.dia_chi_bai_viet_mo_ta_san_pham + v_hang_hoa.ten + ".docx";
            //m_rich_txt_edit.LoadDocument(Common.download_docx_file_from_link(v_hang_hoa.mo_ta, file_name));
            m_rich_txt_edit.LoadDocument(@"C:\Users\Son Pham\Desktop\New Text Document (3).txt");
            m_rich_txt_edit.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            //

        }
        public void data_to_bai_viet(string file_name)
        {
            m_rich_txt_edit.LoadDocument(Common.download_docx_file_from_link(v_hang_hoa.mo_ta, file_name));
            m_rich_txt_edit.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
        }
        #endregion
        #region event handler
        private void m_btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                m_rich_txt_edit.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
                if (this.ButtonEditClick != null)
                    this.ButtonEditClick(sender, e);
            }
            catch (Exception ex)
            {
                Common.exception_handle(ex);
            }
            
        }
        #endregion


    }
}
