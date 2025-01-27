namespace InventoryControl.Controls.Analytics
{
	partial class SalesTrendsControl
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
			chartControl1 = new DevExpress.XtraCharts.ChartControl();
			panelControl1 = new DevExpress.XtraEditors.PanelControl();
			checkedComboBoxCategories = new DevExpress.XtraEditors.CheckedComboBoxEdit();
			((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
			panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)checkedComboBoxCategories.Properties).BeginInit();
			SuspendLayout();
			// 
			// chartControl1
			// 
			chartControl1.Dock = DockStyle.Fill;
			chartControl1.Location = new Point(2, 2);
			chartControl1.Name = "chartControl1";
			chartControl1.Size = new Size(511, 470);
			chartControl1.TabIndex = 0;
			// 
			// panelControl1
			// 
			panelControl1.Controls.Add(checkedComboBoxCategories);
			panelControl1.Controls.Add(chartControl1);
			panelControl1.Dock = DockStyle.Fill;
			panelControl1.Location = new Point(0, 0);
			panelControl1.Name = "panelControl1";
			panelControl1.Size = new Size(515, 474);
			panelControl1.TabIndex = 1;
			// 
			// checkedComboBoxCategories
			// 
			checkedComboBoxCategories.Dock = DockStyle.Right;
			checkedComboBoxCategories.Location = new Point(346, 2);
			checkedComboBoxCategories.Name = "checkedComboBoxCategories";
			checkedComboBoxCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			checkedComboBoxCategories.Size = new Size(167, 20);
			checkedComboBoxCategories.TabIndex = 1;
			checkedComboBoxCategories.EditValueChanged += checkedComboBoxCategories_EditValueChanged;
			// 
			// SalesTrendsControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panelControl1);
			Name = "SalesTrendsControl";
			Size = new Size(515, 474);
			Load += SalesTrendsControl_Load;
			((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
			panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)checkedComboBoxCategories.Properties).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraCharts.ChartControl chartControl1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxCategories;
	}
}
