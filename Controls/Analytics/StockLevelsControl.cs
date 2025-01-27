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
	public partial class StockLevelsControl : UserControl
	{
		public StockLevelsControl()
		{
			InitializeComponent();
		}

		private void StockLevelsControl_Load(object sender, EventArgs e)
		{
			using NorthwindContext context = new();

			var data = context.Categories
				.Select(category => new
				{
					category.CategoryName,
					TotalStock = category.Products.Sum(product => product.UnitsInStock),
				})
				.ToList();

			var stockLevelsSeries = new DevExpress.XtraCharts.Series("Stock Levels", DevExpress.XtraCharts.ViewType.Bar)
			{
				DataSource = data,
				ArgumentDataMember = "CategoryName"
			};
			stockLevelsSeries.ValueDataMembers.AddRange(["TotalStock"]);

			chartControl1.Series.Add(stockLevelsSeries);
		}
	}
}
