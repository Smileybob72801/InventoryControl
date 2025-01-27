using InventoryControl.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryControl
{
	public partial class ProductManagementControl : UserControl
	{
		private readonly List<Data.Product> _productsToDelete = [];
		public ProductManagementControl()
		{
			InitializeComponent();
		}

		private void RefreshData()
		{
			using NorthwindContext context = new();

			var products = context.Products
				.Include(product => product.Supplier)
				.Include(product => product.Category)
				.ToList();

			gridControl1.DataSource = products;
			_productsToDelete.Clear();
		}

		private void ProductManagementForm_Load(object sender, EventArgs e)
		{
			RefreshData();

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

				foreach (Data.Product product in _productsToDelete)
				{
					context.Products.Remove(product);
				}

				List<Data.Product>? products = gridControl1.DataSource as List<Data.Product>;

				if (products is not null)
				{
					foreach (var product in products)
					{
						if (product.ProductId == 0)
						{
							context.Products.Add(product);
						}
						else if (!_productsToDelete.Contains(product))
						{
							context.Products.Update(product);
						}
					}

					context.SaveChanges();
					_productsToDelete.Clear();
					MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					RefreshData();
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

		private void btnProductDelete_Click(object sender, EventArgs e)
		{
			int selectedRowHandle = gridView1.FocusedRowHandle;

			if (selectedRowHandle < 0)
			{
				MessageBox.Show("No product selected for deletion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DialogResult confirmDelete = DevExpress.XtraEditors.XtraMessageBox.Show(
				"Are you sure you want to delete the selected product?",
				"Confirm Deletion",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (confirmDelete == DialogResult.Yes)
			{
				Data.Product? product = gridView1.GetRow(selectedRowHandle) as Data.Product;

				if (product is not null)
				{
					_productsToDelete.Add(product);
					gridView1.RefreshRow(selectedRowHandle);
					gridView1.ClearSelection();
				}
				else
				{
					MessageBox.Show("Unable to delete the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			var product = gridView1.GetRow(e.RowHandle) as Data.Product;

			if (product is not null && _productsToDelete.Contains(product))
			{
				e.Appearance.BackColor = Color.Red;
				e.Appearance.ForeColor = Color.White;
			}
		}
	}
}
