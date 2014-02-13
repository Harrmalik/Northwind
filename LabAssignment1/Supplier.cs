//Written by Kyle Goetschius
//Date: 1/29/2014
//Supplier Model Class- Initializes default values for fields, creates accessor properties, constructors & ToString()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class Supplier
    {
        static int numSuppliers = 0;

    	private int supplierID = -1;
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
    	private string homePage = "N/A";

    	public int SupplierID{
    		get{return supplierID;}
    		//read-only
    	}

        public string CompanyName {
            get { return companyName; }
            set { this.companyName = value;}
        }

        public string ContactName {
            get { return contactName; }
            set { this.contactName = value; }
        }

        public string ContactTitle {
            get { return contactTitle; }
            set { this.contactTitle = value; }
        }

        public string Address {
            get { return address; }
            set { this.address = value; }
        }

        public string City {
            get { return city; }
            set { this.city = value; }
        }

        public string Region {
            get { return region; }
            set { this.region = value; }
        }

        public string PostalCode {
            get { return postalCode; }
            set { this.postalCode = value; }
        }

        public string Country {
            get { return country; }
            set { this.country = value; }
        }

        public string Phone {
            get { return phone; }
            set { this.phone = value; }
        }

        public string Fax {
            get { return fax; }
            set { this.fax = value; }
        }

        public string HomePage {
            get { return homePage; }
            set { this.homePage = value; }
        }

        public Supplier() { 
            //initialization goes here
            ++numSuppliers;
        }

        public Supplier(int aSupplierID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax, string aHomePage)
            : this() {
                this.supplierID = aSupplierID; //read-only
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
                this.HomePage = aHomePage;
        }

        public Supplier(int aSupplierID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
            :this(aSupplierID,  aCompanyName,  aContactName,  aContactTitle,  anAddress,  aCity,  aRegion,  aPostalCode,  aCountry,  aPhone,  aFax, "N/A") { 
        }

        public Supplier(int aSupplierID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone)
            : this(aSupplierID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, "N/A", "N/A"){
        }

        public Supplier(int aSupplierID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry)
            : this(aSupplierID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, "N/A", "N/A", "N/A"){
        }

        public Supplier(int aSupplierID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode)
            : this(aSupplierID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, "N/A", "N/A", "N/A", "N/A"){
        }

        public Supplier(int aSupplierID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion)
            : this(aSupplierID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Supplier(int aSupplierID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity)
            : this(aSupplierID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Supplier(int aSupplierID, string aCompanyName, string aContactName, string aContactTitle, string anAddress)
            : this(aSupplierID, aCompanyName, aContactName, aContactTitle, anAddress, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Supplier(int aSupplierID, string aCompanyName, string aContactName, string aContactTitle)
            : this(aSupplierID, aCompanyName, aContactName, aContactTitle, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Supplier(int aSupplierID, string aCompanyName, string aContactName)
            : this(aSupplierID, aCompanyName, aContactName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Supplier(int aSupplierID, string aCompanyName)
            : this(aSupplierID, aCompanyName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public Supplier(int aSupplierID)
            : this(aSupplierID, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A"){
        }

        public static string totalCount()
        {
            return " Suppliers: " + numSuppliers + "\n";
        }
        
        public override string ToString()
        {
            string output = "";
            output += "Supplier ID: " + SupplierID + "\n";
            output += "Company Name: " + CompanyName + "\n";
            output += "Contact Name: " + ContactName + "\n";
            output += "Contact Title: " + ContactTitle + "\n";
            output += "Address: " + Address + "\n";
            output += "City: " + City + "\n";
            output += "Region: " + Region + "\n";
            output += "PostalCode: " + PostalCode + "\n";
            output += "Country: " + Country + "\n";
            output += "Phone: " + Phone + "\n";
            output += "Fax: " + Fax + "\n";
            output += "Home Page: " + HomePage + "\n";

            return output;
        }
    }
}
