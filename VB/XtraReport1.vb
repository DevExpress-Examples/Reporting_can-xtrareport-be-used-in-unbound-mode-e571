Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace Unbound
	''' <summary>
	''' Summary description for XtraReport1.
	''' </summary>
	Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			''' <summary>
			''' Required for Windows.Forms Class Composition Designer support
			''' </summary>
			InitializeComponent()

			' unbound data source
			Dim myData As New Dataset1()
			myData.Contact.AddContactRow("Ann", "1234567")
			myData.Contact.AddContactRow("Bill", "1234455")
			myData.Contact.AddContactRow("Clive", "1234000")
			DataSource = myData.Contact

			' unbound report elements
			xrLabel3.Text = "Name"
			xrLabel4.Text = "Phone"

			' data bound report elements
			xrLabel1.DataBindings.Add("Text", DataSource, "Name")
			xrLabel2.DataBindings.Add("Text", DataSource, "Phone")
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.Detail.Height = 21
			Me.Detail.Name = "Detail"
			' 
			' PageHeader
			' 
			Me.PageHeader.Height = 30
			Me.PageHeader.Name = "PageHeader"
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Location = New System.Drawing.Point(67, 0)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Size = New System.Drawing.Size(100, 20)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Location = New System.Drawing.Point(207, 0)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Size = New System.Drawing.Size(100, 20)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel4})
			Me.GroupHeader1.Height = 20
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel4.Location = New System.Drawing.Point(207, 0)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.ParentStyleUsing.UseFont = False
			Me.xrLabel4.Size = New System.Drawing.Size(100, 20)
			Me.xrLabel4.Text = "xrLabel4"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel3.Location = New System.Drawing.Point(67, 0)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.ParentStyleUsing.UseFont = False
			Me.xrLabel3.Size = New System.Drawing.Size(100, 20)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1})
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
		#End Region
	End Class
End Namespace
