Northwind
=========

A project that demonstrates multiple ways of loading sample data from Microsoft’s Northwind database using a Model – View – Controller (MVC) architecture. Two object-oriented approaches are included, one using XML files and the other using a database connection. A second approach that forgoes the use of model classes is demonstrated, instead transferring information using DataTables.

The project includes:

## Models
`Category.cs` - Stores ID number, category name and description.

`Customer.cs` - Stores customer ID and company contact info.

`Employee.cs` - Stores employee data including title, contact info, birth/hire dates and contact info.

`Order.cs` - Stores info about an order including who made it, how and where it's being shipped, and which employee is responsible.

`OrderDetail.cs` - Stores more detailed information about the items in an order including price, quantity and discounts.

`Product.cs` - Stores ID number, associated Category &amp; Supplier, price, quantity per unit, and information on stock levels.

`Shipper.cs` - Stores ID, name and phone number for shipping company.

`Supplier.cs` - Stores ID, name &amp; contact information for supplier. 


## View
`ConsoleView.cs` - Simple Console Interface
  + ConsoleView() - Constructor takes Controller instance as parameter
  + PrintTotals() - Initial run to get # of records in each table, prints menu
  + SelectTable() - Switch statement based on Console input offers user choice of which records to output
  + Print() - 3 overloads
    - String
    - List<IListable> Used with `UtilityDBLoader`
    - DataTable Used with `UtilityDBAdapter`

## Controllers
`Controller.cs` - Routes requests from the view to the UtilityDBLoader, returns Lists of Objects
`AdapterController.cs` - Routes requests from the view to the UtilityDBAdapter, returns DataTables

## Utility Classes
`UtilityXMLFileLoader.cs` - Loads information from XML files into objects using model classes and returns Lists.

`UtilityDBLoader.cs` - Loads information from database into objects using model classes and returns Lists.

`UtilityDBAdapter.cs` - Loads information from database into a DataSet, returns DataTables.
