using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Canon : Iprinter
    {
        public void Show()
        {
            Console.WriteLine("\nCanon Display Dimension = 9.5*12");
        }
        public void Print()
        {
            Console.WriteLine("Canon Printer Printing....");
        }
    }
}
