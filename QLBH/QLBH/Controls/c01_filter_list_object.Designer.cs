namespace QLBH.Controls
{
    partial class c01_filter_list_object
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
            this.m_xtra_scroll = new DevExpress.XtraEditors.XtraScrollableControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_btn_xem_bo_loc = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_loc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_xtra_scroll
            // 
            this.m_xtra_scroll.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m_xtra_scroll.Appearance.Options.UseBackColor = true;
            this.m_xtra_scroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_xtra_scroll.Location = new System.Drawing.Point(0, 32);
            this.m_xtra_scroll.Name = "m_xtra_scroll";
            this.m_xtra_scroll.Size = new System.Drawing.Size(315, 336);
            this.m_xtra_scroll.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.m_btn_xem_bo_loc);
            this.panelControl1.Controls.Add(this.m_btn_loc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(315, 32);
            this.panelControl1.TabIndex = 2;
            // 
            // m_btn_xem_bo_loc
            // 
            this.m_btn_xem_bo_loc.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_xem_bo_loc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_xem_bo_loc.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.m_btn_xem_bo_loc.Appearance.Options.UseBackColor = true;
            this.m_btn_xem_bo_loc.Appearance.Options.UseFont = true;
            this.m_btn_xem_bo_loc.Appearance.Options.UseForeColor = true;
            this.m_btn_xem_bo_loc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_xem_bo_loc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_btn_xem_bo_loc.Location = new System.Drawing.Point(0, 0);
            this.m_btn_xem_bo_loc.Name = "m_btn_xem_bo_loc";
            this.m_btn_xem_bo_loc.Size = new System.Drawing.Size(261, 32);
            this.m_btn_xem_bo_loc.TabIndex = 1;
            this.m_btn_xem_bo_loc.Text = "Bộ lọc";
            // 
            // m_btn_loc
            // 
            this.m_btn_loc.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_loc.Appearance.Options.UseBackColor = true;
            this.m_btn_loc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_loc.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_loc.Image = global::QLBH.Properties.Resources.Filled_Filter_48;
            this.m_btn_loc.Location = new System.Drawing.Point(261, 0);
            this.m_btn_loc.Name = "m_btn_loc";
            this.m_btn_loc.Size = new System.Drawing.Size(54, 32);
            this.m_btn_loc.TabIndex = 0;
            // 
            // c01_filter_list_object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.m_xtra_scroll);
            this.Controls.Add(this.panelControl1);
            this.Name = "c01_filter_list_object";
            this.Size = new System.Drawing.Size(315, 368);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl m_xtra_scroll;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_btn_xem_bo_loc;
        private DevExpress.XtraEditors.SimpleButton m_btn_loc;
    }
}
