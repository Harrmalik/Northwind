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
            output += "\n Which records would you like to see? \n";

            Console.Write(output);

            this.Print(mainController.selectTable(Console.ReadLine()));
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
