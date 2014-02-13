//Written by Kyle Goetschius
//Date: 1/29/2014
//Order Model Class- Initializes default values for fields, creates accessor properties, constructors & ToString()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class Order
    {
        private static int numOrders = 0;

        private int orderID = -1;
        private string customerID = "N/A";
        private int employeeID = -1;
        private string orderDate = "N/A";
        private string requiredDate = "N/A";
        private string shippedDate = "N/A";
        private int shipVia = -1;
        private double freight = 999999.99;
        private string shipName = "N/A";
        private string shipAddress = "N/A";
        private string shipCity = "N/A";
        private string shipRegion = "N/A";
        private string shipPostalCode = "N/A";
        private string shipCountry = "N/A";

        public int OrderID
        {
            get { return orderID; }
            //read-only
        }

        public string CustomerID
        {
            get { return customerID; }
            //read-only
        }

        public int EmployeeID
        {
            get { return employeeID; }
            //read-only
        }

        public string OrderDate
        {
            get { return orderDate; }
            set { this.orderDate = value; }
        }

        public string RequiredDate
        {
            get { return requiredDate; }
            set { this.requiredDate = value; }
        }

        public string ShippedDate
        {
            get { return shippedDate; }
            set { this.shippedDate = value; }
        }

        public int ShipVia
        {
            get { return shipVia; }
            set { this.shipVia = value; }
        }

        public double Freight
        {
            get { return freight; }
            set { this.freight = value; }
        }

        public string ShipName
        {
            get { return shipName; }
            set { this.shipName = value; }
        }

        public string ShipAddress
        {
            get { return shipAddress; }
            set { this.shipAddress = value; }
        }

        public string ShipCity
        {
            get { return shipCity; }
            set { this.shipCity = value; }
        }

        public string ShipRegion
        {
            get { return shipRegion; }
            set { this.shipRegion = value; }
        }

        public string ShipPostalCode
        {
            get { return shipPostalCode; }
            set { this.shipPostalCode = value; }
        }

        public string ShipCountry
        {
            get { return shipCountry; }
            set { this.shipCountry = value; }
        }

        public Order() { 
            //initialization goes here
            ++numOrders;
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID, string anOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, double aFreight, string aName, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry) 
            : this() {
                this.orderID = anOrderID;
                this.customerID = aCustomerID;
                this.employeeID = anEmployeeID;
                this.OrderDate = anOrderDate;
                this.RequiredDate = aRequiredDate;
                this.ShippedDate = aShippedDate;
                this.ShipVia = aShipVia;
                this.Freight = aFreight;
                this.ShipName = aName;
                this.ShipAddress = anAddress;
                this.ShipCity = aCity;
                this.ShipRegion = aRegion;
                this.ShipPostalCode = aPostalCode;
                this.ShipCountry = aCountry;
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID, string anOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, double aFreight, string aName, string anAddress, string aCity, string aRegion, string aPostalCode)
            : this(anOrderID, aCustomerID, anEmployeeID, anOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aName, anAddress, aCity, aRegion, aPostalCode, "N/A"){
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID, string anOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, double aFreight, string aName, string anAddress, string aCity, string aRegion)
            : this(anOrderID, aCustomerID, anEmployeeID, anOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aName, anAddress, aCity, aRegion, "N/A", "N/A"){
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID, string anOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, double aFreight, string aName, string anAddress, string aCity)
            : this(anOrderID, aCustomerID, anEmployeeID, anOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aName, anAddress, aCity, "N/A", "N/A", "N/A"){
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID, string anOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, double aFreight, string aName, string anAddress)
            : this(anOrderID, aCustomerID, anEmployeeID, anOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aName, anAddress, "N/A", "N/A", "N/A", "N/A"){
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID, string anOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, double aFreight, string aName)
            : this(anOrderID, aCustomerID, anEmployeeID, anOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aName, "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID, string anOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, double aFreight)
            : this(anOrderID, aCustomerID, anEmployeeID, anOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID, string anOrderDate, string aRequiredDate, string aShippedDate, int aShipVia)
            : this(anOrderID, aCustomerID, anEmployeeID, anOrderDate, aRequiredDate, aShippedDate, aShipVia, 0.0, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID, string anOrderDate, string aRequiredDate, string aShippedDate)
            : this(anOrderID, aCustomerID, anEmployeeID, anOrderDate, aRequiredDate, aShippedDate, -1, 0.0, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID, string anOrderDate, string aRequiredDate)
            : this(anOrderID, aCustomerID, anEmployeeID, anOrderDate, aRequiredDate, "N/A", -1, 0.0, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID, string anOrderDate)
            : this(anOrderID, aCustomerID, anEmployeeID, anOrderDate, "N/A", "N/A", -1, 0.0, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Order(int anOrderID, string aCustomerID, int anEmployeeID)
            : this(anOrderID, aCustomerID, anEmployeeID, "N/A", "N/A", "N/A", -1, 0.0, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Order(int anOrderID, string aCustomerID)
            : this(anOrderID, aCustomerID, -1, "N/A", "N/A", "N/A", -1, 0.0, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Order(int anOrderID)
            : this(anOrderID, "N/A", -1, "N/A", "N/A", "N/A", -1, 0.0, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public static string totalCount()
        {
            return " Orders: " + numOrders + "\n";
        }

        public override string ToString()
        {
            string output = "";
            output += "Order ID: " + Freight + "\n";
            output += "Customer ID: " + CustomerID + "\n";
            output += "Employee ID: " + EmployeeID + "\n";
            output += "Order Date: " + OrderDate + "\n";
            output += "Required Date: " + RequiredDate + "\n";
            output += "Shipped Date: " + ShippedDate + "\n";
            output += "Ship Via: " + ShipVia + "\n";
            output += "Freight: " + Freight + "\n";
            output += "Name: " + ShipName + "\n";
            output += "Address: " + shipAddress + "\n";
            output += "City: " + ShipCity + "\n";
            output += "Region: " + ShipRegion + "\n";
            output += "Postal Code: " + ShipPostalCode + "\n";
            output += "Country: " + ShipCountry + "\n";
            
            return output;
        }
    }
}
