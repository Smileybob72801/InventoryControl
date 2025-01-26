namespace InventoryControl
{
    partial class MainView
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
			components = new System.ComponentModel.Container();
			ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(components);
			ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)mvvmContext1).BeginInit();
			SuspendLayout();
			// 
			// ribbonControl1
			// 
			ribbonControl1.ExpandCollapseItem.Id = 0;
			ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem });
			ribbonControl1.Location = new Point(0, 0);
			ribbonControl1.MaxItemId = 1;
			ribbonControl1.Name = "ribbonControl1";
			ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2 });
			ribbonControl1.Size = new Size(841, 158);
			// 
			// ribbonPage1
			// 
			ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
			ribbonPage1.Name = "ribbonPage1";
			ribbonPage1.Text = "ribbonPage1";
			// 
			// ribbonPageGroup1
			// 
			ribbonPageGroup1.Name = "ribbonPageGroup1";
			ribbonPageGroup1.Text = "ribbonPageGroup1";
			// 
			// mvvmContext1
			// 
			mvvmContext1.ContainerControl = this;
			// 
			// ribbonPage2
			// 
			ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
			ribbonPage2.Name = "ribbonPage2";
			ribbonPage2.Text = "ribbonPage2";
			// 
			// ribbonPageGroup2
			// 
			ribbonPageGroup2.Name = "ribbonPageGroup2";
			ribbonPageGroup2.Text = "ribbonPageGroup2";
			// 
			// ribbonPage3
			// 
			ribbonPage3.Name = "ribbonPage3";
			ribbonPage3.Text = "ribbonPage3";
			// 
			// MainView
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(841, 414);
			Controls.Add(ribbonControl1);
			Name = "MainView";
			Ribbon = ribbonControl1;
			Text = "{Title}";
			((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)mvvmContext1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
	}
}

