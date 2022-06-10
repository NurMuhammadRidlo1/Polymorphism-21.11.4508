using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_21._11._4508
{
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension: 9.5*12 ");
        }

        public override void Print()
        {
            Console.WriteLine("Canon Printer Printing.....");
        }
    }
}
