using DevExpress.XtraCharts;
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
	public partial class SupplierContributionControl : UserControl
	{
		public SupplierContributionControl()
		{
			InitializeComponent();
		}

		private void SupplierContributionControl_Load(object sender, EventArgs e)
		{
			using NorthwindContext context = new();

			var totalStock = context.Suppliers
				.SelectMany(s => s.Products)
				.Sum(p => p.UnitsInStock);

			if (totalStock is null || totalStock == 0)
			{
				MessageBox.Show("No stock data available.");
				return;
			}

			double contributionCutoff = 0.03;

			var supplierData = context.Suppliers
				.Select(supplier => new
				{
					supplier.CompanyName,
					TotalStock = supplier.Products.Sum(product => product.UnitsInStock)
				})
				.Where(supplier => supplier.TotalStock > 0)
				.AsEnumerable()
				.GroupBy(supplier => supplier.TotalStock > (contributionCutoff * totalStock))
				.SelectMany(group =>
				{
					if (group.Key) // Large contributors
					{
						return group;
					}
					else // Small contributors grouped into "Others"
					{
						return new[] { new { CompanyName = "Others", TotalStock = group.Sum(s => s.TotalStock) } }.AsEnumerable();
					}
				})
				.OrderByDescending(s => s.TotalStock)
				.ToList();


			Series series = new("Supplier Contribution", ViewType.Pie)
			{
				DataSource = supplierData,
				ArgumentDataMember = "CompanyName"
			};
			series.ValueDataMembers.AddRange(["TotalStock"]);

			chartControl1.Series.Add(series);

			series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
			PieSeriesLabel? label = series.Label as PieSeriesLabel;

			if (label is not null)
			{
				label.TextPattern = "{A}: {VP:P0}"; 
			}
		}
	}
}
