using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryControl
{
	public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public MainView()
		{
			InitializeComponent();
			if (!mvvmContext1.IsDesignMode)
				InitializeBindings();
		}

		void InitializeBindings()
		{
			var fluent = mvvmContext1.OfType<MainViewModel>();
			// View and ViewModel Lifetime
			fluent.WithEvent(this, nameof(HandleCreated))
				.EventToCommand(x => x.OnCreate);
			fluent.WithEvent(this, nameof(HandleDestroyed))
				.EventToCommand(x => x.OnDestroy);
			// Bind the Title property to the Text
			fluent.SetBinding(this, view => view.Text, x => x.Title);
		}

		private void BtnManageProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ProductManagementControl productManagementControl = new();
			productManagementControl.Dock = DockStyle.Fill;

			panelControl1.Controls.Clear();

			panelControl1.Controls.Add(productManagementControl);
		}
	}
}
