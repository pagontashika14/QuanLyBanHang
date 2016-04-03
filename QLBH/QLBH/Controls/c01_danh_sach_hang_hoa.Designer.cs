namespace QLBH.Controls
{
    partial class c01_danh_sach_hang_hoa
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
            this.components = new System.ComponentModel.Container();
            this.m_grc_hang_hoa = new DevExpress.XtraGrid.GridControl();
            this.m_grv_danh_sach_hang_hoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_hang_hoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_vach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmo_ta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnha_cung_cap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkhuyen_mai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colluot_xem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiem_danh_gia = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hang_hoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_hang_hoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_hang_hoa
            // 
            this.m_grc_hang_hoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_hang_hoa.DataSource = this.hangHoaBindingSource;
            this.m_grc_hang_hoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_hang_hoa.Location = new System.Drawing.Point(0, 0);
            this.m_grc_hang_hoa.MainView = this.m_grv_danh_sach_hang_hoa;
            this.m_grc_hang_hoa.Name = "m_grc_hang_hoa";
            this.m_grc_hang_hoa.Size = new System.Drawing.Size(359, 477);
            this.m_grc_hang_hoa.TabIndex = 1;
            this.m_grc_hang_hoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_danh_sach_hang_hoa});
            // 
            // m_grv_danh_sach_hang_hoa
            // 
            this.m_grv_danh_sach_hang_hoa.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightCyan;
            this.m_grv_danh_sach_hang_hoa.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Azure;
            this.m_grv_danh_sach_hang_hoa.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grv_danh_sach_hang_hoa.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_hang_hoa.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_danh_sach_hang_hoa.Appearance.FocusedCell.Options.UseFont = true;
            this.m_grv_danh_sach_hang_hoa.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_danh_sach_hang_hoa.Appearance.Row.BackColor = System.Drawing.Color.DarkGray;
            this.m_grv_danh_sach_hang_hoa.Appearance.Row.BackColor2 = System.Drawing.Color.LightGray;
            this.m_grv_danh_sach_hang_hoa.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grv_danh_sach_hang_hoa.Appearance.Row.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_hang_hoa.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_danh_sach_hang_hoa.Appearance.Row.Options.UseFont = true;
            this.m_grv_danh_sach_hang_hoa.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_danh_sach_hang_hoa.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightCyan;
            this.m_grv_danh_sach_hang_hoa.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Azure;
            this.m_grv_danh_sach_hang_hoa.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grv_danh_sach_hang_hoa.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_hang_hoa.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_hang_hoa.Appearance.SelectedRow.Options.UseFont = true;
            this.m_grv_danh_sach_hang_hoa.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_hang_hoa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.m_grv_danh_sach_hang_hoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colma_hang_hoa,
            this.colma_vach,
            this.colten,
            this.colmo_ta,
            this.colnha_cung_cap,
            this.colgia,
            this.colkhuyen_mai,
            this.colluot_xem,
            this.coldiem_danh_gia});
            this.m_grv_danh_sach_hang_hoa.GridControl = this.m_grc_hang_hoa;
            this.m_grv_danh_sach_hang_hoa.Name = "m_grv_danh_sach_hang_hoa";
            this.m_grv_danh_sach_hang_hoa.OptionsBehavior.Editable = false;
            this.m_grv_danh_sach_hang_hoa.OptionsDetail.AllowZoomDetail = false;
            this.m_grv_danh_sach_hang_hoa.OptionsDetail.EnableMasterViewMode = false;
            this.m_grv_danh_sach_hang_hoa.OptionsDetail.ShowDetailTabs = false;
            this.m_grv_danh_sach_hang_hoa.OptionsDetail.SmartDetailExpand = false;
            this.m_grv_danh_sach_hang_hoa.OptionsFind.AlwaysVisible = true;
            this.m_grv_danh_sach_hang_hoa.OptionsFind.FindNullPrompt = "Nhập tên hàng hóa";
            this.m_grv_danh_sach_hang_hoa.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.m_grv_danh_sach_hang_hoa.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            this.m_grv_danh_sach_hang_hoa.OptionsView.RowAutoHeight = true;
            this.m_grv_danh_sach_hang_hoa.OptionsView.ShowColumnHeaders = false;
            this.m_grv_danh_sach_hang_hoa.OptionsView.ShowGroupPanel = false;
            this.m_grv_danh_sach_hang_hoa.OptionsView.ShowIndicator = false;
            this.m_grv_danh_sach_hang_hoa.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.m_grv_danh_sach_hang_hoa.PaintStyleName = "Skin";
            this.m_grv_danh_sach_hang_hoa.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.m_grv_danh_sach_hang_hoa_RowClick);
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataSource = typeof(LibraryApi.HangHoa);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colma_hang_hoa
            // 
            this.colma_hang_hoa.FieldName = "ma_hang_hoa";
            this.colma_hang_hoa.Name = "colma_hang_hoa";
            // 
            // colma_vach
            // 
            this.colma_vach.FieldName = "ma_vach";
            this.colma_vach.Name = "colma_vach";
            // 
            // colten
            // 
            this.colten.FieldName = "ten";
            this.colten.Name = "colten";
            this.colten.Visible = true;
            this.colten.VisibleIndex = 0;
            // 
            // colmo_ta
            // 
            this.colmo_ta.FieldName = "mo_ta";
            this.colmo_ta.Name = "colmo_ta";
            // 
            // colnha_cung_cap
            // 
            this.colnha_cung_cap.FieldName = "nha_cung_cap";
            this.colnha_cung_cap.Name = "colnha_cung_cap";
            // 
            // colgia
            // 
            this.colgia.FieldName = "gia";
            this.colgia.Name = "colgia";
            // 
            // colkhuyen_mai
            // 
            this.colkhuyen_mai.FieldName = "khuyen_mai";
            this.colkhuyen_mai.Name = "colkhuyen_mai";
            // 
            // colluot_xem
            // 
            this.colluot_xem.FieldName = "luot_xem";
            this.colluot_xem.Name = "colluot_xem";
            // 
            // coldiem_danh_gia
            // 
            this.coldiem_danh_gia.FieldName = "diem_danh_gia";
            this.coldiem_danh_gia.Name = "coldiem_danh_gia";
            // 
            // c01_danh_sach_hang_hoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_grc_hang_hoa);
            this.Name = "c01_danh_sach_hang_hoa";
            this.Size = new System.Drawing.Size(359, 477);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hang_hoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_hang_hoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl m_grc_hang_hoa;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_danh_sach_hang_hoa;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colma_hang_hoa;
        private DevExpress.XtraGrid.Columns.GridColumn colma_vach;
        private DevExpress.XtraGrid.Columns.GridColumn colten;
        private DevExpress.XtraGrid.Columns.GridColumn colmo_ta;
        private DevExpress.XtraGrid.Columns.GridColumn colnha_cung_cap;
        private DevExpress.XtraGrid.Columns.GridColumn colgia;
        private DevExpress.XtraGrid.Columns.GridColumn colkhuyen_mai;
        private DevExpress.XtraGrid.Columns.GridColumn colluot_xem;
        private DevExpress.XtraGrid.Columns.GridColumn coldiem_danh_gia;
    }
}
