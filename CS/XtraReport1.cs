using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Unbound
{
	/// <summary>
	/// Summary description for XtraReport1.
	/// </summary>
	public class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
	{
		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel4;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public XtraReport1()
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			InitializeComponent();

			// unbound data source
			Dataset1 myData = new Dataset1();
			myData.Contact.AddContactRow("Ann", "1234567");
			myData.Contact.AddContactRow("Bill", "1234455");
			myData.Contact.AddContactRow("Clive", "1234000");
			DataSource = myData.Contact;

			// unbound report elements
			xrLabel3.Text = "Name";
			xrLabel4.Text = "Phone";
			
			// data bound report elements
			xrLabel1.DataBindings.Add("Text", DataSource, "Name");
			xrLabel2.DataBindings.Add("Text", DataSource, "Phone");
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
																						this.xrLabel2,
																						this.xrLabel1});
			this.Detail.Height = 21;
			this.Detail.Name = "Detail";
			// 
			// PageHeader
			// 
			this.PageHeader.Height = 30;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Height = 30;
			this.PageFooter.Name = "PageFooter";
			// 
			// xrLabel1
			// 
			this.xrLabel1.Location = new System.Drawing.Point(67, 0);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Size = new System.Drawing.Size(100, 20);
			this.xrLabel1.Text = "xrLabel1";
			// 
			// xrLabel2
			// 
			this.xrLabel2.Location = new System.Drawing.Point(207, 0);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Size = new System.Drawing.Size(100, 20);
			this.xrLabel2.Text = "xrLabel2";
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
																							  this.xrLabel3,
																							  this.xrLabel4});
			this.GroupHeader1.Height = 20;
			this.GroupHeader1.Name = "GroupHeader1";
			// 
			// xrLabel4
			// 
			this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrLabel4.Location = new System.Drawing.Point(207, 0);
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.ParentStyleUsing.UseFont = false;
			this.xrLabel4.Size = new System.Drawing.Size(100, 20);
			this.xrLabel4.Text = "xrLabel4";
			// 
			// xrLabel3
			// 
			this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrLabel3.Location = new System.Drawing.Point(67, 0);
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.ParentStyleUsing.UseFont = false;
			this.xrLabel3.Size = new System.Drawing.Size(100, 20);
			this.xrLabel3.Text = "xrLabel3";
			// 
			// XtraReport1
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
																		 this.Detail,
																		 this.PageHeader,
																		 this.PageFooter,
																		 this.GroupHeader1});
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion
	}
}
