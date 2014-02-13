//Written by Kyle Goetschius
//Date: 1/29/2014
//Order Detail Model Class- Initializes default values for fields, creates accessor properties, constructors & ToString()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class OrderDetail
    {
        private static int numOrderDetails = 0;

        private int orderID = -1;
        private int productID = -1;
        private double unitPrice = 999999.99;
        private int quantity = 0;
        private double discount = 0.00;

        public int OrderID
        {
            get { return orderID; }
            //read-only
        }

        public int ProductID
        {
            get { return productID; }
            //read-only
        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set { this.unitPrice = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { this.quantity = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { this.discount = value; }
        }

        public OrderDetail() { 
            //initialization goes here
            ++numOrderDetails;
        }

        public OrderDetail(int anOrderID, int aProductID, double aUnitPrice, int aQuantity, double aDiscount)
            :this() {
                this.orderID = anOrderID;
                this.productID = aProductID;
                this.UnitPrice = aUnitPrice;
                this.Quantity = aQuantity;
                this.Discount = aDiscount;
        }

        public OrderDetail(int anOrderID, int aProductID, double aUnitPrice, int aQuantity)
            : this(anOrderID, aProductID, aUnitPrice, aQuantity, 0.0) { 
        }

        public OrderDetail(int anOrderID, int aProductID, double aUnitPrice)
            : this(anOrderID, aProductID, aUnitPrice, 0, 0.0){
        }

        public OrderDetail(int anOrderID, int aProductID)
            : this(anOrderID, aProductID, 999999.99, 0, 0.0){
        }

        public OrderDetail(int anOrderID)
            : this(anOrderID, -1, 999999.99, 0, 0.0){
        }

        public static string totalCount()
        {
            return " Order Details: " + numOrderDetails + "\n";
        }

        public override string ToString(){
            string output = "";
            output += "Order ID: " + OrderID + "\n";
            output += "Product ID: " + ProductID + "\n";
            output += "Unit Price: " + UnitPrice + "\n";
            output += "Quantity: " + Quantity + "\n";
            output += "Discount: " + Discount + "\n";

            return output;
        }
    }
}
