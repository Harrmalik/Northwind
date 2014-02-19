//Written by Kyle Goetschius
//Date: 1/29/2014
//Product Model Class- Initializes default values for fields, creates accessor properties, constructors & ToString()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class Product : IListable
    {
        public static int numProducts = 0;

        private int productID = -1;
        private string productName = "N/A";
        private int supplierID = -1;
        private int categoryID = -1;
        private string quantityPerUnit = "N/A";
        private double unitPrice = 9999999.99;
        private int unitsInStock = 0;
        private int unitsOnOrder = 0;
        private int reorderLevel = 0;
        private bool discontinued = true;

        public int ProductID{
            get { return productID; }
            //read-only
        }

        public string ProductName{
            get { return productName; }
            set { productName = value; }
        }

        public int SupplierID{
            get { return supplierID; }
            //read-only
        }

        public int CategoryID{
            get { return categoryID; }
            //read-only
        }

        public string QuantityPerUnit{
            get { return quantityPerUnit; }
            set { quantityPerUnit = value; }
        }

        public double UnitPrice{
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public int UnitsInStock {
            get { return unitsInStock; }
            set { unitsInStock = value; }
        }

        public int UnitsOnOrder {
            get { return unitsOnOrder; }
            set { unitsOnOrder = value; }
        }

        public int ReorderLevel {
            get { return reorderLevel; }
            set { reorderLevel = value; }
        }

        public bool Discontinued {
            get { return discontinued; }
            set { discontinued = value; }
        }

        public Product() {
            //initialization goes here
            ++numProducts;
        }
 
        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit, double aUnitPrice, int aNumInStock, int aNumOnOrder, int aReorderLevel, bool isDiscontinued)
        :this(){
            this.productID = aProductID; //read-only field
            this.ProductName = aProductName;
            this.supplierID = aSupplierID; //read-only field
            this.categoryID = aCategoryID; //read-only field
            this.QuantityPerUnit = aQuantityPerUnit;
            this.UnitPrice = aUnitPrice;
            this.UnitsInStock = aNumInStock;
            this.UnitsOnOrder = aNumOnOrder;
            this.ReorderLevel = aReorderLevel;
            this.Discontinued = isDiscontinued;
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit, double aUnitPrice, int aNumInStock, int aNumOnOrder, int aReorderLevel)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aNumInStock, aNumOnOrder, aReorderLevel, true) { 
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit, double aUnitPrice, int aNumInStock, int aNumOnOrder)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aNumInStock, aNumOnOrder, 0, true){
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit, double aUnitPrice, int aNumInStock)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aNumInStock, 0, 0, true){
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit, double aUnitPrice)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, 0, 0, 0, true){
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, 9999999.99, 0, 0, 0, true){
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, "N/A", 9999999.99, 0, 0, 0, true){
        }

        public Product(int aProductID, string aProductName, int aSupplierID)
            : this(aProductID, aProductName, aSupplierID, -1, "N/A", 9999999.99, 0, 0, 0, true){
        }

        public Product(int aProductID, string aProductName)
            : this(aProductID, aProductName, -1, -1, "N/A", 9999999.99, 0, 0, 0, true){
        }

        public Product(int aProductID)
            : this(aProductID, "N/A", -1, -1, "N/A", 9999999.99, 0, 0, 0, true){
        }

        public static string totalCount()
        {
            return "6. Products: " + numProducts + "\n";
        }

        public override string ToString(){
            string output = "";
            output += "Product ID: " + ProductID + "\n";
            output += "Product Name: " + ProductName + "\n";
            output += "Supplier ID: "+ SupplierID + "\n";
            output += "Category ID: " + CategoryID + "\n";
            output += "Quantity per Unit: " + QuantityPerUnit + "\n";
            output += "Unit Price: " + UnitPrice + "\n";
            output += "Units in Stock: " + UnitsInStock + "\n";
            output += "Units on Order: " + UnitsOnOrder + "\n";
            output += "Reorder Level: " + ReorderLevel + "\n";
            output += "Discontinued: " + Discontinued + "\n";

            return output;
        }
    }
}
