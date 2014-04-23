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
        UtilityDBLoader aDBLoader = UtilityDBLoader.AnInstance;
        UtilityDBAdapter anAdapter = UtilityDBAdapter.AnInstance;

        public string GetCategories()
        {
             return anAdapter.GetCategories();
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
