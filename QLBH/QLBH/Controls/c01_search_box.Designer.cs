namespace QLBH.Controls
{
    partial class c01_search_box
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
            this.m_btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_search = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // m_btn_search
            // 
            this.m_btn_search.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_search.Appearance.Options.UseBackColor = true;
            this.m_btn_search.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_search.Image = global::QLBH.Properties.Resources.Google_Web_Search_Filled_50;
            this.m_btn_search.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_search.Location = new System.Drawing.Point(189, 0);
            this.m_btn_search.Name = "m_btn_search";
            this.m_btn_search.Size = new System.Drawing.Size(57, 40);
            this.m_btn_search.TabIndex = 2;
            // 
            // m_txt_search
            // 
            this.m_txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.m_txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_txt_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_txt_search.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.m_txt_search.Location = new System.Drawing.Point(0, 0);
            this.m_txt_search.Multiline = false;
            this.m_txt_search.Name = "m_txt_search";
            this.m_txt_search.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.m_txt_search.Size = new System.Drawing.Size(189, 40);
            this.m_txt_search.TabIndex = 4;
            this.m_txt_search.Text = "";
            // 
            // c01_search_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.m_txt_search);
            this.Controls.Add(this.m_btn_search);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.Name = "c01_search_box";
            this.Size = new System.Drawing.Size(246, 40);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton m_btn_search;
        private System.Windows.Forms.RichTextBox m_txt_search;
    }
}
