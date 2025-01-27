using DevExpress.Spreadsheet.Charts;
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
	public partial class TopProductsAnalyticsControl : UserControl
	{
		public TopProductsAnalyticsControl()
		{
			InitializeComponent();
		}

		private void TopProductsAnalyticsControl_Load(object sender, EventArgs e)
		{
			using NorthwindContext context = new();

			int numberOfTopProducts = 10;

			var topProducts = context.OrderDetails
				.GroupBy(orderDetail => new
				{
					orderDetail.Product.ProductName
				})
				.Select(group => new
				{
					group.Key.ProductName,
					TotalRevenue = group.Sum(orderDetail => orderDetail.UnitPrice * orderDetail.Quantity * (1m - (decimal)orderDetail.Discount))
				})
				.OrderByDescending(product => product.TotalRevenue)
				.Take(numberOfTopProducts)
				.ToList();

			DevExpress.XtraCharts.Series series = new("Top Products", ViewType.Bar)
			{
				DataSource = topProducts,
				ArgumentDataMember = "ProductName"
			};
			series.ValueDataMembers.AddRange(["TotalRevenue"]);
			
			CutomizeColor(series, Color.Green);

			chartControl1.Series.Add(series);

			CustomizeChart(chartControl1);
		}

		private static void CutomizeColor(DevExpress.XtraCharts.Series series, Color color)
		{
			if (series.View is SideBySideBarSeriesView view)
			{
				view.Color = color;
			}
		}

		private void CustomizeChart(ChartControl chartControl)
		{
			XYDiagram? diagram = chartControl.Diagram as XYDiagram;

			if (diagram is not null)
			{
				diagram.AxisX.Title.Text = "Product Name";
				diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
				diagram.AxisY.Title.Text = "Total Revenue";
				diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
				diagram.AxisX.Label.TextPattern = "{A}";
				diagram.AxisY.Label.TextPattern = "{V:C}"; // Currency format
			}
		}
	}
}
