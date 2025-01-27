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
			btnStockLevelsAnalytics = new DevExpress.XtraBars.BarButtonItem();
			btnReorderLevelsAnalytics = new DevExpress.XtraBars.BarButtonItem();
			btnValueAnalytics = new DevExpress.XtraBars.BarButtonItem();
			btnSupplierContributionAnalytics = new DevExpress.XtraBars.BarButtonItem();
			btnCategoryRevenue = new DevExpress.XtraBars.BarButtonItem();
			btnTopProductsInsights = new DevExpress.XtraBars.BarButtonItem();
			btnSalesTrendsInsights = new DevExpress.XtraBars.BarButtonItem();
			ribbonPageProducts = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(components);
			ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			panelControl1 = new DevExpress.XtraEditors.PanelControl();
			stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
			((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)mvvmContext1).BeginInit();
			((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
			panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)stackPanel1).BeginInit();
			SuspendLayout();
			// 
			// ribbonControl1
			// 
			ribbonControl1.ExpandCollapseItem.Id = 0;
			ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, btnManageProducts, barButtonItem1, btnStockLevelsAnalytics, btnReorderLevelsAnalytics, btnValueAnalytics, btnSupplierContributionAnalytics, btnCategoryRevenue, btnTopProductsInsights, btnSalesTrendsInsights });
			ribbonControl1.Location = new Point(0, 0);
			ribbonControl1.MaxItemId = 11;
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
			// btnStockLevelsAnalytics
			// 
			btnStockLevelsAnalytics.Caption = "Stock Levels";
			btnStockLevelsAnalytics.Id = 3;
			btnStockLevelsAnalytics.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnStockLevelsAnalytics.ImageOptions.SvgImage");
			btnStockLevelsAnalytics.Name = "btnStockLevelsAnalytics";
			btnStockLevelsAnalytics.ItemClick += btnStockLevelsAnalytics_ItemClick;
			// 
			// btnReorderLevelsAnalytics
			// 
			btnReorderLevelsAnalytics.Caption = "Reorders";
			btnReorderLevelsAnalytics.Id = 4;
			btnReorderLevelsAnalytics.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnReorderLevelsAnalytics.ImageOptions.SvgImage");
			btnReorderLevelsAnalytics.Name = "btnReorderLevelsAnalytics";
			// 
			// btnValueAnalytics
			// 
			btnValueAnalytics.Caption = "Value";
			btnValueAnalytics.Id = 5;
			btnValueAnalytics.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnValueAnalytics.ImageOptions.SvgImage");
			btnValueAnalytics.Name = "btnValueAnalytics";
			// 
			// btnSupplierContributionAnalytics
			// 
			btnSupplierContributionAnalytics.Caption = "Supplier Contribution";
			btnSupplierContributionAnalytics.Id = 6;
			btnSupplierContributionAnalytics.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSupplierContributionAnalytics.ImageOptions.SvgImage");
			btnSupplierContributionAnalytics.Name = "btnSupplierContributionAnalytics";
			// 
			// btnCategoryRevenue
			// 
			btnCategoryRevenue.Caption = "Category Revenue";
			btnCategoryRevenue.Id = 7;
			btnCategoryRevenue.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnCategoryRevenue.ImageOptions.SvgImage");
			btnCategoryRevenue.Name = "btnCategoryRevenue";
			// 
			// btnTopProductsInsights
			// 
			btnTopProductsInsights.Caption = "Top Products";
			btnTopProductsInsights.Id = 8;
			btnTopProductsInsights.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnTopProductsInsights.ImageOptions.SvgImage");
			btnTopProductsInsights.Name = "btnTopProductsInsights";
			// 
			// btnSalesTrendsInsights
			// 
			btnSalesTrendsInsights.Caption = "Sales Trends";
			btnSalesTrendsInsights.Id = 9;
			btnSalesTrendsInsights.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSalesTrendsInsights.ImageOptions.SvgImage");
			btnSalesTrendsInsights.Name = "btnSalesTrendsInsights";
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
			ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2, ribbonPageGroup3, ribbonPageGroup4, ribbonPageGroup5 });
			ribbonPage2.Name = "ribbonPage2";
			ribbonPage2.Text = "Analytics";
			// 
			// ribbonPageGroup2
			// 
			ribbonPageGroup2.ItemLinks.Add(btnStockLevelsAnalytics);
			ribbonPageGroup2.ItemLinks.Add(btnReorderLevelsAnalytics);
			ribbonPageGroup2.ItemLinks.Add(btnValueAnalytics);
			ribbonPageGroup2.Name = "ribbonPageGroup2";
			ribbonPageGroup2.Text = "Inventory";
			// 
			// ribbonPageGroup3
			// 
			ribbonPageGroup3.ItemLinks.Add(btnSupplierContributionAnalytics);
			ribbonPageGroup3.Name = "ribbonPageGroup3";
			ribbonPageGroup3.Text = "Suppliers";
			// 
			// ribbonPageGroup4
			// 
			ribbonPageGroup4.ItemLinks.Add(btnCategoryRevenue);
			ribbonPageGroup4.Name = "ribbonPageGroup4";
			ribbonPageGroup4.Text = "Categories";
			// 
			// ribbonPageGroup5
			// 
			ribbonPageGroup5.ItemLinks.Add(btnTopProductsInsights);
			ribbonPageGroup5.ItemLinks.Add(btnSalesTrendsInsights);
			ribbonPageGroup5.Name = "ribbonPageGroup5";
			ribbonPageGroup5.Text = "Insights";
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
			panelControl1.Controls.Add(stackPanel1);
			panelControl1.Dock = DockStyle.Fill;
			panelControl1.Location = new Point(0, 158);
			panelControl1.Name = "panelControl1";
			panelControl1.Size = new Size(841, 256);
			panelControl1.TabIndex = 1;
			// 
			// stackPanel1
			// 
			stackPanel1.Location = new Point(570, 110);
			stackPanel1.Name = "stackPanel1";
			stackPanel1.Size = new Size(340, 140);
			stackPanel1.TabIndex = 0;
			stackPanel1.UseSkinIndents = true;
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
			panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)stackPanel1).EndInit();
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
		private DevExpress.XtraBars.BarButtonItem btnStockLevelsAnalytics;
		private DevExpress.XtraBars.BarButtonItem btnReorderLevelsAnalytics;
		private DevExpress.XtraBars.BarButtonItem btnValueAnalytics;
		private DevExpress.XtraBars.BarButtonItem btnSupplierContributionAnalytics;
		private DevExpress.XtraBars.BarButtonItem btnCategoryRevenue;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.BarButtonItem btnTopProductsInsights;
		private DevExpress.XtraBars.BarButtonItem btnSalesTrendsInsights;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private DevExpress.Utils.Layout.StackPanel stackPanel1;
	}
}

