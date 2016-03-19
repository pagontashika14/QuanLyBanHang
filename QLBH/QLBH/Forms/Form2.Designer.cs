namespace QLBH
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_loai_hang = new DevExpress.XtraEditors.PanelControl();
            this.pnl_filter = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_loai_hang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_filter)).BeginInit();
            this.pnl_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_loai_hang
            // 
            this.pnl_loai_hang.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnl_loai_hang.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.pnl_loai_hang.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_loai_hang.Appearance.Options.UseBackColor = true;
            this.pnl_loai_hang.Appearance.Options.UseBorderColor = true;
            this.pnl_loai_hang.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl_loai_hang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_loai_hang.Location = new System.Drawing.Point(0, 0);
            this.pnl_loai_hang.Name = "pnl_loai_hang";
            this.pnl_loai_hang.Size = new System.Drawing.Size(237, 541);
            this.pnl_loai_hang.TabIndex = 0;
            // 
            // pnl_filter
            // 
            this.pnl_filter.AllowTouchScroll = true;
            this.pnl_filter.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnl_filter.Appearance.Options.UseBackColor = true;
            this.pnl_filter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl_filter.Controls.Add(this.tableLayoutPanel1);
            this.pnl_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_filter.FireScrollEventOnMouseWheel = true;
            this.pnl_filter.Location = new System.Drawing.Point(237, 0);
            this.pnl_filter.Name = "pnl_filter";
            this.pnl_filter.Size = new System.Drawing.Size(908, 541);
            this.pnl_filter.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.502772F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.49723F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 541);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBH.Properties.Resources.Untitled;
            this.ClientSize = new System.Drawing.Size(1145, 541);
            this.Controls.Add(this.pnl_filter);
            this.Controls.Add(this.pnl_loai_hang);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pnl_loai_hang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_filter)).EndInit();
            this.pnl_filter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnl_loai_hang;
        private DevExpress.XtraEditors.PanelControl pnl_filter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}