//Written by Kyle Goetschius
//Date: 1/29/2014
//Controller class- Used with UtilityDB Loader to pass object lists between model & view

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Northwind
{
    public class Controller
    {
        //UtilityXMLFileLoader aLoader = UtilityXMLFileLoader.AnInstance;
        UtilityDBLoader aDBLoader = UtilityDBLoader.AnInstance;

        public List<IListable> GetCategories()
        {
             return aDBLoader.GetCategories();
        }

        public List<IListable> GetCustomers()
        {
            return aDBLoader.GetCustomers();
        }

        public List<IListable> GetEmployees()
        {
            return aDBLoader.GetEmployees();
        }

        public List<IListable> GetOrders()
        {
            return aDBLoader.GetOrders();
        }

        public List<IListable> GetOrderDetails()
        {
            return aDBLoader.GetOrderDetails();
        }

        //accepts string as input to work easily with Console.ReadLine()
        public List<IListable> GetDetailsByOrder(string inputID)
        {
            return aDBLoader.GetDetailsByOrder(inputID);
        }

        public List<IListable> GetProducts()
        {
            return aDBLoader.GetProducts();
        }

        //accepts string as input to work easily with Console.ReadLine()
        public List<IListable> GetProductsByID(string anID)
        {
            return aDBLoader.GetProductByID(anID);
        }

        //accepts string as input to work easily with Console.ReadLine()
        public List<IListable> GetProductsByCategory(string anID)
        {
            return aDBLoader.GetProductsByCategory(anID);
        }

        //prices should be converted to Doubles before use
        public List<IListable> GetProductsByPrice(double min, double max)
        {
            return aDBLoader.GetProductsByPrice(min, max);
        }

        public List<IListable> GetShippers()
        {
            return aDBLoader.GetShippers();
        }

        public List<IListable> GetSuppliers()
        {
            return aDBLoader.GetSuppliers();
        } 
    }
}
