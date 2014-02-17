//Written by Kyle Goetschius
//Date: 1/29/2014
//View class- Print() method outputs to console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class LabView
    {
        private LabController mainController;

        public LabView(LabController aController) {
            mainController = aController;
            this.PrintTotals();
        }

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
            output += "\nEnter the # of the records you'd like to see. \n";

            Console.Write(output);

            this.Print(this.selectTable(Console.ReadLine()));
        }
        
        public void Print(string aString) {
            Console.WriteLine(aString);
            Console.ReadLine();
        }

        public void Print(List<IListable> aList)
        {
            foreach (IListable aListable in aList) {
                Console.WriteLine(aListable.ToString());
            }
            Console.ReadLine();
        }

        public List<IListable> selectTable(string input)
        {
            List<IListable> aList = new List<IListable>();
            List<IListable> sucks = new List<IListable>();

            switch (input)
            {
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
        
        //public void Print(List<Category> aList)
        //{
        //    foreach (Category aCategory in aList)
        //    {
        //        Console.WriteLine(aCategory.ToString());
        //    }
        //    Console.ReadLine();
        //}
    }
}
