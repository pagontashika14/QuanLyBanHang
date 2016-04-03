using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Controls
{
    public partial class c01_filter_list_object : UserControl
    {
        public Type v_data_type { get; set; }
        public List<object> v_list_data_can_loc { get; set; }
        public List<object> v_list_data_da_loc { get; set; }
        public c01_filter_list_object()
        {
            InitializeComponent();
        }
        public c01_filter_list_object(List<object> v_list_data)
        {
            InitializeComponent();
            //
            v_list_data_can_loc = v_list_data;
            v_data_type =  v_list_data[0].GetType();
        }

    }
}
