namespace QLBH.Controls
{
    partial class c01_hinh_anh_minh_hoa
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
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.m_btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_img_slider = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_img_slider)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.m_btn_delete);
            this.xtraScrollableControl1.Controls.Add(this.m_btn_edit);
            this.xtraScrollableControl1.Controls.Add(this.labelControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(5, 5);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(559, 37);
            this.xtraScrollableControl1.TabIndex = 6;
            // 
            // m_btn_delete
            // 
            this.m_btn_delete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_delete.Appearance.Options.UseBackColor = true;
            this.m_btn_delete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_delete.Image = global::QLBH.Properties.Resources.Delete_48;
            this.m_btn_delete.Location = new System.Drawing.Point(449, 0);
            this.m_btn_delete.Name = "m_btn_delete";
            this.m_btn_delete.Size = new System.Drawing.Size(55, 37);
            this.m_btn_delete.TabIndex = 2;
            this.m_btn_delete.Click += new System.EventHandler(this.m_btn_delete_Click);
            // 
            // m_btn_edit
            // 
            this.m_btn_edit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_edit.Appearance.Options.UseBackColor = true;
            this.m_btn_edit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_edit.Image = global::QLBH.Properties.Resources.Google_Images_Filled_50;
            this.m_btn_edit.Location = new System.Drawing.Point(504, 0);
            this.m_btn_edit.Name = "m_btn_edit";
            this.m_btn_edit.Size = new System.Drawing.Size(55, 37);
            this.m_btn_edit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(179, 30);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hình ảnh minh họa";
            // 
            // m_img_slider
            // 
            this.m_img_slider.AllowLooping = true;
            this.m_img_slider.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.m_img_slider.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m_img_slider.Appearance.Options.UseBackColor = true;
            this.m_img_slider.Appearance.Options.UseForeColor = true;
            this.m_img_slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_img_slider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.m_img_slider.Location = new System.Drawing.Point(5, 42);
            this.m_img_slider.Name = "m_img_slider";
            this.m_img_slider.Padding = new System.Windows.Forms.Padding(5);
            this.m_img_slider.Size = new System.Drawing.Size(559, 392);
            this.m_img_slider.TabIndex = 7;
            // 
            // c01_hinh_anh_minh_hoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.m_img_slider);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "c01_hinh_anh_minh_hoa";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(569, 439);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_img_slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.SimpleButton m_btn_edit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Controls.ImageSlider m_img_slider;
        private DevExpress.XtraEditors.SimpleButton m_btn_delete;
    }
}
