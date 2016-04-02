using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace QLBH.Controls
{
    public partial class c01_filter_element : UserControl
    {
        public PropertyInfo v_property { get; set; }
        public List<object> v_data { get; set; }
        public event EventHandler FilterValueChanged;
        public c01_filter_element()
        {
            InitializeComponent();
        }
        public c01_filter_element(PropertyInfo p, List<object> v_data)
        {
            InitializeComponent();
            v_property = p;
            this.v_data = v_data;
        }
        public void data_to_control()
        {
            data_to_name_lbl();
            data_to_value_sle();
        }

        private void data_to_value_sle()
        {
            List<object> v_l = new List<object>(); 
            foreach (var item in v_data)
            {
                if (!item.GetType().GetProperties().ToList().Contains(v_property)) continue;
                v_l.Add(item.GetType().GetProperty(v_property.Name).GetValue(item, null));
            }
            m_sle_property_value.Properties.DataSource = v_l;
        }

        private void data_to_name_lbl()
        {
            m_lbl_property_name.Text = v_property.Name;
        }

        private void m_sle_property_value_EditValueChanged(object sender, EventArgs e)
        {
            if (m_sle_property_value.EditValue == null)
            {
                return;
            }
            var p = m_sle_property_value.EditValue;        
            if (this.FilterValueChanged!=null)
            {
                this.FilterValueChanged(p, e);
            }
        }
    }
}
