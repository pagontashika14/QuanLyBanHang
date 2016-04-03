namespace QLBH.Controls
{
    partial class c01_mo_ta_hang_hoa
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
            this.m_rich_txt_edit = new DevExpress.XtraRichEdit.RichEditControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.m_btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_rich_txt_edit
            // 
            this.m_rich_txt_edit.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.m_rich_txt_edit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.m_rich_txt_edit.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_rich_txt_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_rich_txt_edit.EnableToolTips = true;
            this.m_rich_txt_edit.Location = new System.Drawing.Point(5, 5);
            this.m_rich_txt_edit.Name = "m_rich_txt_edit";
            this.m_rich_txt_edit.Options.Comments.ShowAllAuthors = true;
            this.m_rich_txt_edit.Options.Comments.Visibility = DevExpress.XtraRichEdit.Options.RichEditCommentVisibility.Auto;
            this.m_rich_txt_edit.Options.CopyPaste.MaintainDocumentSectionSettings = false;
            this.m_rich_txt_edit.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.m_rich_txt_edit.Options.MailMerge.KeepLastParagraph = false;
            this.m_rich_txt_edit.Padding = new System.Windows.Forms.Padding(5);
            this.m_rich_txt_edit.Size = new System.Drawing.Size(578, 483);
            this.m_rich_txt_edit.TabIndex = 4;
            this.m_rich_txt_edit.Views.SimpleView.AdjustColorsToSkins = true;
            this.m_rich_txt_edit.Views.SimpleView.BackColor = System.Drawing.Color.White;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.m_btn_edit);
            this.xtraScrollableControl1.Controls.Add(this.labelControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(5, 5);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(578, 37);
            this.xtraScrollableControl1.TabIndex = 5;
            // 
            // m_btn_edit
            // 
            this.m_btn_edit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_edit.Appearance.Options.UseBackColor = true;
            this.m_btn_edit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_edit.Image = global::QLBH.Properties.Resources.Edit_Row_Filled_50;
            this.m_btn_edit.Location = new System.Drawing.Point(523, 0);
            this.m_btn_edit.Name = "m_btn_edit";
            this.m_btn_edit.Size = new System.Drawing.Size(55, 37);
            this.m_btn_edit.TabIndex = 1;
            this.m_btn_edit.Click += new System.EventHandler(this.m_btn_edit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(152, 30);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mô tả sản phẩm";
            // 
            // c01_mo_ta_hang_hoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.m_rich_txt_edit);
            this.Name = "c01_mo_ta_hang_hoa";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(588, 493);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraRichEdit.RichEditControl m_rich_txt_edit;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.SimpleButton m_btn_edit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
