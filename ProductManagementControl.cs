using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryControl
{
	public partial class ProductManagementControl : UserControl
	{
		public ProductManagementControl()
		{
			InitializeComponent();
		}

		private void ProductManagementForm_Load(object sender, EventArgs e)
		{
			var products = new List<Product>
			{
				new() { Id = 1, Name = "Widget", Price = 27.99m, UnitsInStock = 31 },
				new() { Id = 2, Name = "Gizmo", Price = 99.87m, UnitsInStock = 7 },
				new() { Id = 3, Name = "Doohickey", Price = 2.99m, UnitsInStock = 127 }
			};

			gridControl1.DataSource = products;
		}
	}
}
