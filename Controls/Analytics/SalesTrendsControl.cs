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
	public partial class SalesTrendsControl : UserControl
	{
		public SalesTrendsControl()
		{
			InitializeComponent();
		}

		private void SalesTrendsControl_Load(object sender, EventArgs e)
		{
			using NorthwindContext context = new();

			var monthlySales = context.OrderDetails
				.Where(od => od.Order.OrderDate.HasValue)
				.GroupBy(orderDetails => new { orderDetails.Order.OrderDate.Value.Year, orderDetails.Order.OrderDate.Value.Month }) // Group by Year and Month
				.Select(group => new
				{
					Year = group.Key.Year,
					Month = group.Key.Month,
					TotalSales = group.Sum(od => od.UnitPrice * od.Quantity * (decimal)(1 - od.Discount))
				})
				.AsEnumerable()
				.Select(group => new
				{
					Period = new DateTime(group.Year, group.Month, 1),
					group.TotalSales
				})
				.OrderBy(g => g.Period)
				.ToList();

			Series series = new("Monthly Sales", ViewType.Line)
			{
				DataSource = monthlySales,
				ArgumentDataMember = "Period"
			};
			series.ValueDataMembers.AddRange(["TotalSales"]);

			CustomizeChart(chartControl1);

			chartControl1.Series.Add(series);
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
			}
		}
	}
}
