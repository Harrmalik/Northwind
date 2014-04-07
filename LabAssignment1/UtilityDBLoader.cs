using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Northwind
{
    class UtilityDBLoader
    {
        private static UtilityDBLoader anInstance = null;

        private UtilityDBLoader() { 
            //initialization goes here
        }

        public static UtilityDBLoader AnInstance
        {
            get
            {
                if (anInstance == null)
                {
                    anInstance = new UtilityDBLoader();
                }
                return anInstance;
            }
        }

        private static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Kyle\Documents\Database\Northwind.mdb";
        private static OleDbConnection aConnection = new OleDbConnection(connectionString);
        private OleDbCommand aCommand = aConnection.CreateCommand();

        public List<IListable> GetCategories()
        {
            List<IListable> categoryList = new List<IListable>();

            aConnection.Open();

            if (aConnection.State == System.Data.ConnectionState.Open) {
                aCommand.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories;";
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int anID = aReader["CategoryID"] as int? ?? -1;
                    string aCategoryName = aReader["CategoryName"] as string ?? String.Empty;
                    string aDescription = aReader["Description"] as string ?? String.Empty;

                    Category aCategory = new Category(anID, aCategoryName, aDescription);
                    categoryList.Add(aCategory);
                }
            }
            aConnection.Close();
            return categoryList;
        }

        public List<IListable> GetCustomers()
        {
            List<IListable> customerList = new List<IListable>();

            aCommand.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers";
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    string aCustomerID = aReader["CustomerID"] as string ?? String.Empty;
                    string aCompanyName = aReader["CompanyName"] as string ?? String.Empty;
                    string aContactName = aReader["ContactName"] as string ?? String.Empty;
                    string aContactTitle = aReader["ContactTitle"] as string ?? String.Empty;
                    string anAddress = aReader["Address"] as string ?? String.Empty;
                    string aCity = aReader["City"] as string ?? String.Empty;
                    string aRegion = aReader["Region"] as string ?? String.Empty;
                    string aPostalCode = aReader["PostalCode"] as string ?? String.Empty;
                    string aCountry = aReader["Country"] as string ?? String.Empty as string ?? String.Empty;
                    string aPhone = aReader["Phone"] as string ?? String.Empty;
                    string aFax = aReader["Fax"] as string ?? String.Empty;

                    Customer aCustomer = new Customer(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax);
                    customerList.Add(aCustomer);
                }
            }
            aConnection.Close();
            return customerList;
        }

        public List<IListable> GetEmployees()
        {
            List<IListable> employeesList = new List<IListable>();

            aCommand.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo FROM Employees";
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int anEmployeeID = aReader["EmployeeID"] as int? ?? -1;
                    string aLastName = aReader["LastName"] as string ?? String.Empty;
                    string aFirstName = aReader["FirstName"] as string ?? String.Empty;
                    string aTitle = aReader["Title"] as string ?? String.Empty;
                    string aTitleOfCourtesy = aReader["TitleOfCourtesy"] as string ?? String.Empty;
                    string aBirthDate = aReader["BirthDate"] as string ?? String.Empty;
                    //FIX DATES
                    string aHireDate = aReader["HireDate"].ToString() as string ?? String.Empty;
                    string anAddress = aReader["Address"].ToString() as string ?? String.Empty;
                    string aCity = aReader["City"] as string ?? String.Empty;
                    string aRegion = aReader["Region"] as string ?? String.Empty;
                    string aPostalCode = aReader["PostalCode"] as string ?? String.Empty;
                    string aCountry = aReader["Country"] as string ?? String.Empty;
                    string aHomePhone = aReader["HomePhone"] as string ?? String.Empty;
                    string anExtension = aReader["Extension"] as string ?? String.Empty;
                    string aNotes = aReader["Notes"] as string ?? String.Empty;
                    int aReportsTo = aReader["ReportsTo"] as int? ?? 0;

                    Employee anEmployee = new Employee(anEmployeeID, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, anAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, anExtension, aNotes, aReportsTo);
                    employeesList.Add(anEmployee);
                }
            }
            aConnection.Close();
            return employeesList;
        }

        public List<IListable> GetOrders()
        {
            List<IListable> ordersList = new List<IListable>();

            aCommand.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders";
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int anOrderID = aReader["OrderID"] as int? ?? -1;
                    string aCustomerID = aReader["CustomerID"] as string ?? String.Empty;
                    int anEmployeeID = aReader["EmployeeID"] as int? ?? -1;
                    string anOrderDate = aReader["OrderDate"] as string ?? String.Empty;
                    string aRequiredDate = aReader["RequiredDate"] as string ?? String.Empty;
                    string aShippedDate = aReader["ShippedDate"] as string ?? String.Empty;
                    int aShipVia = aReader["ShipVia"] as int? ?? -1;
                    //FIX DECIMAL HANDLING
                    double aFreight = (double)(decimal)aReader["Freight"];
                    string aShipName = aReader["ShipName"] as string ?? String.Empty;
                    string aShipAddress = aReader["ShipAddress"] as string ?? String.Empty;
                    string aShipCity = aReader["ShipCity"] as string ?? String.Empty;
                    string aShipRegion = aReader["ShipRegion"] as string ?? String.Empty;
                    string aShipPostalCode = aReader["ShipPostalCode"] as string ?? String.Empty;
                    string aShipCountry = aReader["ShipCountry"] as string ?? String.Empty;

                    Order anOrder = new Order(anOrderID, aCustomerID, anEmployeeID, anOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);
                    ordersList.Add(anOrder);
                }
            }
            aConnection.Close();
            return ordersList;
        }

        public List<IListable> GetOrderDetails()
        {
            List<IListable> orderDetailsList = new List<IListable>();
            
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open){
                aCommand.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int anOrderID = aReader["OrderID"] as int? ?? -1;
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aQuantity = (int)((Nullable<Int16>)aReader["Quantity"] ?? 0);
                    //FIX LOSS OF PRECISION 
                    double aDiscount = (double)((Nullable<Single>) aReader["Discount"] ?? 0);

                    OrderDetail anOrderDetail = new OrderDetail(anOrderID, aProductID, aUnitPrice, aQuantity, aDiscount);
                    orderDetailsList.Add(anOrderDetail);
                }
            }
            aConnection.Close();
            return orderDetailsList;
        }

        public List<IListable> GetDetailsByOrder(string inputID)
        {
            List<IListable> orderDetailsList = new List<IListable>();

            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                aCommand.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details] WHERE OrderID = " + inputID;
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int anOrderID = aReader["OrderID"] as int? ?? -1;
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aQuantity = (int)((Nullable<Int16>)aReader["Quantity"] ?? 0);
                    //FIX LOSS OF PRECISION 
                    double aDiscount = (double)((Nullable<Single>)aReader["Discount"] ?? 0);

                    OrderDetail anOrderDetail = new OrderDetail(anOrderID, aProductID, aUnitPrice, aQuantity, aDiscount);
                    orderDetailsList.Add(anOrderDetail);
                }
            }
            aConnection.Close();
            return orderDetailsList;
        }

        public List<IListable> GetProducts()
        {
            List<IListable> productsList = new List<IListable>();

            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                aCommand.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    string aProductName = aReader["ProductName"] as string ?? String.Empty;
                    int aSupplierID = aReader["SupplierID"] as int? ?? -1;
                    int aCategoryID = aReader["CategoryID"] as int? ?? -1;
                    string aQuantityPerUnit = aReader["QuantityPerUnit"] as string ?? String.Empty;
                    //CHECK ALL BELOW
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aUnitsInStock = (int)((Nullable<Int16>)aReader["UnitsInStock"] ?? 0);
                    int aUnitsOnOrder = (int)((Nullable<Int16>)aReader["UnitsOnOrder"] ?? 0);
                    int aReorderLevel = (int)((Nullable<Int16>)aReader["ReorderLevel"] ?? 0);
                    bool isDiscontinued = aReader["Discontinued"] as bool? ?? true;

                    Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, isDiscontinued);

                    productsList.Add(aProduct);
                }
            }
            aConnection.Close();
            return productsList;
        }

        public List<IListable> GetProductByID(string anID)
        {
            List<IListable> aList = new List<IListable>();

            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                aCommand.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE ProductID = " + anID;
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    string aProductName = aReader["ProductName"] as string ?? String.Empty;
                    int aSupplierID = aReader["SupplierID"] as int? ?? -1;
                    int aCategoryID = aReader["CategoryID"] as int? ?? -1;
                    string aQuantityPerUnit = aReader["QuantityPerUnit"] as string ?? String.Empty;
                    //CHECK ALL BELOW
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aUnitsInStock = (int)((Nullable<Int16>)aReader["UnitsInStock"] ?? 0);
                    int aUnitsOnOrder = (int)((Nullable<Int16>)aReader["UnitsOnOrder"] ?? 0);
                    int aReorderLevel = (int)((Nullable<Int16>)aReader["ReorderLevel"] ?? 0);
                    bool isDiscontinued = aReader["Discontinued"] as bool? ?? true;

                    Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, isDiscontinued);
                    aList.Add(aProduct);
                }
            }
            aConnection.Close();
            return aList;
        }

        public List<IListable> GetProductsByCategory(string inputID)
        {
            List<IListable> aList = new List<IListable>();

            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                aCommand.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE CategoryID = " + inputID;
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    string aProductName = aReader["ProductName"] as string ?? String.Empty;
                    int aSupplierID = aReader["SupplierID"] as int? ?? -1;
                    int aCategoryID = aReader["CategoryID"] as int? ?? -1;
                    string aQuantityPerUnit = aReader["QuantityPerUnit"] as string ?? String.Empty;
                    //CHECK ALL BELOW
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aUnitsInStock = (int)((Nullable<Int16>)aReader["UnitsInStock"] ?? 0);
                    int aUnitsOnOrder = (int)((Nullable<Int16>)aReader["UnitsOnOrder"] ?? 0);
                    int aReorderLevel = (int)((Nullable<Int16>)aReader["ReorderLevel"] ?? 0);
                    bool isDiscontinued = aReader["Discontinued"] as bool? ?? true;

                    Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, isDiscontinued);
                    aList.Add(aProduct);
                }
            }
            aConnection.Close();
            return aList;
        }

        public List<IListable> GetProductsByPrice(double min, double max)
        {
            List<IListable> aList = new List<IListable>();

            aConnection.Open();

            if (aConnection.State == ConnectionState.Open)
            {
                aCommand.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE UnitPrice BETWEEN " + min + " AND " + max; ;
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    string aProductName = aReader["ProductName"] as string ?? String.Empty;
                    int aSupplierID = aReader["SupplierID"] as int? ?? -1;
                    int aCategoryID = aReader["CategoryID"] as int? ?? -1;
                    string aQuantityPerUnit = aReader["QuantityPerUnit"] as string ?? String.Empty;
                    //CHECK ALL BELOW
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aUnitsInStock = (int)((Nullable<Int16>)aReader["UnitsInStock"] ?? 0);
                    int aUnitsOnOrder = (int)((Nullable<Int16>)aReader["UnitsOnOrder"] ?? 0);
                    int aReorderLevel = (int)((Nullable<Int16>)aReader["ReorderLevel"] ?? 0);
                    bool isDiscontinued = aReader["Discontinued"] as bool? ?? true;

                    Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, isDiscontinued);
                    aList.Add(aProduct);
                }
            }
            aConnection.Close();
            return aList;
        }

        public List<IListable> GetShippers()
        {
            List<IListable> shippersList = new List<IListable>();

            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                aCommand.CommandText = "SELECT ShipperID, CompanyName, Phone FROM Shippers";
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int aShipperID = aReader["ShipperID"] as int? ?? -1;
                    string aCompanyName = aReader["CompanyName"] as string ?? String.Empty;
                    string aPhone = aReader["Phone"] as string ?? String.Empty;

                    Shipper aShipper = new Shipper(aShipperID, aCompanyName, aPhone);
                    shippersList.Add(aShipper);
                }
            }
            aConnection.Close();
            return shippersList;
        }

        public List<IListable> GetSuppliers()
        {
            List<IListable> suppliersList = new List<IListable>();

            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                aCommand.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int aSupplierID = (int)aReader["SupplierID"];
                    string aCompanyName = (string)aReader["CompanyName"];
                    string aContactName = (string)aReader["ContactName"];
                    string aContactTitle = (string)aReader["ContactTitle"];
                    string anAddress = (string)aReader["Address"];
                    string aCity = (string)aReader["City"];
                    string aRegion = aReader["Region"] as string ?? String.Empty;
                    string aPostalCode = aReader["PostalCode"] as string ?? String.Empty;
                    string aCountry = (string)aReader["Country"];
                    string aPhone = (string)aReader["Phone"];
                    string aFax = aReader["Fax"] as string ?? String.Empty;
                    string aHomePage = aReader["HomePage"] as string ?? String.Empty;

                    Supplier aSupplier = new Supplier(aSupplierID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);
                    suppliersList.Add(aSupplier);
                }
            }
            aConnection.Close();
            return suppliersList;
        }
    }
}
