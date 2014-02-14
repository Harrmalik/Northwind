//Written by Kyle Goetschius
//Date: 1/29/2014
//Controller class- Instantiates/Initializes Model classes, passes ToString of each to View

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

        public List<IListable> selectTable(string input) {
            List<IListable> aList = new List<IListable>();
            List<IListable> sucks = new List<IListable>();
            
            switch (input) {
                case "1":
                    aList = this.GetCategories();
                    return aList;
                case "2":
                    aList = this.GetCustomers();
                    return aList;
                case "3":
                    aList = this.GetEmployees();
                    return aList;
                case "4":
                    aList = this.GetOrders();
                    return aList;
                case "5":
                    aList = this.GetOrderDetails();
                    return aList;
                case "6":
                    aList = this.GetProducts();
                    return aList;
                case "7":
                    aList = this.GetShippers();
                    return aList;
                case "8":
                    aList = this.GetSuppliers();
                    return aList;
                default: return sucks;
            }
        }


        //static void Main(string[] args)
        //{
        //    LabView aView = new LabView();

        //    UtilityXMLFileLoader aLoader = UtilityXMLFileLoader.AnInstance;

        //    //Instantiate list
        //    List<Category> categoryList = new List<Category>();
        //    //get method creates list of objects which is then stored
        //    categoryList = aLoader.GetCategories();

        //    List<Customer> customerList = new List<Customer>();
        //    customerList = aLoader.GetCustomers();

        //    List<Employee> employeesList = new List<Employee>();
        //    employeesList = aLoader.GetEmployees();

        //    List<Order> ordersList = new List<Order>();
        //    ordersList = aLoader.GetOrders();

        //    List<OrderDetail> orderDetailList = new List<OrderDetail>();
        //    orderDetailList = aLoader.GetOrderDetails();
            
        //    List<Product> productsList = new List<Product>();
        //    productsList = aLoader.GetProducts();

        //    List<Shipper> shippersList = new List<Shipper>();
        //    shippersList = aLoader.GetShippers();

        //    List<Supplier> suppliersList = new List<Supplier>();
        //    suppliersList = aLoader.GetSuppliers();

        //    //Begin by printing totals for each table to console
        //    aView.PrintTotals();
        //    //Then list individual records
        //    aView.Print(categoryList);
        //    aView.Print(customerList);
        //    aView.Print(employeesList);
        //    aView.Print(ordersList);
        //    aView.Print(orderDetailList);
        //    aView.Print(productsList);
        //    aView.Print(shippersList);
        //    aView.Print(suppliersList);
        //}
    }
}
