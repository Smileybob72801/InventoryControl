namespace InventoryControl.Controls.Analytics
{
	partial class ReordesAlertControl
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
			tileControl1 = new DevExpress.XtraEditors.TileControl();
			SuspendLayout();
			// 
			// tileControl1
			// 
			tileControl1.Dock = DockStyle.Fill;
			tileControl1.Location = new Point(0, 0);
			tileControl1.Name = "tileControl1";
			tileControl1.Size = new Size(626, 453);
			tileControl1.TabIndex = 0;
			tileControl1.Text = "tileControl1";
			// 
			// ReordesAlertControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tileControl1);
			Name = "ReordesAlertControl";
			Size = new Size(626, 453);
			Load += ReordesAlertControl_Load;
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraEditors.TileControl tileControl1;
	}
}
