using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism__Interface_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Laserjet\n");

            Console.Write("Nomer Printer [1,2,3] : ");
            int noprinter = Convert.ToInt32(Console.ReadLine());

            IWindowsPrinter printer;

            if (noprinter == 1)
                printer = new Epson();
            else if (noprinter == 2)
                printer = new Canon();
            else
                printer = new Laserjet();

            printer.Show();
            printer.Print();




                Console.ReadKey();
        }
    }
}
