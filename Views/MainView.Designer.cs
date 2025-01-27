namespace InventoryControl
{
    partial class MainView
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			btnManageProducts = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			ribbonPageProducts = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(components);
			ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			panelControl1 = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)mvvmContext1).BeginInit();
			((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
			SuspendLayout();
			// 
			// ribbonControl1
			// 
			ribbonControl1.ExpandCollapseItem.Id = 0;
			ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, btnManageProducts, barButtonItem1 });
			ribbonControl1.Location = new Point(0, 0);
			ribbonControl1.MaxItemId = 3;
			ribbonControl1.Name = "ribbonControl1";
			ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPageProducts, ribbonPage2 });
			ribbonControl1.Size = new Size(841, 158);
			// 
			// btnManageProducts
			// 
			btnManageProducts.Caption = "Edit Products";
			btnManageProducts.Hint = "View products in edit mode.";
			btnManageProducts.Id = 1;
			btnManageProducts.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnManageProducts.ImageOptions.SvgImage");
			btnManageProducts.Name = "btnManageProducts";
			btnManageProducts.ItemClick += BtnManageProducts_ItemClick;
			// 
			// barButtonItem1
			// 
			barButtonItem1.Caption = "View Products";
			barButtonItem1.Hint = "View products in read-only mode.";
			barButtonItem1.Id = 2;
			barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
			barButtonItem1.Name = "barButtonItem1";
			barButtonItem1.ItemClick += barButtonItem1_ItemClick;
			// 
			// ribbonPageProducts
			// 
			ribbonPageProducts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
			ribbonPageProducts.Name = "ribbonPageProducts";
			ribbonPageProducts.Text = "Products";
			// 
			// ribbonPageGroup1
			// 
			ribbonPageGroup1.ItemLinks.Add(btnManageProducts);
			ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
			ribbonPageGroup1.Name = "ribbonPageGroup1";
			ribbonPageGroup1.Text = "Product Management";
			// 
			// ribbonPage2
			// 
			ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
			ribbonPage2.Name = "ribbonPage2";
			ribbonPage2.Text = "ribbonPage2";
			// 
			// ribbonPageGroup2
			// 
			ribbonPageGroup2.Name = "ribbonPageGroup2";
			ribbonPageGroup2.Text = "ribbonPageGroup2";
			// 
			// mvvmContext1
			// 
			mvvmContext1.ContainerControl = this;
			// 
			// ribbonPage3
			// 
			ribbonPage3.Name = "ribbonPage3";
			ribbonPage3.Text = "ribbonPage3";
			// 
			// panelControl1
			// 
			panelControl1.Dock = DockStyle.Fill;
			panelControl1.Location = new Point(0, 158);
			panelControl1.Name = "panelControl1";
			panelControl1.Size = new Size(841, 256);
			panelControl1.TabIndex = 1;
			// 
			// MainView
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(841, 414);
			Controls.Add(panelControl1);
			Controls.Add(ribbonControl1);
			Name = "MainView";
			Ribbon = ribbonControl1;
			Text = "{Title}";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)mvvmContext1).EndInit();
			((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
		private DevExpress.XtraBars.BarButtonItem btnManageProducts;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
	}
}

