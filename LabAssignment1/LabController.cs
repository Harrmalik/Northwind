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
        static void Main(string[] args)
        {
            LabView aView = new LabView();

            UtilityXMLFileLoader aLoader = UtilityXMLFileLoader.AnInstance;

            //Instantiate list
            List<Category> categoryList = new List<Category>();
            //get method creates list of objects which is then stored
            categoryList = aLoader.GetCategories();

            List<Customer> customerList = new List<Customer>();
            customerList = aLoader.GetCustomers();

            List<Employee> employeesList = new List<Employee>();
            employeesList = aLoader.GetEmployees();

            List<Order> ordersList = new List<Order>();
            ordersList = aLoader.GetOrders();

            List<OrderDetail> orderDetailList = new List<OrderDetail>();
            orderDetailList = aLoader.GetOrderDetails();
            
            List<Product> productsList = new List<Product>();
            productsList = aLoader.GetProducts();

            List<Shipper> shippersList = new List<Shipper>();
            shippersList = aLoader.GetShippers();

            List<Supplier> suppliersList = new List<Supplier>();
            suppliersList = aLoader.GetSuppliers();

            //Begin by printing totals for each table to console
            aView.PrintTotals();
            //Then list individual records
            aView.Print(categoryList);
            aView.Print(customerList);
            aView.Print(employeesList);
            aView.Print(ordersList);
            aView.Print(orderDetailList);
            aView.Print(productsList);
            aView.Print(shippersList);
            aView.Print(suppliersList);
        }
    }
}
