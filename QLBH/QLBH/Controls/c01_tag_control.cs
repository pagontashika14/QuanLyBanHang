using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.Forms;
using LibraryApi;
namespace QLBH.Controls
{
    public partial class c01_tag_control : UserControl
    {
        #region public member

        #endregion

        #region data binding type
        public Tag v_tag { get; set; } = new Tag();
        #endregion

        #region public event handler

        #endregion

        #region public and private method

        public c01_tag_control()
        {
            InitializeComponent();
        }
        public c01_tag_control(Tag v_tag)
        {
            this.v_tag = v_tag;
        }
        public void data_to_control()
        {
            //pictureBox1.Image =
            labelControl2.Text = v_tag.ten_tag;
        }

        #endregion

        #region event handler


        #endregion

    }
}
