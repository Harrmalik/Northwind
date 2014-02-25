//Written by Kyle Goetschius
//Date: 1/29/2014
//Loads data from XML file, returns List

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Northwind
{
    public class UtilityXMLFileLoader
    {
        //Load XML from files
        private XDocument aCategoryFile = XDocument.Load(@"C:\Users\Kyle\Documents\VisualProg\NorthwindXML\Categories.xml");
        private XDocument aCustomerFile = XDocument.Load(@"C:\Users\Kyle\Documents\VisualProg\NorthwindXML\Customers.xml");
        private XDocument anEmployeeFile = XDocument.Load(@"C:\Users\Kyle\Documents\VisualProg\NorthwindXML\Employees.xml");
        private XDocument anOrderFile = XDocument.Load(@"C:\Users\Kyle\Documents\VisualProg\NorthwindXML\Orders.xml");
        private XDocument anOrderDetailFile = XDocument.Load(@"C:\Users\Kyle\Documents\VisualProg\NorthwindXML\OrderDetails.xml");
        private XDocument aProductsFile = XDocument.Load(@"C:\Users\Kyle\Documents\VisualProg\NorthwindXML\Products.xml");
        private XDocument aShippersFile = XDocument.Load(@"C:\Users\Kyle\Documents\VisualProg\NorthwindXML\Shippers.xml");
        private XDocument aSuppliersFile = XDocument.Load(@"C:\Users\Kyle\Documents\VisualProg\NorthwindXML\Suppliers.xml");

        private static UtilityXMLFileLoader anInstance = null;

        private UtilityXMLFileLoader() { 
            //initialization goes here
        }

        public static UtilityXMLFileLoader AnInstance
        {
            get
            {
                if (anInstance == null)
                {
                    //can call private constructor bc this method is w/in same class
                    anInstance = new UtilityXMLFileLoader();
                }
                return anInstance;
            }
        }
        
        public List<IListable> GetCategories() {

            int anID;
            string aCategoryName;
            string aDescription;
            List<IListable> categoryList = new List<IListable>();

            //Look for class name, treat each element as a new row.
            IEnumerable<XElement> rows = from row in aCategoryFile.Descendants("Category")
                                         select row;

            //For each row: store attributes, pass to constructor, append to list
            foreach (var aRow in rows)
            {
                //store attribute if found, substitute value on right if null
                anID = (int?)aRow.Attribute("CategoryID") ?? -1;
                aCategoryName = (string)aRow.Attribute("CategoryName") ?? "N/A";
                aDescription = (string)aRow.Attribute("Description") ?? "N/A";

                Category aCategory = new Category(anID, aCategoryName, aDescription);
                categoryList.Add(aCategory);
            }
            return categoryList;
        }

        public List<IListable> GetCustomers()
        {
            string aCustomerID;
            string aCompanyName;
            string aContactName;
            string aContactTitle;
            string anAddress;
            string aCity;
            string aRegion;
            string aPostalCode;
            string aCountry;
            string aPhone;
            string aFax;
            List<IListable> customerList = new List<IListable>();

            IEnumerable<XElement> rows = from row in aCustomerFile.Descendants("Customer")
                                         select row;

            foreach (var aRow in rows)
            {
                aCustomerID = (string)aRow.Attribute("CustomerID") ?? "N/A";
                aCompanyName = (string)aRow.Attribute("CompanyName") ?? "N/A";
                aContactName = (string)aRow.Attribute("ContactName") ?? "N/A";
                aContactTitle = (string)aRow.Attribute("ContactTitle") ?? "N/A";
                anAddress = (string)aRow.Attribute("Address") ?? "N/A";
                aCity = (string)aRow.Attribute("City") ?? "N/A";
                aRegion = (string)aRow.Attribute("Region") ?? "N/A";
                aPostalCode = (string)aRow.Attribute("PostalCode") ?? "N/A";
                aCountry = (string)aRow.Attribute("Country") ?? "N/A";
                aPhone = (string)aRow.Attribute("Phone") ?? "N/A";
                aFax = (string)aRow.Attribute("Fax") ?? "N/A";

                Customer aCustomer = new Customer(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax);
                customerList.Add(aCustomer);
            }

            return customerList;
        }

        public List<IListable> GetEmployees()
        {
            int anEmployeeID;
            string aLastName;
            string aFirstName;
            string aTitle;
            string aTitleOfCourtesy;
            string aBirthDate;
            string aHireDate;
            string anAddress;
            string aCity;
            string aRegion;
            string aPostalCode;
            string aCountry;
            string aHomePhone;
            string anExtension;
            string aNotes;
            int aReportsTo;

            List<IListable> employeesList = new List<IListable>();

            IEnumerable<XElement> rows = from row in anEmployeeFile.Descendants("Employee")
                                         select row;

            foreach (var aRow in rows)
            {
                anEmployeeID = (int?)aRow.Attribute("EmployeeID") ?? -1;
                aLastName = (string)aRow.Attribute("LastName") ?? "N/A";
                aFirstName = (string)aRow.Attribute("FirstName") ?? "N/A";
                aTitle = (string)aRow.Attribute("Title") ?? "N/A";
                aTitleOfCourtesy = (string)aRow.Attribute("TitleOfCourtesy") ?? "N/A";
                aBirthDate = (string)aRow.Attribute("BirthDate") ?? "N/A";
                aHireDate = (string)aRow.Attribute("HireDate") ?? "N/A";
                anAddress = (string)aRow.Attribute("Address") ?? "N/A";
                aCity = (string)aRow.Attribute("City") ?? "N/A";
                aRegion = (string)aRow.Attribute("Region") ?? "N/A";
                aPostalCode = (string)aRow.Attribute("PostalCode") ?? "N/A";
                aCountry = (string)aRow.Attribute("Country") ?? "N/A";
                aHomePhone = (string)aRow.Attribute("HomePhone") ?? "N/A";
                anExtension = (string)aRow.Attribute("Extension") ?? "N/A";
                aNotes = (string)aRow.Attribute("Notes") ?? "N/A";
                aReportsTo = (int?)aRow.Attribute("ReportsTo") ?? -1;

                Employee anEmployee = new Employee(anEmployeeID, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, anAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, anExtension, aNotes, aReportsTo);
                employeesList.Add(anEmployee);
            }

            return employeesList;
        }

        public List<IListable> GetOrders()
        {
            int anOrderID;
            string aCustomerID;
            int anEmployeeID;
            string anOrderDate;
            string aRequiredDate;
            string aShippedDate;
            int aShipVia;
            double aFreight;
            string aShipName;
            string aShipAddress;
            string aShipCity;
            string aShipRegion;
            string aShipPostalCode;
            string aShipCountry;

            List<IListable> ordersList = new List<IListable>();

            IEnumerable<XElement> rows = from row in anOrderFile.Descendants("Order")
                                         select row;

            foreach (var aRow in rows)
            {
                anOrderID = (int?)aRow.Attribute("OrderID") ?? -1;
                aCustomerID = (string)aRow.Attribute("CustomerID") ?? "N/A";
                anEmployeeID = (int?)aRow.Attribute("EmployeeID") ?? -1;
                anOrderDate = (string)aRow.Attribute("OrderDate") ?? "N/A";
                aRequiredDate = (string)aRow.Attribute("RequiredDate") ?? "N/A";
                aShippedDate = (string)aRow.Attribute("ShippedDate") ?? "N/A";
                aShipVia = (int?)aRow.Attribute("ShipVia") ?? -1;
                aFreight = (double?)aRow.Attribute("Freight") ?? 999999.99;
                aShipName = (string)aRow.Attribute("ShipName") ?? "N/A";
                aShipAddress = (string)aRow.Attribute("ShipAddress") ?? "N/A";
                aShipCity = (string)aRow.Attribute("ShipCity") ?? "N/A";
                aShipRegion = (string)aRow.Attribute("ShipRegion") ?? "N/A";
                aShipPostalCode = (string)aRow.Attribute("ShipPostalCode") ?? "N/A";
                aShipCountry = (string)aRow.Attribute("ShipCountry") ?? "N/A";

                Order anOrder = new Order(anOrderID, aCustomerID, anEmployeeID, anOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);
                ordersList.Add(anOrder);
            }

            return ordersList;
        }

        public List<IListable> GetOrderDetails()
        {
            int anOrderID;
            int aProductID;
            double aUnitPrice;
            int aQuantity;
            double aDiscount;

            List<IListable> orderDetailsList = new List<IListable>();

            IEnumerable<XElement> rows = from row in anOrderDetailFile.Descendants("OrderDetail")
                                         select row;

            foreach (var aRow in rows)
            {
                anOrderID = (int?)aRow.Attribute("OrderID") ?? -1;
                aProductID = (int?)aRow.Attribute("ProductID") ?? -1;
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aQuantity = (int?)aRow.Attribute("Quantity") ?? 0;
                aDiscount = (double?)aRow.Attribute("Discount") ?? 0.00;

                OrderDetail anOrderDetail = new OrderDetail(anOrderID, aProductID, aUnitPrice, aQuantity, aDiscount);
                orderDetailsList.Add(anOrderDetail);
            }

            return orderDetailsList;
        }

        public List<IListable> GetDetailsByOrder(string inputID)
        {
            int anOrderID;
            int aProductID;
            double aUnitPrice;
            int aQuantity;
            double aDiscount;

            List<IListable> orderDetailsList = new List<IListable>();

            IEnumerable<XElement> rows = from row in anOrderDetailFile.Descendants("OrderDetail")
                                         where row.Attribute("OrderID").Value.Equals(inputID)
                                         select row;

            foreach (var aRow in rows)
            {
                anOrderID = (int?)aRow.Attribute("OrderID") ?? -1;
                aProductID = (int?)aRow.Attribute("ProductID") ?? -1;
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aQuantity = (int?)aRow.Attribute("Quantity") ?? 0;
                aDiscount = (double?)aRow.Attribute("Discount") ?? 0.00;

                OrderDetail anOrderDetail = new OrderDetail(anOrderID, aProductID, aUnitPrice, aQuantity, aDiscount);
                orderDetailsList.Add(anOrderDetail);
            }

            return orderDetailsList;
        }

        public List<IListable> GetProducts()
        {
            int aProductID;
            string aProductName;
            int aSupplierID;
            int aCategoryID;
            string aQuantityPerUnit;
            double aUnitPrice;
            int aUnitsInStock;
            int aUnitsOnOrder;
            int aReorderLevel;
            bool aDiscontinued;

            List<IListable> productsList = new List<IListable>();

            IEnumerable<XElement> rows = from row in aProductsFile.Descendants("Product")
                                         select row;

            foreach (var aRow in rows)
            {
                aProductID = (int?)aRow.Attribute("ProductID") ?? -1;
                aProductName = (string)aRow.Attribute("ProductName") ?? "N/A";
                aSupplierID = (int?)aRow.Attribute("SupplierID") ?? -1;
                aCategoryID = (int?)aRow.Attribute("CategoryID") ?? -1;
                aQuantityPerUnit = (string)aRow.Attribute("QuantityPerUnit") ?? "N/A";
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aUnitsInStock = (int?)aRow.Attribute("UnitsInStock") ?? 0;
                aUnitsOnOrder = (int?)aRow.Attribute("UnitsOnOrder") ?? 0;
                aReorderLevel = (int?)aRow.Attribute("ReorderLevel") ?? 0;
                aDiscontinued = (bool?)aRow.Attribute("Discontinued") ?? true;

                Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
                productsList.Add(aProduct);
            }

            return productsList;
        }

        public List<IListable> GetProductByID(string anID)
        {
            List<IListable> aList = new List<IListable>();

            int aProductID;
            string aProductName;
            int aSupplierID;
            int aCategoryID;
            string aQuantityPerUnit;
            double aUnitPrice;
            int aUnitsInStock;
            int aUnitsOnOrder;
            int aReorderLevel;
            bool aDiscontinued;

            IEnumerable<XElement> rows = from row in aProductsFile.Descendants("Product")
                                         where row.Attribute("ProductID").Value.Equals(anID)
                                         select row;

            foreach (var aRow in rows)
            {
                aProductID = (int?)aRow.Attribute("ProductID") ?? -1;
                aProductName = (string)aRow.Attribute("ProductName") ?? "N/A";
                aSupplierID = (int?)aRow.Attribute("SupplierID") ?? -1;
                aCategoryID = (int?)aRow.Attribute("CategoryID") ?? -1;
                aQuantityPerUnit = (string)aRow.Attribute("QuantityPerUnit") ?? "N/A";
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aUnitsInStock = (int?)aRow.Attribute("UnitsInStock") ?? 0;
                aUnitsOnOrder = (int?)aRow.Attribute("UnitsOnOrder") ?? 0;
                aReorderLevel = (int?)aRow.Attribute("ReorderLevel") ?? 0;
                aDiscontinued = (bool?)aRow.Attribute("Discontinued") ?? true;

                Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
                aList.Add(aProduct);
            }

            return aList;
        }

        public List<IListable> GetProductsByCategory(string inputID)
        {
            List<IListable> aList = new List<IListable>();

            int aProductID;
            string aProductName;
            int aSupplierID;
            int aCategoryID;
            string aQuantityPerUnit;
            double aUnitPrice;
            int aUnitsInStock;
            int aUnitsOnOrder;
            int aReorderLevel;
            bool aDiscontinued;

            IEnumerable<XElement> rows = from row in aProductsFile.Descendants("Product")
                                         where row.Attribute("CategoryID").Value.Equals(inputID)
                                         select row;

            foreach (var aRow in rows)
            {
                aProductID = (int?)aRow.Attribute("ProductID") ?? -1;
                aProductName = (string)aRow.Attribute("ProductName") ?? "N/A";
                aSupplierID = (int?)aRow.Attribute("SupplierID") ?? -1;
                aCategoryID = (int?)aRow.Attribute("CategoryID") ?? -1;
                aQuantityPerUnit = (string)aRow.Attribute("QuantityPerUnit") ?? "N/A";
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aUnitsInStock = (int?)aRow.Attribute("UnitsInStock") ?? 0;
                aUnitsOnOrder = (int?)aRow.Attribute("UnitsOnOrder") ?? 0;
                aReorderLevel = (int?)aRow.Attribute("ReorderLevel") ?? 0;
                aDiscontinued = (bool?)aRow.Attribute("Discontinued") ?? true;

                Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
                aList.Add(aProduct);
            }

            return aList;
        }

        public List<IListable> GetProductsByPrice(double min, double max)
        {
            List<IListable> aList = new List<IListable>();

            int aProductID;
            string aProductName;
            int aSupplierID;
            int aCategoryID;
            string aQuantityPerUnit;
            double aUnitPrice;
            int aUnitsInStock;
            int aUnitsOnOrder;
            int aReorderLevel;
            bool aDiscontinued;

            IEnumerable<XElement> rows = from row in aProductsFile.Descendants("Product")
                                         where Convert.ToDouble(row.Attribute("UnitPrice").Value) >= min
                                         && Convert.ToDouble(row.Attribute("UnitPrice").Value) <= max
                                         orderby row.Attribute("UnitPrice").Value
                                         select row;

            foreach (var aRow in rows)
            {
                aProductID = (int?)aRow.Attribute("ProductID") ?? -1;
                aProductName = (string)aRow.Attribute("ProductName") ?? "N/A";
                aSupplierID = (int?)aRow.Attribute("SupplierID") ?? -1;
                aCategoryID = (int?)aRow.Attribute("CategoryID") ?? -1;
                aQuantityPerUnit = (string)aRow.Attribute("QuantityPerUnit") ?? "N/A";
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aUnitsInStock = (int?)aRow.Attribute("UnitsInStock") ?? 0;
                aUnitsOnOrder = (int?)aRow.Attribute("UnitsOnOrder") ?? 0;
                aReorderLevel = (int?)aRow.Attribute("ReorderLevel") ?? 0;
                aDiscontinued = (bool?)aRow.Attribute("Discontinued") ?? true;

                Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
                aList.Add(aProduct);
            }

            return aList;
        }

        public List<IListable> GetShippers()
        {
            int aShipperID;
            string aCompanyName;
            string aPhone;

            List<IListable> shippersList = new List<IListable>();

            IEnumerable<XElement> rows = from row in aShippersFile.Descendants("Shipper")
                                         select row;

            foreach (var aRow in rows)
            {
                aShipperID = (int?)aRow.Attribute("ShipperID") ?? -1;
                aCompanyName = (string)aRow.Attribute("CompanyName") ?? "N/A";
                aPhone = (string)aRow.Attribute("Phone") ?? "N/A";

                Shipper aShipper = new Shipper(aShipperID, aCompanyName, aPhone);
                shippersList.Add(aShipper);
            }

            return shippersList;
        }

        public List<IListable> GetSuppliers()
        {
            int aSupplierID;
            string aCompanyName;
            string aContactName;
            string aContactTitle;
            string anAddress;
            string aCity;
            string aRegion;
            string aPostalCode;
            string aCountry;
            string aPhone;
            string aFax;
            string aHomePage;

            List<IListable> suppliersList = new List<IListable>();

            IEnumerable<XElement> rows = from row in aSuppliersFile.Descendants("Supplier")
                                         select row;

            foreach (var aRow in rows)
            {
                aSupplierID = (int?)aRow.Attribute("SupplierID") ?? -1;
                aCompanyName = (string)aRow.Attribute("CompanyName") ?? "N/A";
                aContactName = (string)aRow.Attribute("ContactName") ?? "N/A";
                aContactTitle = (string)aRow.Attribute("ContactTitle") ?? "N/A";
                anAddress = (string)aRow.Attribute("Address") ?? "N/A";
                aCity = (string)aRow.Attribute("City") ?? "N/A";
                aRegion = (string)aRow.Attribute("Region") ?? "N/A";
                aPostalCode = (string)aRow.Attribute("PostalCode") ?? "N/A";
                aCountry = (string)aRow.Attribute("Country") ?? "N/A";
                aPhone = (string)aRow.Attribute("Phone") ?? "N/A";
                aFax = (string)aRow.Attribute("Fax") ?? "N/A";
                aHomePage = (string)aRow.Attribute("HomePage") ?? "N/A";

                Supplier aSupplier = new Supplier(aSupplierID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);
                suppliersList.Add(aSupplier);
            }

            return suppliersList;
        }
    }
}
