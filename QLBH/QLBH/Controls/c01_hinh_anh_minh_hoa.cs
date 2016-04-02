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
    public partial class c01_hinh_anh_minh_hoa : UserControl
    {
        #region DataBindingType
        public HangHoa v_hang_hoa;
        #endregion
        #region public event handler
        public event EventHandler ButtonEditClick;
        public event EventHandler ButtonDeleteClick;
        #endregion
        #region public method
        public c01_hinh_anh_minh_hoa()
        {
            InitializeComponent();
        }
        public c01_hinh_anh_minh_hoa(HangHoa v_hh)
        {
            InitializeComponent();
            data_2_image_slider(v_hh);
        }

        public void data_2_image_slider(HangHoa v_hh)
        {
            m_img_slider.Images.Clear();
            foreach (var item in v_hh.link_anh)
            {
                m_img_slider.Images.Add(Common.get_image(item));
            }
        }
        #endregion
        #region event handler
        private void m_btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ButtonEditClick != null)
                    this.ButtonEditClick(sender, e);
            }
            catch (Exception ex)
            {
                Common.exception_handle(ex);
            }

        }
        #endregion

        private void m_btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ButtonDeleteClick != null)
                    this.ButtonDeleteClick(sender, e);
            }
            catch (Exception ex)
            {
                Common.exception_handle(ex);
            }
        }
    }
}
