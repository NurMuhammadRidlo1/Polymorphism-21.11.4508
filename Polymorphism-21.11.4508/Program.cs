using System;
using Polymorphism_21._11._4508;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer = new PrinterWindows();
            
            Console.WriteLine("Pilih Printer: ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Cannon");
            Console.WriteLine("3. Laser jet \n");

            Console.Write("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
            {
                Epson epson = new();
                printer = epson;
            } 
            else if(nomorPrinter == 2)
            {
                Canon canon = new Canon();
                printer = canon;
            }
            else
            {
                LaserJet laserJet = new LaserJet();
                printer = laserJet;
            }

            printer.Show();
            printer.Print();

        }
    }
}