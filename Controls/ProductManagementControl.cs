using InventoryControl.Data;
using Microsoft.EntityFrameworkCore;

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
			using NorthwindContext context = new();

			List<Data.Product> products = [.. context.Products];

			gridControl1.DataSource = products;

			gridView1.Columns["Category"].Visible = false;
			gridView1.Columns["Supplier"].Visible = false;
			gridView1.Columns["OrderDetails"].Visible = false;
		}

		private void gridControl1_Click(object sender, EventArgs e)
		{

		}
	}
}
