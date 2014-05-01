using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Northwind
{
    class AdapterController
    {
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

        public DataTable GetDetailsByOrder(string anID)
        {
            return anAdapter.GetDetailsByOrder(anID);
        }

        public DataTable GetProducts()
        {
            return anAdapter.GetProducts();
        }

        public DataTable GetProductByID(string anID)
        {
            return anAdapter.GetProductByID(anID);
        }

        public DataTable GetProductsByCategory(string anID)
        {
            return anAdapter.GetProductsByCategory(anID);
        }

        public DataTable GetProductsByPrice(string min, string max)
        {
            return anAdapter.GetProductsByPrice(min, max);
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
