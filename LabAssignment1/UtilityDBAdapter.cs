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
            
        }

        public DataTable GetCategories()
        {
            string categorySQL = "SELECT CategoryID, CategoryName, Description FROM Categories;";

            aCommand.CommandText = categorySQL;
            anAdapter.Fill(aDataSet, "MyCategories");

            return aDataSet.Tables["MyCategories"];
        }

        public DataTable GetCustomers()
        {
            string customerSQL = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers";

            aCommand.CommandText = customerSQL;
            anAdapter.Fill(aDataSet, "MyCustomers");

            return aDataSet.Tables["MyCustomers"];
        }

        public DataTable GetEmployees()
        {
            string employeeSQL = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo FROM Employees";
            aCommand.CommandText = employeeSQL;
            anAdapter.Fill(aDataSet, "MyEmployees");

            return aDataSet.Tables["MyEmployees"];
        }

        public DataTable GetOrders()
        {
            string orderSQL = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders";
            aCommand.CommandText = orderSQL;
            anAdapter.Fill(aDataSet, "MyOrders");

            return aDataSet.Tables["MyOrders"];
        }

        public DataTable GetOrderDetails()
        {
            string detailSQL = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";
            aCommand.CommandText = detailSQL;
            anAdapter.Fill(aDataSet, "MyOrderDetails");

            return aDataSet.Tables["MyOrderDetails"];
        }

        public DataTable GetDetailsByOrder(string anID) {
            string detailSQL = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";
            aCommand.CommandText = detailSQL;
            anAdapter.Fill(aDataSet, "MyOrderDetails");

            try
            {
                var results = from aRow in aDataSet.Tables["MyOrderDetails"].AsEnumerable()
                              where aRow.Field<int>("OrderID") == Int32.Parse(anID)
                              select aRow;

                return results.CopyToDataTable();
            }
            //If linq query throws an exception, return an empty DataTable.
            catch {
                var error = new DataTable();
                return error;
                
            }
        }

        public DataTable GetProducts()
        {
            string productSQL = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
            aCommand.CommandText = productSQL;
            anAdapter.Fill(aDataSet, "MyProducts");

            return aDataSet.Tables["MyProducts"];
        }

        public DataTable GetProductByID(string anID) {
            string productSQL = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
            aCommand.CommandText = productSQL;
            anAdapter.Fill(aDataSet, "MyProducts");

            DataTable aTable = aDataSet.Tables["MyProducts"];

            try
            {
                var results = from aRow in aTable.AsEnumerable()
                              where aRow.Field<int>("ProductID") == Int32.Parse(anID)
                              select aRow;

                return results.CopyToDataTable();
            }
            //If linq query throws an exception, return an empty DataTable.
            catch {
                DataTable error = new DataTable();
                return error;
            }
        }

        public DataTable GetProductsByCategory(string anID) {
            string productSQL = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
            aCommand.CommandText = productSQL;
            anAdapter.Fill(aDataSet, "MyProducts");

            DataTable aTable = aDataSet.Tables["MyProducts"];

            try
            {
                var results = from aRow in aTable.AsEnumerable()
                              where aRow.Field<int>("CategoryID") == Int32.Parse(anID)
                              select aRow;

                return results.CopyToDataTable();
            }
            //If linq query throws an exception, return an empty DataTable.
            catch {
                DataTable error = new DataTable();
                return error;
            }
        }

        public DataTable GetProductsByPrice(string min, string max) {
            string productSQL = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
            aCommand.CommandText = productSQL;
            anAdapter.Fill(aDataSet, "MyProducts");

            DataTable aTable = aDataSet.Tables["MyProducts"];

            try
            {
                var results = from aRow in aTable.AsEnumerable()
                              where aRow.Field<Decimal>("UnitPrice") >= Decimal.Parse(min) && aRow.Field<Decimal>("UnitPrice") <= Decimal.Parse(max)
                              select aRow;

                return results.CopyToDataTable();
            }
            //If linq query throws an exception, return an empty DataTable.
            catch {
                DataTable error = new DataTable();
                return error;
            }
            
        }

        public DataTable GetShippers()
        {
            string shipperSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers";
            aCommand.CommandText = shipperSQL;
            anAdapter.Fill(aDataSet, "MyShippers");

            return aDataSet.Tables["MyShippers"];
        }

        public DataTable GetSuppliers()
        {
            string supplierSQL = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";
            aCommand.CommandText = supplierSQL;
            anAdapter.Fill(aDataSet, "MySuppliers");

            return aDataSet.Tables["MySuppliers"];
        }
    }
}
