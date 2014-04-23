using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Northwind
{
    class UtilityDBAdapter
    {
        //Connection Object
        private static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Kyle\Documents\Database\Northwind.mdb";
        private static OleDbConnection aConnection = new OleDbConnection(connectionString);

        //Command Object
        private static OleDbCommand aCommand = aConnection.CreateCommand();

        private static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);

        private static DataSet aDataSet = new DataSet();

        private static UtilityDBAdapter anInstance = null;

        public static UtilityDBAdapter AnInstance
        {
            get
            {
                if (anInstance == null)
                {
                    anInstance = new UtilityDBAdapter();
                }
                return anInstance;
            }
        }

        private UtilityDBAdapter()
        {
            string categorySQL = "SELECT CategoryID, CategoryName, Description FROM Categories;";
            string customerSQL = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers";
            string employeeSQL = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo FROM Employees";
            string orderSQL = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders";
            string detailSQL = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";
            string productSQL = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
            string shipperSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers";
            string supplierSQL = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";

            aCommand.CommandText = categorySQL;
            anAdapter.Fill(aDataSet, "MyCategories");

            aCommand.CommandText = customerSQL;
            anAdapter.Fill(aDataSet, "MyCustomers");

            aCommand.CommandText = employeeSQL;
            anAdapter.Fill(aDataSet, "MyEmployees");

            aCommand.CommandText = orderSQL;
            anAdapter.Fill(aDataSet, "MyOrders");

            aCommand.CommandText = detailSQL;
            anAdapter.Fill(aDataSet, "MyOrderDetails");

            aCommand.CommandText = productSQL;
            anAdapter.Fill(aDataSet, "MyProducts");

            aCommand.CommandText = shipperSQL;
            anAdapter.Fill(aDataSet, "MyShippers");

            aCommand.CommandText = supplierSQL;
            anAdapter.Fill(aDataSet, "MySuppliers");
        }

        public string GetCategories() {
            string output = "-=CATEGORIES=-\n";
            foreach (DataRow aRow in aDataSet.Tables["MyCategories"].Rows) {
                output +="#" + aRow["CategoryID"] + ": " + aRow["CategoryName"] + "\n";
                output += aRow["Description"] + "\n\n";
            }
            return output;
        }
    }
}
