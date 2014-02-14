//Written by Kyle Goetschius
//Date: 1/29/2014
//Category Model Class- Initializes default values for fields, creates accessor properties, constructors & ToString()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class Category : IListable
    {
        private static int numCategories = 0;

        private int categoryID = -1;
        private string categoryName = "N/A";
        private string description = "N/A";

        public int CategoryID //no set method, read-only
        {
            get
            {
                return categoryID;
            }
        }

        public string CategoryName
        {
            get
            {
                return categoryName;
            }
            set
            {
                if (value == "")
                {
                    //throw NullReferenceException;
                }
                else
                {
                    this.categoryName = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                this.description = value;
            }
        }

        public Category() { 
            //any initialization code would go here
            ++numCategories;
        }

        public Category(int anID, string aName, string aDescription)
            :this() //:this() calls default constructor
        { 
            this.categoryID = anID; //ID is read-only, assigns directly to private field
            this.CategoryName = aName; //'CategoryName' is capitalized bc it uses set mehod
            this.Description = aDescription;
        }

        public Category(int anID, string aName)
            : this(anID, aName, "N/A") { }

        public Category(int anID)
            : this(anID, "N/A", "N/A") { }

        public static string totalCount()
        {
            return "1. Categories: " + numCategories + "\n";
        }

        public override string ToString() { 
            string output = "Category ID: " + CategoryID + "\n";
            output += "Category Name: " + CategoryName + "\n";
            output += "Description: " + Description + "\n";

            return output;
        }
    }
}
