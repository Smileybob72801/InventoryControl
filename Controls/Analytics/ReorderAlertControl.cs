using DevExpress.XtraEditors;
using InventoryControl.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryControl.Controls.Analytics
{
	public partial class ReorderAlertControl : UserControl
	{
		public ReorderAlertControl()
		{
			InitializeComponent();
		}

		public void ReorderAlertControl_Load(object sender, EventArgs e)
		{
			using NorthwindContext context = new();

			var lowStockProducts = context.Products
				.Where(product => product.UnitsInStock < product.ReorderLevel)
				.Select(product => new
				{
					product.ProductId,
					product.ProductName,
					product.UnitsInStock,
					product.ReorderLevel,
					SupplierName = product.Supplier.CompanyName
				})
				.ToList();

			TileGroup group = new()
			{
				Text = "Reorder Alerts"
			};

			tileControl1.Groups.Add(group);

			foreach (var product in lowStockProducts)
			{
				TileItem tile = new()
				{
					Text = $"{product.ProductName}\nStock: {product.UnitsInStock}\nReorder: {product.ReorderLevel}",
					Tag = product.ProductId
				};

				double criticalReorderMultiplier = 0.5;

				tile.AppearanceItem.Normal.Font = new Font("Arial", 9);
				tile.AppearanceItem.Normal.BackColor =
					product.UnitsInStock < product.ReorderLevel * criticalReorderMultiplier ? Color.Red : Color.Orange;

				tile.ItemClick += Tile_ItemClick;

				group.Items.Add(tile);
			}
		}

		private void Tile_ItemClick(object sender, TileItemEventArgs e)
		{
			if (e.Item.Tag is int productId)
			{
				MessageBox.Show($"Reorder initiated for Product ID: {productId}", "Reorder", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
