﻿using DevExpress.Skins;
using DevExpress.XtraBars.Helpers;
using InventoryControl.Controls;
using InventoryControl.Controls.Analytics;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryControl
{
	public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public MainView()
		{
			InitializeComponent();
			if (!mvvmContext1.IsDesignMode)
				InitializeBindings();
		}

		private void InitializeBindings()
		{
			var fluent = mvvmContext1.OfType<MainViewModel>();
			// View and ViewModel Lifetime
			fluent.WithEvent(this, nameof(HandleCreated))
				.EventToCommand(x => x.OnCreate);
			fluent.WithEvent(this, nameof(HandleDestroyed))
				.EventToCommand(x => x.OnDestroy);
			// Bind the Title property to the Text
			fluent.SetBinding(this, view => view.Text, x => x.Title);
		}

		private void BtnManageProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ProductManagementControl productManagementControl = new();
			ShowControl(productManagementControl);
		}

		/// <summary>
		/// Displays the specified <see cref="UserControl"/> within the main panel.
		/// </summary>
		/// <param name="control">The <see cref="UserControl"/> to be displayed.</param>
		private void ShowControl(UserControl control)
		{
			control.Dock = DockStyle.Fill;
			panelControl1.Controls.Clear();
			panelControl1.Controls.Add(control);
		}

		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ReadOnlyProductsControl readOnlyProductsControl = new();
			ShowControl(readOnlyProductsControl);
		}

		private void btnStockLevelsAnalytics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			StockLevelsControl stockLevelsControl = new();
			ShowControl(stockLevelsControl);
		}

		private void btnReorderLevelsAnalytics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ReorderAlertControl reorderAlertControl = new();
			ShowControl(reorderAlertControl);
		}

		private void btnSupplierContributionAnalytics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			SupplierContributionControl supplierContributionControl = new();
			ShowControl(supplierContributionControl);
		}

		private void btnTopProductsInsights_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TopProductsAnalyticsControl topProductsAnalyticsControl = new();
			ShowControl(topProductsAnalyticsControl);
		}

		private void btnSalesTrendsInsights_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			SalesTrendsControl salesTrendsControl = new();
			ShowControl(salesTrendsControl);
		}

		private void MainView_Load(object sender, EventArgs e)
		{
			SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
		}
	}
}
