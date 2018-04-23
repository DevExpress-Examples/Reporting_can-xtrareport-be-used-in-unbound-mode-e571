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


