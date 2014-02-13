//Written by Kyle Goetschius
//Date: 1/29/2014
//Employee Model Class- Initializes default values for fields, creates accessor properties, constructors & ToString()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class Employee
    {
        private static int numEmployees = 0;

        //backing fields
        private int employeeID = -1;
        private string lastName = "N/A";
        private string firstName = "N/A";
        private string title = "N/A";
        private string titleOfCourtesy = "N/A";
        private string birthDate = "N/A";
        private string hireDate = "N/A";
        private string address = "N/A";
        private string city = "N/A";
        private string region = "N/A";
        private string postalCode = "N/A";
        private string country = "N/A";
        private string homePhone = "N/A";
        private string extension = "N/A";
        private string notes = "N/A";
        private int reportsTo = -1;

        //Accessors
        public int EmployeeID
        {
            get { return employeeID; }
            //read-only
        }

        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }

        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }

        public string TitleOfCourtesy
        {
            get { return titleOfCourtesy; }
            set { this.titleOfCourtesy = value; }
        }

        public string BirthDate
        {
            get { return birthDate; }
            set { this.birthDate = value; }
        }

        public string HireDate
        {
            get { return hireDate; }
            set { this.hireDate = value; }
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

        public string HomePhone
        {
            get { return homePhone; }
            set { this.homePhone = value; }
        }

        public string Extension
        {
            get { return extension; }
            set { this.extension = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { this.notes = value; }
        }

        public int ReportsTo
        {
            get{ return reportsTo; }
		    set{ this.reportsTo = value ;}
        }

        //Constructors
        public Employee() { 
            //initialization goes here
            ++numEmployees;
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy, string aBirthDate, string aHireDate, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string anExtension, string aNote, int aReportsTo)
            : this() {
                this.employeeID = anID;
                this.LastName = aLastName;
                this.FirstName = aFirstName;
                this.Title = aTitle;
                this.TitleOfCourtesy = aTitleofCourtesy;
                this.BirthDate = aBirthDate;
                this.HireDate = aHireDate;
                this.Address = anAddress;
                this.City = aCity;
                this.Region = aRegion;
                this.PostalCode = aPostalCode;
                this.Country = aCountry;
                this.HomePhone = aHomePhone;
                this.Extension = anExtension;
                this.Notes = aNote;
                this.ReportsTo = aReportsTo;
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy, string aBirthDate, string aHireDate, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string anExtension, string aNote)
            : this(anID, aLastName, aFirstName, aTitle, aTitleofCourtesy, aBirthDate, aHireDate, anAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, anExtension, aNote, -1){
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy, string aBirthDate, string aHireDate, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string anExtension)
            : this(anID, aLastName, aFirstName, aTitle, aTitleofCourtesy, aBirthDate, aHireDate, anAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, anExtension, "N/A", -1){
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy, string aBirthDate, string aHireDate, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone)
            : this(anID, aLastName, aFirstName, aTitle, aTitleofCourtesy, aBirthDate, aHireDate, anAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, "N/A", "N/A", -1){
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy, string aBirthDate, string aHireDate, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry)
            : this(anID, aLastName, aFirstName, aTitle, aTitleofCourtesy, aBirthDate, aHireDate, anAddress, aCity, aRegion, aPostalCode, aCountry, "N/A", "N/A", "N/A", -1){
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy, string aBirthDate, string aHireDate, string anAddress, string aCity, string aRegion, string aPostalCode)
            : this(anID, aLastName, aFirstName, aTitle, aTitleofCourtesy, aBirthDate, aHireDate, anAddress, aCity, aRegion, aPostalCode, "N/A", "N/A", "N/A", "N/A", -1){
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy, string aBirthDate, string aHireDate, string anAddress, string aCity, string aRegion)
            : this(anID, aLastName, aFirstName, aTitle, aTitleofCourtesy, aBirthDate, aHireDate, anAddress, aCity, aRegion, "N/A", "N/A", "N/A", "N/A", "N/A", -1){
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy, string aBirthDate, string aHireDate, string anAddress, string aCity)
            : this(anID, aLastName, aFirstName, aTitle, aTitleofCourtesy, aBirthDate, aHireDate, anAddress, aCity, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1){
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy, string aBirthDate, string aHireDate, string anAddress)
            : this(anID, aLastName, aFirstName, aTitle, aTitleofCourtesy, aBirthDate, aHireDate, anAddress, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1){
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy, string aBirthDate, string aHireDate)
            : this(anID, aLastName, aFirstName, aTitle, aTitleofCourtesy, aBirthDate, aHireDate, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1){
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy, string aBirthDate)
            : this(anID, aLastName, aFirstName, aTitle, aTitleofCourtesy, aBirthDate, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1){
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle, string aTitleofCourtesy)
            : this(anID, aLastName, aFirstName, aTitle, aTitleofCourtesy, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1){
        }

        public Employee(int anID, string aLastName, string aFirstName, string aTitle)
            : this(anID, aLastName, aFirstName, aTitle, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1){
        }

        public Employee(int anID, string aLastName, string aFirstName)
            : this(anID, aLastName, aFirstName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1){
        }

        public Employee(int anID, string aLastName)
            : this(anID, aLastName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1){
        }

        public Employee(int anID)
            : this(anID, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", -1){
        }

        public static string totalCount()
        {
            return " Employees: " + numEmployees + "\n";
        }

        public override string ToString()
        {
            string output = "";
            output += "Employee ID: " + EmployeeID + "\n";
            output += "Last Name: " + LastName + "\n";
            output += "First Name: " + FirstName + "\n";
            output += "Title: " + Title + "\n";
            output += "Title of Courtesy: " + TitleOfCourtesy + "\n";
            output += "Birth Date: " + BirthDate + "\n";
            output += "Hire Date: " + HireDate + "\n";
            output += "Address: " + Address + "\n";
            output += "City: " + City + "\n";
            output += "Region: " + Region + "\n";
            output += "Postal Code: " + PostalCode + "\n";
            output += "Country: " + Country + "\n";
            output += "Home Phone: " + HomePhone + "\n";
            output += "Extension: " + Extension + "\n";
            output += "Notes: " + Notes + "\n";
            output += "Reports To: " + ReportsTo + "\n";
            
            return output;
        }
    }
}
