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
			using var context = new NorthwindContext();

			var products = context.Products
				.Include(product => product.Category)
				.Include(product => product.Supplier)
				.ToList();

			gridControl1 .DataSource = products;

			gridView1.Columns["Category"].Visible = false;
		}
	}
}
