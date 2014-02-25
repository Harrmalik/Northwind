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

            this.PrintTotals();
        }

        //Retrieves & prints total stored as static var for each table
        public void PrintTotals(){
            string output = "";
            output += Category.totalCount();
            output += Customer.totalCount();
            output += Employee.totalCount(); 
            output += Order.totalCount();
            output += OrderDetail.totalCount();
            output += Product.totalCount();
            output += Shipper.totalCount();
            output += Supplier.totalCount();
            output += "\nEnter the # to the left of the records you'd like to see. \n";

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
                    Console.WriteLine("Enter 1 to search by Order, enter 2 to print all.");
                    string detailKey = Console.ReadLine();
                    if (detailKey == "1")
                    {
                        Console.WriteLine("Enter an Order ID: ");
                        List<IListable> checkList = mainController.GetDetailsByOrder(Console.ReadLine());
                        if (checkList.Count() == 0)
                        {
                            Console.WriteLine("No details were found for that ID.");
                            this.selectTable("5");
                        }
                        else
                        {
                            this.Print(checkList);
                        }
                    }
                    else {
                        this.Print(mainController.GetOrderDetails());
                    }
                    break;
                case "6":
                    Console.WriteLine("Enter 1 to search by ID, 2 to search by CategoryID, 3 to select by price range, or 4 to print all.");
                    string aKey = Console.ReadLine();

                    switch (aKey) {
                        case "1":
                            Console.WriteLine("Enter a Product ID: ");
                            this.Print(mainController.GetProductsByID(Console.ReadLine()));
                            break;
                        case "2":
                            Console.WriteLine("Enter a Category ID: ");
                            this.Print(mainController.GetProductsByCategory(Console.ReadLine()));
                            break;
                        case "3":
                            Console.WriteLine("Enter a minimum price.");
                            double min = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter a maximum price.");
                            double max = Double.Parse(Console.ReadLine());
                            this.Print(mainController.GetProductsByPrice(min, max));
                            break;
                        default:
                            this.Print(mainController.GetProducts());
                            break;
                    }
                    break;
                case "7":
                    this.Print(mainController.GetShippers());
                    break;
                case "8":
                    this.Print(mainController.GetSuppliers());
                    break;
                default: 
                    Console.WriteLine("Please enter a # 1-8");
                    this.selectTable(Console.ReadLine());
                    break;
            }
            this.PrintTotals();
        }
    }
}
