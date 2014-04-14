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
        static void Main(string[] args) {
            LabController aController = new LabController();
            LabView aView = new LabView(aController);
        }
    }
}