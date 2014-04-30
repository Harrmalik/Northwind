using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public interface IListable
    {
        //Generic interface that allows lists of different types to be handled by the same method
    }

    public class Northwind
    {
        static void Main(string[] args)
        {
            Controller aController = new Controller();
            ConsoleView aView = new ConsoleView(aController);
        }
    }
}