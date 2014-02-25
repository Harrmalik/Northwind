//Written by Kyle Goetschius
//Date: 1/29/2014
//Customer Model Class- Initializes default values for fields, creates accessor properties, constructors & ToString()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class Customer : IListable
    {
        private static int numCustomers = 0;

        private string customerID = "N/A";
        private string companyName = "N/A";
        private string contactName = "N/A";
        private string contactTitle = "N/A";
        private string address = "N/A";
        private string city = "N/A";
        private string region = "N/A";
        private string postalCode = "N/A";
        private string country = "N/A";
        private string phone = "N/A";
        private string fax = "N/A";

        public string CustomerID
        {
            get { return customerID; }
            //read-only
        }
        public string CompanyName
        {
            get { return companyName; }
            set { this.companyName = value; }
        }
        public string ContactName
        {
            get { return contactName; }
            set { this.contactName = value; }
        }
        public string ContactTitle
        {
            get { return contactTitle; }
            set { this.contactTitle = value; }
        }
        public string Address
        {
            get { return address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return city; }
            set { this.city = value; }
        }
        public string Region
        {
            get { return region; }
            set { this.region = value; }
        }
        public string PostalCode
        {
            get { return postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return country; }
            set { this.country = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { this.phone = value; }
        }
        public string Fax
        {
            get { return fax; }
            set { this.fax = value; }
        }

        public Customer() { 
            //initialization goes here
            ++numCustomers;
        }

        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
            :this() {
                this.customerID = aCustomerID;
                this.CompanyName = aCompanyName;
                this.ContactName = aContactName;
                this.ContactTitle = aContactTitle;
                this.Address = anAddress;
                this.City = aCity;
                this.Region = aRegion;
                this.PostalCode = aPostalCode;
                this.Country = aCountry;
                this.Phone = aPhone;
                this.Fax = aFax;
        }

        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone)
            :this(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, "N/A") { 
        }

        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry)
            : this(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, "N/A", "N/A"){
        }

        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode)
            : this(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, "N/A", "N/A", "N/A"){
        }

        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion)
            : this(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, "N/A", "N/A", "N/A", "N/A"){
        }

        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity)
            : this(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress)
            : this(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle)
            : this(aCustomerID, aCompanyName, aContactName, aContactTitle, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Customer(string aCustomerID, string aCompanyName, string aContactName)
            : this(aCustomerID, aCompanyName, aContactName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Customer(string aCustomerID, string aCompanyName)
            : this(aCustomerID, aCompanyName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Customer(string aCustomerID)
            : this(aCustomerID, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public static string totalCount()
        {
            return "2. Customers: " + numCustomers + " records \n";
        }

        public override string ToString()
        {
            string output = "";
            output += "Customer ID: " + CustomerID + "\n";
            output += "Company Name: " + CompanyName + "\n";
            output += "Contact Name: " + ContactName + "\n";
            output += "Contact Title: " + ContactTitle + "\n";
            output += "Address: " + Address + "\n";
            output += "City: " + City + "\n";
            output += "Region: " + Region + "\n";
            output += "Postal Code: " + PostalCode + "\n";
            output += "Country: " + Country + "\n";
            output += "Phone: " + Phone + "\n";
            output += "Fax: " + Fax + "\n";

            return output;
        }
    }
}
