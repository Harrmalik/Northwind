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

        public List<IListable> GetOrderDetails()
        {
            List<IListable> orderDetailList = new List<IListable>();
            orderDetailList = aLoader.GetOrderDetails();

            return orderDetailList;
        }

        public List<IListable> GetProductByID(string anID) {
            aLoader.GetProducts();
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

        public List<IListable> GetProducts()
        {
            List<IListable> productsList = new List<IListable>();
            productsList = aLoader.GetProducts();

            return productsList;
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
