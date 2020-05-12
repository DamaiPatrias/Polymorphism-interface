using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism__Interface_
{
    public interface IWindowsPrinter
    {
        void Show();
        void Print();
    }
    public class Epson : IWindowsPrinter
    {
        public void Show()
        {
            Console.WriteLine("\nEpson Display dimension : 10*11");
        }
        public void Print()
        {
            Console.WriteLine("Epson printer printing ...");
        }
    }
    public class Canon : IWindowsPrinter
    {
        public void Show()
        {
            Console.WriteLine("\nCanon display : 9.5*12");
        }
        public void Print()
        {
            Console.WriteLine("Canon printer printing ...");
        }
    }
    public class Laserjet : IWindowsPrinter
    {
        public void Show()
        {
            Console.WriteLine("\nLaserjet display dimension : 12*12");
        }
        public void Print()
        {
            Console.WriteLine("Laserjet printer printing ...");
        }
    }
}
