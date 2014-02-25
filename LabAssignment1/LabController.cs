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

        public List<IListable> GetOrderDetails()
        {
            return aLoader.GetOrderDetails();
        }

        public List<IListable> GetDetailsByOrder(string inputID) {
            return aLoader.GetDetailsByOrder(inputID);
        }

        public List<IListable> GetProducts()
        {
            return aLoader.GetProducts();
        }

        public List<IListable> GetProductsByID(string anID) 
        {
            return aLoader.GetProductByID(anID);
        }

        public List<IListable> GetProductsByCategory(string anID)
        {
            return aLoader.GetProductsByCategory(anID);
        }

        public List<IListable> GetProductsByPrice(double min, double max)
        {
            return aLoader.GetProductsByPrice(min, max);
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
