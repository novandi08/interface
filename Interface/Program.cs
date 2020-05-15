using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Iprinter newInterfacePrinter = null;
            Console.WriteLine("Pilihlah Printer :\n");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LaserJet\n");
            Console.WriteLine("Pilih Nomor Printer = ");

            int Pilihan = Convert.ToInt32(Console.ReadLine());
            if (Pilihan == 1)
            {
                newInterfacePrinter = new Epson();
            }
            else if (Pilihan == 2)
            {
                newInterfacePrinter = new Canon();
            }
            else if (Pilihan == 3)
            {
                newInterfacePrinter = new LaserJet();
            }
            else
            {
                Console.WriteLine("\nMaaf opsi yang ada pilih salah");
            }
            newInterfacePrinter.Show();
            newInterfacePrinter.Print();
            Console.ReadKey();
        }
    }
}
