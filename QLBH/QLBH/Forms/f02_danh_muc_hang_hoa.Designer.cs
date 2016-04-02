namespace QLBH.Forms
{
    partial class f02_danh_muc_hang_hoa
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
            this.components = new System.ComponentModel.Container();
            this.m_pnl_quan_ly_hang_hoa = new DevExpress.XtraEditors.PanelControl();
            this.facebookService1 = new Facebook.Winforms.Components.FacebookService(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel4 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.c01_hang_hoa_filter1 = new QLBH.Controls.c01_hang_hoa_filter();
            ((System.ComponentModel.ISupportInitialize)(this.m_pnl_quan_ly_hang_hoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel3.SuspendLayout();
            this.dockPanel4.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_pnl_quan_ly_hang_hoa
            // 
            this.m_pnl_quan_ly_hang_hoa.Appearance.BackColor = System.Drawing.Color.Silver;
            this.m_pnl_quan_ly_hang_hoa.Appearance.BackColor2 = System.Drawing.Color.LightGray;
            this.m_pnl_quan_ly_hang_hoa.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.m_pnl_quan_ly_hang_hoa.Appearance.Options.UseBackColor = true;
            this.m_pnl_quan_ly_hang_hoa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.m_pnl_quan_ly_hang_hoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_quan_ly_hang_hoa.Location = new System.Drawing.Point(219, 0);
            this.m_pnl_quan_ly_hang_hoa.Name = "m_pnl_quan_ly_hang_hoa";
            this.m_pnl_quan_ly_hang_hoa.Size = new System.Drawing.Size(889, 67);
            this.m_pnl_quan_ly_hang_hoa.TabIndex = 0;
            // 
            // facebookService1
            // 
            this.facebookService1.ApplicationKey = "f0af35c9634286110f9096ed3cde23ee";
            this.facebookService1.SessionKey = null;
            this.facebookService1.uid = ((long)(0));
            // 
            // dockManager1
            // 
            this.dockManager1.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hideContainerLeft.Controls.Add(this.dockPanel1);
            this.hideContainerLeft.Controls.Add(this.dockPanel3);
            this.hideContainerLeft.Controls.Add(this.dockPanel4);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 550);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("29f6f77b-579e-4ff1-af04-681a7e1f4ead");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.SavedIndex = 0;
            this.dockPanel1.Size = new System.Drawing.Size(200, 550);
            this.dockPanel1.Text = "dockPanel1";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 523);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel3
            // 
            this.dockPanel3.Controls.Add(this.dockPanel3_Container);
            this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel3.ID = new System.Guid("143dff1d-8a99-4b89-be33-bffbcbd65319");
            this.dockPanel3.Location = new System.Drawing.Point(0, 0);
            this.dockPanel3.Name = "dockPanel3";
            this.dockPanel3.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel3.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel3.SavedIndex = 1;
            this.dockPanel3.Size = new System.Drawing.Size(200, 550);
            this.dockPanel3.Text = "dockPanel3";
            this.dockPanel3.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(192, 523);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // dockPanel4
            // 
            this.dockPanel4.Controls.Add(this.dockPanel4_Container);
            this.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel4.ID = new System.Guid("1e5cbd35-f514-411a-b037-ebe845adfdc4");
            this.dockPanel4.Location = new System.Drawing.Point(0, 0);
            this.dockPanel4.Name = "dockPanel4";
            this.dockPanel4.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel4.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel4.SavedIndex = 1;
            this.dockPanel4.Size = new System.Drawing.Size(200, 550);
            this.dockPanel4.Text = "dockPanel4";
            this.dockPanel4.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(192, 523);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel2.ID = new System.Guid("9c43781e-b07b-485c-b6d9-795de70b0327");
            this.dockPanel2.Location = new System.Drawing.Point(19, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.Size = new System.Drawing.Size(200, 550);
            this.dockPanel2.Text = "dockPanel2";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(192, 523);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // c01_hang_hoa_filter1
            // 
            this.c01_hang_hoa_filter1.Location = new System.Drawing.Point(396, 187);
            this.c01_hang_hoa_filter1.MaximumSize = new System.Drawing.Size(300, 300);
            this.c01_hang_hoa_filter1.Name = "c01_hang_hoa_filter1";
            this.c01_hang_hoa_filter1.Padding = new System.Windows.Forms.Padding(2);
            this.c01_hang_hoa_filter1.Size = new System.Drawing.Size(300, 56);
            this.c01_hang_hoa_filter1.TabIndex = 13;
            // 
            // f02_danh_muc_hang_hoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1108, 550);
            this.Controls.Add(this.c01_hang_hoa_filter1);
            this.Controls.Add(this.m_pnl_quan_ly_hang_hoa);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.hideContainerLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f02_danh_muc_hang_hoa";
            this.Text = "F02 - Quản lý hàng hóa";
            ((System.ComponentModel.ISupportInitialize)(this.m_pnl_quan_ly_hang_hoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel3.ResumeLayout(false);
            this.dockPanel4.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl m_pnl_quan_ly_hang_hoa;
        private Facebook.Winforms.Components.FacebookService facebookService1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel4;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private Controls.c01_hang_hoa_filter c01_hang_hoa_filter1;
    }
}