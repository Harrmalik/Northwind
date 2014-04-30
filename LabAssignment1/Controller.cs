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

        public DataTable GetCategories()
        {
             return anAdapter.GetCategories();
        }

        public DataTable GetCustomers()
        {
            return anAdapter.GetCustomers();
        }

        public DataTable GetEmployees()
        {
            return anAdapter.GetEmployees();
        }

        public DataTable GetOrders()
        {
            return anAdapter.GetOrders();
        }

        public DataTable GetOrderDetails()
        {
            return anAdapter.GetOrderDetails();
        }

        public DataTable GetDetailsByOrder(string inputID)
        {
            //return aDBLoader.GetDetailsByOrder(inputID);
            var results = from aRow in anAdapter.GetOrderDetails().AsEnumerable()
                          where aRow.Field<int>("OrderID") == Int32.Parse(inputID)
                          select aRow;

            return results.CopyToDataTable();
        }

        public DataTable GetProducts()
        {
            return anAdapter.GetProducts();
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
