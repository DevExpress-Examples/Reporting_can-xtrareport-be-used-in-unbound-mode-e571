<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597932/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E571)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# Can XtraReport be used in unbound mode?


<p><strong>Description:</strong></p><p>Does XtraReports support unbound reports?  Most of our reports are supposed to be completely unbound to a database and will be generated from our object model.</p><br />
<br />
<p><strong>Solution:</strong></p><p>XtraReports can be used in the unbound mode.  Report elements can be unbound or linked to unbound (not database driven) data.  Please look at the attached sample.  It demonstrates both these situations: </p><p>1. The header labels (xrLabel3 and xrLabel4) are unbound.  Their Text property may be set both at design time and runtime.<br />
</p>

```cs


// this code is executed in the report's constructor

// unbound report elements

xrLabel3.Text = "Name";

xrLabel4.Text = "Phone";



```

<p>2. Detail labels (xrLabel1 and xrLabel2) are bound to a typed dataset, which is populated programmatically.  The labels are bound to the dataset programmatically in our sample.<br />
</p>

```cs


// this code is executed in the report's constructor

// unbound data source

Dataset1 myData = new Dataset1();

myData.Contact.AddContactRow("Ann", "1234567");

myData.Contact.AddContactRow("Bill", "1234455");

myData.Contact.AddContactRow("Clive", "1234000");

DataSource = myData.Contact;



// data bound report elements

xrLabel1.DataBindings.Add("Text", DataSource, "Name");

xrLabel2.DataBindings.Add("Text", DataSource, "Phone");



```

<p>If your data object is available at design time, you can bind labels via the designer.</p><p><strong>See also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/A715">Can XtraReports work with unbound data sources like arrays?</a><br />
<a href="https://www.devexpress.com/Support/Center/p/A2746">How to create a master-detail report using ITypedList datasource</a></p>

<br/>


