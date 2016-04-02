namespace QLBH.Controls
{
    partial class c01_filter_element
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_sle_property_value = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ma_tag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_tag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ten_tag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl_property_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_property_value.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // m_sle_property_value
            // 
            this.m_sle_property_value.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_sle_property_value.EditValue = "gsgsf";
            this.m_sle_property_value.Location = new System.Drawing.Point(123, 2);
            this.m_sle_property_value.Name = "m_sle_property_value";
            this.m_sle_property_value.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sle_property_value.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.m_sle_property_value.Properties.Appearance.Options.UseFont = true;
            this.m_sle_property_value.Properties.Appearance.Options.UseForeColor = true;
            this.m_sle_property_value.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_property_value.Properties.NullText = "Chọn ";
            this.m_sle_property_value.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_property_value.Size = new System.Drawing.Size(146, 24);
            this.m_sle_property_value.TabIndex = 3;
            this.m_sle_property_value.EditValueChanged += new System.EventHandler(this.m_sle_property_value_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.searchLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit1View.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.searchLookUpEdit1View.Appearance.Row.Options.UseBackColor = true;
            this.searchLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.searchLookUpEdit1View.Appearance.Row.Options.UseForeColor = true;
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ma_tag,
            this.id_tag,
            this.ten_tag});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ma_tag
            // 
            this.ma_tag.FieldName = "ma_tag";
            this.ma_tag.Name = "ma_tag";
            this.ma_tag.Visible = true;
            this.ma_tag.VisibleIndex = 0;
            // 
            // id_tag
            // 
            this.id_tag.FieldName = "id";
            this.id_tag.Name = "id_tag";
            // 
            // ten_tag
            // 
            this.ten_tag.FieldName = "ten_tag";
            this.ten_tag.Name = "ten_tag";
            this.ten_tag.Visible = true;
            this.ten_tag.VisibleIndex = 1;
            // 
            // m_lbl_property_name
            // 
            this.m_lbl_property_name.AutoSize = true;
            this.m_lbl_property_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_lbl_property_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_property_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_lbl_property_name.Location = new System.Drawing.Point(2, 2);
            this.m_lbl_property_name.Name = "m_lbl_property_name";
            this.m_lbl_property_name.Size = new System.Drawing.Size(65, 19);
            this.m_lbl_property_name.TabIndex = 2;
            this.m_lbl_property_name.Text = "Màu sắc";
            // 
            // c01_filter_element
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.m_sle_property_value);
            this.Controls.Add(this.m_lbl_property_name);
            this.Name = "c01_filter_element";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(271, 29);
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_property_value.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_property_value;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ma_tag;
        private DevExpress.XtraGrid.Columns.GridColumn id_tag;
        private DevExpress.XtraGrid.Columns.GridColumn ten_tag;
        private System.Windows.Forms.Label m_lbl_property_name;
    }
}
