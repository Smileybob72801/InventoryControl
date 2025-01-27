namespace InventoryControl
{
	partial class ProductManagementControl
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagementControl));
			gridControl1 = new DevExpress.XtraGrid.GridControl();
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			panelControl1 = new DevExpress.XtraEditors.PanelControl();
			btnProductDelete = new DevExpress.XtraEditors.SimpleButton();
			btnAddNewProduct = new DevExpress.XtraEditors.SimpleButton();
			btnSaveProducts = new DevExpress.XtraEditors.SimpleButton();
			panelControl2 = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
			panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
			panelControl2.SuspendLayout();
			SuspendLayout();
			// 
			// gridControl1
			// 
			gridControl1.Dock = DockStyle.Fill;
			gridControl1.Location = new Point(2, 46);
			gridControl1.MainView = gridView1;
			gridControl1.Name = "gridControl1";
			gridControl1.Padding = new Padding(5);
			gridControl1.Size = new Size(796, 402);
			gridControl1.TabIndex = 3;
			gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
			// 
			// gridView1
			// 
			gridView1.GridControl = gridControl1;
			gridView1.Name = "gridView1";
			gridView1.RowStyle += gridView1_RowStyle;
			// 
			// panelControl1
			// 
			panelControl1.Controls.Add(btnProductDelete);
			panelControl1.Controls.Add(btnAddNewProduct);
			panelControl1.Controls.Add(btnSaveProducts);
			panelControl1.Dock = DockStyle.Top;
			panelControl1.Location = new Point(2, 2);
			panelControl1.Name = "panelControl1";
			panelControl1.Size = new Size(796, 44);
			panelControl1.TabIndex = 1;
			// 
			// btnProductDelete
			// 
			btnProductDelete.Dock = DockStyle.Left;
			btnProductDelete.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnProductDelete.ImageOptions.SvgImage");
			btnProductDelete.Location = new Point(76, 2);
			btnProductDelete.Name = "btnProductDelete";
			btnProductDelete.Size = new Size(37, 40);
			btnProductDelete.TabIndex = 3;
			btnProductDelete.Click += btnProductDelete_Click;
			// 
			// btnAddNewProduct
			// 
			btnAddNewProduct.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
			btnAddNewProduct.Dock = DockStyle.Left;
			btnAddNewProduct.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAddNewProduct.ImageOptions.SvgImage");
			btnAddNewProduct.Location = new Point(39, 2);
			btnAddNewProduct.Name = "btnAddNewProduct";
			btnAddNewProduct.Size = new Size(37, 40);
			btnAddNewProduct.TabIndex = 2;
			btnAddNewProduct.ToolTip = "Add a new product";
			btnAddNewProduct.Click += btnAddNewProduct_Click;
			// 
			// btnSaveProducts
			// 
			btnSaveProducts.Dock = DockStyle.Left;
			btnSaveProducts.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSaveProducts.ImageOptions.SvgImage");
			btnSaveProducts.Location = new Point(2, 2);
			btnSaveProducts.Name = "btnSaveProducts";
			btnSaveProducts.Size = new Size(37, 40);
			btnSaveProducts.TabIndex = 1;
			btnSaveProducts.ToolTip = "Save changes to the database.";
			btnSaveProducts.Click += BtnSaveProducts_Click;
			// 
			// panelControl2
			// 
			panelControl2.Controls.Add(gridControl1);
			panelControl2.Controls.Add(panelControl1);
			panelControl2.Dock = DockStyle.Fill;
			panelControl2.Location = new Point(0, 0);
			panelControl2.Name = "panelControl2";
			panelControl2.Size = new Size(800, 450);
			panelControl2.TabIndex = 4;
			// 
			// ProductManagementControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panelControl2);
			Name = "ProductManagementControl";
			Size = new Size(800, 450);
			Load += ProductManagementForm_Load;
			((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
			panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
			panelControl2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton btnSaveProducts;
		private DevExpress.XtraEditors.SimpleButton btnAddNewProduct;
		private DevExpress.XtraEditors.SimpleButton btnProductDelete;
		private DevExpress.XtraEditors.PanelControl panelControl2;
	}
}