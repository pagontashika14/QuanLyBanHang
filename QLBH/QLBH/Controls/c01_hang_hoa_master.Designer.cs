namespace QLBH.Controls
{
    partial class c01_hang_hoa_master
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
            this.m_pnl_anh = new DevExpress.XtraEditors.PanelControl();
            this.m_pnl_img_slider = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.m_pnl_anh)).BeginInit();
            this.m_pnl_anh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pnl_img_slider)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pnl_anh
            // 
            this.m_pnl_anh.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m_pnl_anh.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m_pnl_anh.Appearance.Options.UseBackColor = true;
            this.m_pnl_anh.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.m_pnl_anh.Controls.Add(this.m_pnl_img_slider);
            this.m_pnl_anh.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_pnl_anh.Location = new System.Drawing.Point(0, 0);
            this.m_pnl_anh.Name = "m_pnl_anh";
            this.m_pnl_anh.Size = new System.Drawing.Size(192, 155);
            this.m_pnl_anh.TabIndex = 0;
            // 
            // m_pnl_img_slider
            // 
            this.m_pnl_img_slider.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m_pnl_img_slider.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m_pnl_img_slider.Appearance.Options.UseBackColor = true;
            this.m_pnl_img_slider.Appearance.Options.UseForeColor = true;
            this.m_pnl_img_slider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.m_pnl_img_slider.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.m_pnl_img_slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pnl_img_slider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.m_pnl_img_slider.Location = new System.Drawing.Point(0, 0);
            this.m_pnl_img_slider.Name = "m_pnl_img_slider";
            this.m_pnl_img_slider.Size = new System.Drawing.Size(192, 155);
            this.m_pnl_img_slider.TabIndex = 1;
            // 
            // c01_hang_hoa_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.m_pnl_anh);
            this.Name = "c01_hang_hoa_master";
            this.Size = new System.Drawing.Size(427, 155);
            ((System.ComponentModel.ISupportInitialize)(this.m_pnl_anh)).EndInit();
            this.m_pnl_anh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_pnl_img_slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl m_pnl_anh;
        private DevExpress.XtraEditors.Controls.ImageSlider m_pnl_img_slider;
    }
}
