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

			var products = context.Products
				.Include(product => product.Supplier)
				.Include(product => product.Category)
				.ToList();

			gridControl1.DataSource = products;

			gridView1.Columns["ProductId"].OptionsColumn.AllowEdit = false;
			gridView1.Columns["ProductId"].OptionsColumn.ReadOnly = true;

			gridView1.Columns["Category"].Visible = false;
			gridView1.Columns["Supplier"].Visible = false;
			gridView1.Columns["OrderDetails"].Visible = false;
		}

		private void BtnSaveProducts_Click(object sender, EventArgs e)
		{
			try
			{
				using NorthwindContext context = new();

				var products = gridControl1.DataSource as List<Data.Product>;

				if (products is not null)
				{
					foreach (var product in products)
					{
						if (product.ProductId == 0)
						{
							context.Products.Add(product);
						}
						else
						{
							context.Products.Update(product);
						}
					}

					context.SaveChanges();
					MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("No products found to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}

			}
			catch (DbUpdateException ex)
			{
				MessageBox.Show($"An error occurred while saving changes to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAddNewProduct_Click(object sender, EventArgs e)
		{
			var newProduct = new Data.Product
			{
				ProductName = "New Product",
				UnitPrice = 0m,
				UnitsInStock = 0,
				UnitsOnOrder = 0,
				ReorderLevel = 0,
				Discontinued = false,
			};

			var products = gridControl1.DataSource as List<Data.Product>;

			if (products is not null)
			{
				products.Insert(0, newProduct);
				gridControl1.RefreshDataSource();
				gridView1.FocusedRowHandle = 0;
			}
			else
			{
				MessageBox.Show("Failed to add a new row. Data source is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
