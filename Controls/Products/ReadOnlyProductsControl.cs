using InventoryControl.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryControl.Controls
{
	public partial class ReadOnlyProductsControl : UserControl
	{
		public ReadOnlyProductsControl()
		{
			InitializeComponent();
		}

		private void ReadOnlyProductsControl_Load(object sender, EventArgs e)
		{

			using var context = new NorthwindContext();

			var products = context.Products
				.Include(product => product.Supplier)
				.Include(product => product.Category)
				.Select(product => new
				{
					product.ProductId,
					product.ProductName,
					SupplierName = product.Supplier != null ? product.Supplier.CompanyName : "null",
					CategoryName = product.Category != null ? product.Category.CategoryName : "null",
					product.UnitPrice,
					product.UnitsInStock,
					product.QuantityPerUnit,
					product.UnitsOnOrder,
					product.ReorderLevel,
					product.Discontinued
				})
				.ToList();

			gridControl1.DataSource = products;
		}
	}
}
