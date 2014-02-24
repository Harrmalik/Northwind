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
            return aLoader.GetCategories();
        }

        public List<IListable> GetCustomers()
        {
            return aLoader.GetCustomers();
        }

        public List<IListable> GetEmployees()
        {
            return aLoader.GetEmployees();
        }

        public List<IListable> GetOrders()
        {
            return aLoader.GetOrders();
        }

        public List<IListable> GetOrderDetails(string input)
        {
            switch (input) 
            { 
                case "1":
                    Console.WriteLine("Enter an OrderID");
                    return aLoader.GetDetailsByOrder(Console.ReadLine());
                case "2":
                    return aLoader.GetOrderDetails();
                default:
                    List<IListable> errorList = new List<IListable>();
                    return errorList;
            }
        }

        public List<IListable> GetProducts(string anID)
        {
            switch (anID)
            {
                case "1":
                    Console.WriteLine("Enter a Product ID");
                    return aLoader.GetProductByID(Console.ReadLine());
                case "2":
                    Console.WriteLine("Enter a Category ID");
                    return aLoader.GetProductsByCategory(Console.ReadLine());
                case "3":
                    Console.WriteLine("Enter a minimum price.");
                    double min = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a maximum price.");
                    double max = Double.Parse(Console.ReadLine());
                    return aLoader.GetProductsByPrice(min, max);
                case "4":
                    return aLoader.GetProducts();
                default:
                    List<IListable> errorList = new List<IListable>();
                    return errorList;
            }
        }

        public List<IListable> GetShippers()
        {
            return aLoader.GetShippers();
        }

        public List<IListable> GetSuppliers()
        {
            return aLoader.GetSuppliers();
        } 
    }
}
