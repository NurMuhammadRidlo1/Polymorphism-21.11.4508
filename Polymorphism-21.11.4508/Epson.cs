using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_21._11._4508
{
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension: 10*11 ");
        }

        public override void Print()
        {
            Console.WriteLine("Epson Printer Printing.....");
        }
    }
}

