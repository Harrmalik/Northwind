//Written by Kyle Goetschius
//Date: 1/29/2014
//Controller class- 

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
        UtilityXMLFileLoader aLoader = UtilityXMLFileLoader.AnInstance;
        UtilityDBLoader aDBLoader = UtilityDBLoader.AnInstance;
        UtilityDBAdapter anAdapter = UtilityDBAdapter.AnInstance;

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

        public List<IListable> GetDetailsByOrder(string inputID)
        {
            return aDBLoader.GetDetailsByOrder(inputID);
        }

        public List<IListable> GetProducts()
        {
            return aDBLoader.GetProducts();
        }

        public List<IListable> GetProductsByID(string anID)
        {
            return aDBLoader.GetProductByID(anID);
        }

        public List<IListable> GetProductsByCategory(string anID)
        {
            return aDBLoader.GetProductsByCategory(anID);
        }

        public List<IListable> GetProductsByPrice(double min, double max)
        {
            return aDBLoader.GetProductsByPrice(min, max);
        }

        public DataTable GetShippers()
        {
            return anAdapter.GetShippers();
        }

        public DataTable GetSuppliers()
        {
            return anAdapter.GetSuppliers();
        } 
    }
}
