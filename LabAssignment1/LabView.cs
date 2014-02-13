//Written by Kyle Goetschius
//Date: 1/29/2014
//View class- Print() method outputs a string to console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class LabView
    {
        //Retrieves & prints total stored as static var for each table
        public void PrintTotals(){
            string output = "|___ENTRY TOTALS___| \n\n";
            output += Category.totalCount();
            output += Customer.totalCount();
            output += Employee.totalCount(); 
            output += Order.totalCount();
            output += OrderDetail.totalCount();
            output += Product.totalCount();
            output += Shipper.totalCount();
            output += Supplier.totalCount();

            Console.Write(output);
            Console.ReadLine();
        }
        
        public void Print(string aString) {
            Console.WriteLine(aString);
            Console.ReadLine();
        }
        
        public void Print(List<Category> aList)
        {
            foreach (Category aCategory in aList)
            {
                Console.WriteLine(aCategory.ToString());
            }
            Console.ReadLine();
        }

        public void Print(List<Customer> aList)
        {
            foreach (Customer aCustomer in aList)
            {
                Console.WriteLine(aCustomer.ToString());
            }
            Console.ReadLine();
        }

        public void Print(List<Employee> aList)
        {
            foreach (Employee anEmployee in aList)
            {
                Console.WriteLine(anEmployee.ToString());
            }
            Console.ReadLine();
        }

        public void Print(List<Order> aList)
        {
            foreach (Order anOrder in aList)
            {
                Console.WriteLine(anOrder.ToString());
            }
            Console.ReadLine();
        }

        public void Print(List<OrderDetail> aList)
        {
            foreach (OrderDetail anOrderDetail in aList)
            {
                Console.WriteLine(anOrderDetail.ToString());
            }
            Console.ReadLine();
        }

        public void Print(List<Product> aList)
        {
            foreach (Product aProduct in aList)
            {
                Console.WriteLine(aProduct.ToString());
            }
            Console.ReadLine();
        }

        public void Print(List<Shipper> aList)
        {
            foreach (Shipper aShipper in aList)
            {
                Console.WriteLine(aShipper.ToString());
            }
            Console.ReadLine();
        }

        public void Print(List<Supplier> aList)
        {
            foreach (Supplier aSupplier in aList)
            {
                Console.WriteLine(aSupplier.ToString());
            }
            Console.ReadLine();
        }
    }
}
