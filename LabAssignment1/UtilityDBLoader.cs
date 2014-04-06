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
        static OleDbConnection aConnection = new OleDbConnection(connectionString);
        OleDbCommand aCommand = aConnection.CreateCommand();

        public List<IListable> GetCategories()
        {
            List<IListable> categoryList = new List<IListable>();

            aConnection.Open();

            if (aConnection.State == System.Data.ConnectionState.Open) {
                aCommand.CommandText = "SELECT * FROM Categories;";
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int anID = (int)aReader["CategoryID"];
                    string aCategoryName = (string)aReader["CategoryName"];
                    string aDescription = (string)aReader["Description"];

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

            aCommand.CommandText = "SELECT * FROM Customers";
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    string aCustomerID = (string)aReader["CustomerID"];
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

            aCommand.CommandText = "SELECT * FROM Employees";
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int anEmployeeID = (int)aReader["EmployeeID"];
                    string aLastName = (string)aReader["LastName"];
                    string aFirstName = (string)aReader["FirstName"];
                    string aTitle = (string)aReader["Title"];
                    string aTitleOfCourtesy = (string)aReader["TitleOfCourtesy"];
                    string aBirthDate = (string)aReader["BirthDate"].ToString();
                    string aHireDate = (string)aReader["HireDate"].ToString();
                    string anAddress = (string)aReader["Address"];
                    string aCity = (string)aReader["City"];
                    string aRegion = aReader["Region"] as string ?? String.Empty;
                    string aPostalCode = aReader["PostalCode"] as string ?? String.Empty;
                    string aCountry = (string)aReader["Country"];
                    string aHomePhone = (string)aReader["HomePhone"];
                    string anExtension = (string)aReader["Extension"];
                    string aNotes = (string)aReader["Notes"];
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

            aCommand.CommandText = "SELECT * FROM Orders";
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open) {
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int anOrderID = (int)aReader["OrderID"];
                    string aCustomerID = (string)aReader["CustomerID"];
                    int anEmployeeID = (int)aReader["EmployeeID"];
                    string anOrderDate = aReader["OrderDate"] as string ?? String.Empty;
                    string aRequiredDate = aReader["RequiredDate"] as string ?? String.Empty;
                    string aShippedDate = aReader["ShippedDate"] as string ?? String.Empty;
                    int aShipVia = (int)aReader["ShipVia"];
                    double aFreight = (double)(decimal)aReader["Freight"];
                    string aShipName = (string)aReader["ShipName"];
                    string aShipAddress = (string)aReader["ShipAddress"];
                    string aShipCity = (string)aReader["ShipCity"];
                    string aShipRegion = aReader["ShipRegion"] as string ?? String.Empty;
                    string aShipPostalCode = aReader["ShipPostalCode"] as string ?? String.Empty;
                    string aShipCountry = (string)aReader["ShipCountry"];

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
                aCommand.CommandText = "SELECT * FROM [Order Details]";
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int anOrderID = (int)aReader["OrderID"];
                    int aProductID = (int)aReader["ProductID"];
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aQuantity = (int)(Nullable<Int16>)aReader["Quantity"];
                    double aDiscount = (double)(Nullable<Single>)aReader["Discount"];

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
                aCommand.CommandText = "SELECT * FROM [Order Details] WHERE OrderID =" + inputID;
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int anOrderID = (int)aReader["OrderID"];
                    int aProductID = (int)aReader["ProductID"];
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aQuantity = (int)(Nullable<Int16>)aReader["Quantity"];
                    double aDiscount = (double)(Nullable<Single>)aReader["Discount"];

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
                aCommand.CommandText = "SELECT ProductId, ProductName, SupplierID, Products.CategoryId FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID WHERE CategoryName = 'Beverages';";
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {

                    int aProductId = (int)aReader["ProductId"];
                    string aProductName = (string)aReader["ProductName"];
                    int aSupplierId = (int)aReader["SupplierId"];
                    int aCategoryId = (int)aReader["CategoryId"];
                    //string aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                    //double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    //int aUnitsInStock = (short)aReader["UnitsInStock"];
                    //int aUnitsOnOrder = (short)aReader["UnitsOnOrder"];
                    //int aReorderLevel = (short)aReader["ReorderLevel"];
                    //bool isDiscontinued = (bool)aReader["Discontinued"];

                    Product aProduct = new Product(aProductId, aProductName, aSupplierId, aCategoryId);

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
                aCommand.CommandText = "SELECT * FROM Products WHERE ProductID = " + anID;
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int aProductID = (int)aReader["ProductID"];
                    string aProductName = (string)aReader["ProductName"];
                    int aSupplierID = (int)aReader["SupplierID"];
                    int aCategoryID = (int)aReader["CategoryID"];
                    string aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                    double aUnitPrice = (double)(Nullable<decimal>)aReader["UnitPrice"];
                    int aUnitsInStock = (int)(Nullable<Int16>)aReader["UnitsInStock"];
                    int aUnitsOnOrder = (int)(Nullable<Int16>)aReader["UnitsOnOrder"];
                    int aReorderLevel = (int)(Nullable<Int16>)aReader["ReorderLevel"];
                    bool aDiscontinued = (bool)aReader["Discontinued"];

                    Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
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
                aCommand.CommandText = "SELECT * FROM Products WHERE CategoryID = " + inputID;
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int aProductID = (int)aReader["ProductID"];
                    string aProductName = (string)aReader["ProductName"];
                    int aSupplierID = (int)aReader["SupplierID"];
                    int aCategoryID = (int)aReader["CategoryID"];
                    string aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                    double aUnitPrice = (double)(Nullable<decimal>)aReader["UnitPrice"];
                    int aUnitsInStock = (int)(Nullable<Int16>)aReader["UnitsInStock"];
                    int aUnitsOnOrder = (int)(Nullable<Int16>)aReader["UnitsOnOrder"];
                    int aReorderLevel = (int)(Nullable<Int16>)aReader["ReorderLevel"];
                    bool aDiscontinued = (bool)aReader["Discontinued"];

                    Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
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
                aCommand.CommandText = "SELECT * FROM Products WHERE UnitPrice BETWEEN " + min + " AND " + max; ;
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int aProductID = (int)aReader["ProductID"];
                    string aProductName = (string)aReader["ProductName"];
                    int aSupplierID = (int)aReader["SupplierID"];
                    int aCategoryID = (int)aReader["CategoryID"];
                    string aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                    double aUnitPrice = (double)(Nullable<decimal>)aReader["UnitPrice"];
                    int aUnitsInStock = (int)(Nullable<Int16>)aReader["UnitsInStock"];
                    int aUnitsOnOrder = (int)(Nullable<Int16>)aReader["UnitsOnOrder"];
                    int aReorderLevel = (int)(Nullable<Int16>)aReader["ReorderLevel"];
                    bool aDiscontinued = (bool)aReader["Discontinued"];

                    Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
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
                aCommand.CommandText = "SELECT * FROM Shippers";
                OleDbDataReader aReader = aCommand.ExecuteReader();

                while (aReader.Read())
                {
                    int aShipperID = (int)aReader["ShipperID"];
                    string aCompanyName = (string)aReader["CompanyName"];
                    string aPhone = (string)aReader["Phone"];

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
                aCommand.CommandText = "SELECT * FROM Suppliers";
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
