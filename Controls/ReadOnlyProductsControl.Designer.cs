namespace InventoryControl.Controls
{
	partial class ReadOnlyProductsControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			gridControl1 = new DevExpress.XtraGrid.GridControl();
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
			SuspendLayout();
			// 
			// gridControl1
			// 
			gridControl1.Dock = DockStyle.Fill;
			gridControl1.Location = new Point(0, 0);
			gridControl1.MainView = gridView1;
			gridControl1.Name = "gridControl1";
			gridControl1.Size = new Size(581, 418);
			gridControl1.TabIndex = 0;
			gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
			// 
			// gridView1
			// 
			gridView1.GridControl = gridControl1;
			gridView1.Name = "gridView1";
			gridView1.OptionsBehavior.Editable = false;
			// 
			// ReadOnlyProductsControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(gridControl1);
			Name = "ReadOnlyProductsControl";
			Size = new Size(581, 418);
			Load += ReadOnlyProductsControl_Load;
			((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}
