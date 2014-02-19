//Written by Kyle Goetschius
//Date: 1/29/2014
//Controller class- 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class LabController
    {
        UtilityXMLFileLoader aLoader = UtilityXMLFileLoader.AnInstance;

        public List<IListable> GetCategories()
        {
            List<IListable> categoryList = new List<IListable>();
            categoryList = aLoader.GetCategories();

            return categoryList;
        }

        public List<IListable> GetCustomers()
        {
            List<IListable> customerList = new List<IListable>();
            customerList = aLoader.GetCustomers();

            return customerList;
        }

        public List<IListable> GetEmployees()
        {
            List<IListable> employeeList = new List<IListable>();
            employeeList = aLoader.GetEmployees();

            return employeeList;
        }

        public List<IListable> GetOrders()
        {
            List<IListable> ordersList = new List<IListable>();
            ordersList = aLoader.GetOrders();

            return ordersList;
        }

        public List<IListable> GetOrderDetails(string input)
        {
            List<IListable> aList = new List<IListable>();

            switch (input) { 
                case "1":
                    Console.WriteLine("Enter an OrderID");
                    aList = aLoader.GetDetailsByOrder(Console.ReadLine());
                    return aList;
                case "2":
                    aList = aLoader.GetOrderDetails();
                    return aList;
                default:
                    List<IListable> errorList = new List<IListable>();
                    Error anError = new Error();
                    errorList.Add(anError);
                    return errorList;
            }
        }

        public List<IListable> GetProductByID(string anID) {
            if (Int32.Parse(anID) < Product.numProducts && Int32.Parse(anID) > 0)
            {
                return aLoader.GetProductByID(anID);
            }
            else
            {
                List<IListable> errorList = new List<IListable>();
                Error anError = new Error();
                errorList.Add(anError);
                return errorList;
            }
        }

        public List<IListable> GetProductsByCategory(string aCategoryID)
        {
            return aLoader.GetProductsByCategory(aCategoryID);
        }

        public List<IListable> GetProducts(string anID)
        {
            switch (anID)
            {
                case "1":
                    Console.WriteLine("Enter a Product ID");
                    List<IListable> aList = new List<IListable>();
                    aList = aLoader.GetProductByID(Console.ReadLine());
                    return aList;
                case "2":
                    Console.WriteLine("Enter a Category ID");
                    List<IListable> bList = new List<IListable>();
                    bList = aLoader.GetProductsByCategory(Console.ReadLine());
                    return bList;
                case "3":
                    List<IListable> cList = new List<IListable>();
                    cList = aLoader.GetProducts();
                    return cList;
                default:
                    List<IListable> errorList = new List<IListable>();
                    return errorList;
            }
        }

        public List<IListable> GetShippers()
        {
            List<IListable> shippersList = new List<IListable>();
            shippersList = aLoader.GetShippers();

            return shippersList;
        }

        public List<IListable> GetSuppliers()
        {
            List<IListable> suppliersList = new List<IListable>();
            suppliersList = aLoader.GetSuppliers();

            return suppliersList;
        }

        
    }
}
