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
            
            mainController.GetCategories();
            mainController.GetCustomers();
            mainController.GetEmployees();
            mainController.GetOrders();
            mainController.GetOrderDetails();
            mainController.GetProducts();
            mainController.GetShippers();
            mainController.GetSuppliers();

            //Console.WriteLine("Enter the Product ID to view");
            //string anID = Console.ReadLine();
            //this.Print(mainController.GetProductByID(anID));
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

            this.selectTable(Console.ReadLine());

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

        public void selectTable(string input)
        {
            List<IListable> aList = new List<IListable>();
            List<IListable> sucks = new List<IListable>();

            switch (input)
            {
                case "1":
                    this.Print(mainController.GetCategories());
                    break;
                case "2":
                    this.Print(mainController.GetCustomers());
                    break;
                case "3":
                    this.Print(mainController.GetEmployees());
                    break;
                case "4":
                    this.Print(mainController.GetOrders());
                    break;
                case "5":
                    this.Print(mainController.GetOrderDetails());
                    break;
                case "6":
                    //aList = mainController.GetProducts();
                    //return aList;
                    Console.WriteLine("Enter a Product ID");
                    string theID = Console.ReadLine();
                    this.Print(mainController.GetProductByID(theID));
                    break;
                case "7":
                    this.Print(mainController.GetShippers());
                    break;
                case "8":
                    this.Print(mainController.GetSuppliers());
                    break;
                default: Console.WriteLine("Please enter a # 1-8");
                    this.Print("Nah");
                    break;
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
