using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Epson : Iprinter
    {
        public void Show()
        {
            Console.WriteLine("\nEpson Display Dimension = 10*12");
        }
        public void Print()
        {
            Console.WriteLine("Epson Printer Printing....");
        }
    }
}
