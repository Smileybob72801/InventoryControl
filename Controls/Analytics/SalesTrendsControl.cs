using DevExpress.XtraCharts;
using DevExpress.XtraEditors.Filtering.Templates;
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
	public partial class SalesTrendsControl : UserControl
	{
		public SalesTrendsControl()
		{
			InitializeComponent();
		}

		private void LoadCategories()
		{
			using NorthwindContext context = new();

			var categories = context.Categories
				.Select(category => new
				{
					category.CategoryId,
					category.CategoryName
				})
				.OrderBy(category => category.CategoryName)
				.ToList();

			checkedComboBoxCategories.Properties.Items.Clear();

			foreach (var category in categories)
			{
				checkedComboBoxCategories.Properties.Items.Add(new
					DevExpress.XtraEditors.Controls.CheckedListBoxItem(
						category.CategoryId, category.CategoryName, CheckState.Checked));
			}
		}

		private void SalesTrendsControl_Load(object sender, EventArgs e)
		{
			LoadCategories();
			LoadChartData();
		}

		private void CustomizeChart(ChartControl chartControl)
		{
			var diagram = chartControl.Diagram as XYDiagram;
			if (diagram != null)
			{
				diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month;
				diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Month;
				diagram.AxisX.Label.TextPattern = "{A:MMM yyyy}";
				diagram.AxisY.Label.TextPattern = "{V:C}"; // Currency format

				chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
			}
		}

		private void LoadChartData()
		{
			using NorthwindContext context = new();

			var selectedCategoryIds = checkedComboBoxCategories.Properties.Items
				.OfType<DevExpress.XtraEditors.Controls.CheckedListBoxItem>()
				.Where(item => item.CheckState == CheckState.Checked)
				.Select(item => (int)item.Value)
				.ToList();

			var filteredOrderDetails = context.OrderDetails
				.Where(orderDetails => orderDetails.Order.OrderDate.HasValue &&
					selectedCategoryIds.Contains(orderDetails.Product.CategoryId ?? 0));

			var groupedSalesData = filteredOrderDetails
				.GroupBy(orderDetails => new
				{
					orderDetails.Product.CategoryId,
					Year = orderDetails.Order.OrderDate.Value.Year,
					Month = orderDetails.Order.OrderDate.Value.Month
				});

			var aggregatedSalesData = groupedSalesData
				.Select(group => new
				{
					CategoryId = group.Key.CategoryId,
					Year = group.Key.Year,
					Month = group.Key.Month,
					TotalSales = group.Sum(orderDetails =>
						orderDetails.UnitPrice * orderDetails.Quantity * (decimal)(1 - orderDetails.Discount))
				})
				.AsEnumerable();

			var salesData = aggregatedSalesData
				.Select(data => new
				{
					CategoryId = data.CategoryId,
					CategoryName = checkedComboBoxCategories.Properties.Items
						.OfType<DevExpress.XtraEditors.Controls.CheckedListBoxItem>()
						.FirstOrDefault(item => (int)item.Value == data.CategoryId)?.Description ?? "Unknown",
					Period = new DateTime(data.Year, data.Month, 1),
					data.TotalSales
				})
				.ToList();
			
			chartControl1.Series.Clear();
			
			foreach (var categoryId in selectedCategoryIds)
			{
				var categorySales = salesData
					.Where(s => s.CategoryId == categoryId)
					.OrderBy(s => s.Period)
					.ToList();

				if (categorySales.Any())
				{
					Series series = new($"{categorySales.First().CategoryName} Sales", ViewType.Line)
					{
						DataSource = categorySales,
						ArgumentDataMember = "Period"
					};
					series.ValueDataMembers.AddRange(["TotalSales"]);

					chartControl1.Series.Add(series);
				}
			}

			CustomizeChart(chartControl1);
		}

		private void checkedComboBoxCategories_EditValueChanged(object sender, EventArgs e)
		{
			LoadChartData();
		}
	}
}
