using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class LaserJet : Iprinter
    {
        public void Show()
        {
            Console.WriteLine("\nLaserJet Display Dimension = 12*12");
        }
        public void Print()
        {
            Console.WriteLine("LaserJet Printer Printing....");
        }
    }
}
