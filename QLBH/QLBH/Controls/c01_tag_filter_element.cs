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
    public partial class c01_tag_filter_element : UserControl
    {
        public c01_tag_filter_element()
        {
            InitializeComponent();
        }
        public LoaiTag v_loai_tag { get; set; } = new LoaiTag();
        public event EventHandler FilterValueChanged;
        public c01_tag_filter_element(LoaiTag tag)
        {
            InitializeComponent();
            LoaiTag c = new LoaiTag();
            c.id = 1;
            c.ten_loai_tag = "Màu sắc";
            c.ds_tag = get_list_tag(1);
            c.ma_loai_tag = "t0000";
            v_loai_tag = c;
            data_2_control();
        }

        private void data_2_control()
        {
            label1.Text = v_loai_tag.ten_loai_tag;
            //
            searchLookUpEdit1.Properties.DataSource = v_loai_tag.ds_tag;
            searchLookUpEdit1.Properties.ValueMember = "id";
            searchLookUpEdit1.Properties.DisplayMember = "ten_tag";
            searchLookUpEdit1.Properties.View.Columns[0].Caption = "ID Tag";
            searchLookUpEdit1.Properties.View.Columns[1].Caption = "Tag";
        }

        private List<Tag> get_list_tag(decimal id)
        {
            //
            List<Tag> v_l = new List<LibraryApi.Tag>();
            Tag t1 = new LibraryApi.Tag();
            t1.id = 1;
            t1.ma_tag = "T001";
            t1.ten_tag = "Màu đen";
            Tag t2 = new LibraryApi.Tag();
            t2.id = 2;
            t2.ma_tag = "T002";
            t2.ten_tag = "Màu đen tuyền";
            Tag t3 = new LibraryApi.Tag();
            t3.id = 3;
            t3.ma_tag = "T003";
            t3.ten_tag = "Màu lam";
            v_l.Add(t1);
            v_l.Add(t2);
            v_l.Add(t3);
            //
            return v_l;
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.EditValue == null)
            {
                return;
            }
            decimal i = Convert.ToDecimal(searchLookUpEdit1.EditValue);
            LibraryApi.Tag p = v_loai_tag.ds_tag.Where(s => s.id == i).First();
            if (this.FilterValueChanged != null)
            {
                this.FilterValueChanged(p, e);
            }
        }
    }
}
