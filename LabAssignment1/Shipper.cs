//Written by Kyle Goetschius
//Date: 1/29/2014
//Shipper Model Class- Initializes default values for fields, creates accessor properties, constructors & ToString()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class Shipper : IListable
    {
        private static int numShippers = 0;

        private int shipperID = -1;
        private string companyName = "N/A";
        private string phone = "N/A";

        public int ShipperID
        {
            get { return shipperID; }
            //read-only
        }

        public string CompanyName
        {
            get { return companyName; }
            set { this.companyName = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { this.phone = value; }
        }

        public Shipper()
        {
            //initialization code goes here.
            ++numShippers;
        }

        public Shipper(int anID, string aName, string aPhone)
            : this()
        {
            this.shipperID = anID;
            this.CompanyName = aName;
            this.Phone = aPhone;
        }

        public Shipper(int anID, string aName)
            : this(anID, aName, "N/A")
        {
        }

        public Shipper(int anID)
            : this(anID, "N/A", "N/A")
        {
        }

        public static string totalCount()
        {
            return "7. Shippers: " + numShippers + " records \n";
        }
        
        public override string ToString()
        {
            string output = "";
            output += "Shipper ID: " + ShipperID + "\n";
            output += "Company Name: " + CompanyName + "\n";
            output += "Phone: " + Phone + "\n";

            return output;
        }
    }
}