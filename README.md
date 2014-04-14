Northwind
=========

A project that demonstrates loading data from Microsoft's Northwind database into objects. It uses a Model-View-Controller (MVC) architecture and loads information from either XML files or through a direct database connection.

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


## Views
`LabView.cs` - Outputs to console.

## Controllers
`LabController` - Routes requests from the view to the appropriate Utility (XML or Database).

## Utility Classes
`UtilityXMLFileLoader.cs` - Contains methods to load information from XML files and return lists.

`UtilityDBLoader.cs` - Contains methods to load information from database and return lists.
