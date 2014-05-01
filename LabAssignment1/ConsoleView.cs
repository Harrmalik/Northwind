﻿//Written by Kyle Goetschius
//Date: 1/29/2014
//View class- Print() method outputs to console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Northwind
{
    public class ConsoleView
    {
        private Controller mainController;
        private AdapterController adapterController = new AdapterController();

        public ConsoleView(Controller aController) {
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

        public void Print(DataTable aTable) {
            foreach (DataRow aRow in aTable.Rows) {
                foreach (DataColumn aCol in aTable.Columns) {
                    Console.Write(aRow[aCol] + "\n");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }

        //Select records to putput based on input from Console
        public void selectTable(string input)
        {
            switch (input)
            {
                case "1":
                    this.Print(adapterController.GetCategories());
                    break;
                case "2":
                    this.Print(adapterController.GetCustomers());
                    break;
                case "3":
                    this.Print(adapterController.GetEmployees());
                    break;
                case "4":
                    this.Print(adapterController.GetOrders());
                    break;
                case "5":
                    Console.WriteLine("Enter 1 to search by Order, enter 2 to print all.");
                    string detailKey = Console.ReadLine();
                    if (detailKey == "1")
                    {
                        Console.WriteLine("Enter an Order ID: ");
                        DataTable checkList = adapterController.GetDetailsByOrder(Console.ReadLine());
                        if (checkList.Rows.Count == 0)
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
                        this.Print(adapterController.GetOrderDetails());
                    }
                    break;
                case "6":
                    Console.WriteLine("Enter 1 to search by ID, 2 to search by CategoryID, 3 to select by price range, or 4 to print all.");
                    string aKey = Console.ReadLine();

                    switch (aKey) {
                        case "1":
                            Console.WriteLine("Enter a Product ID: ");
                            this.Print(adapterController.GetProductByID(Console.ReadLine()));
                            break;
                        case "2":
                            Console.WriteLine("Enter a Category ID: ");
                            this.Print(adapterController.GetProductsByCategory(Console.ReadLine()));
                            break;
                        case "3":
                            Console.WriteLine("Enter a minimum price.");
                            string min = Console.ReadLine();
                            Console.WriteLine("Enter a maximum price.");
                            string max = Console.ReadLine();
                            this.Print(adapterController.GetProductsByPrice(min, max));
                            break;
                        default:
                            this.Print(adapterController.GetProducts());
                            break;
                    }
                    break;
                case "7":
                    this.Print(adapterController.GetShippers());
                    break;
                case "8":
                    this.Print(adapterController.GetSuppliers());
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