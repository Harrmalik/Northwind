using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    class Error : IListable
    {
        public override string ToString()
        {
            return "Invalid input.";
        }
    }
}
