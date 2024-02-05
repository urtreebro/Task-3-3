using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IBase[] allArrays = new ArrayBase[3];

            Random rnd = new();

            OneDimensionalArray onedimarray = new();
            allArrays[0] = onedimarray;

            TwoDimensionalArray twodimarray = new();
            allArrays[1] = twodimarray;

            JaggedArray jaggedarray = new();
            allArrays[2] = jaggedarray;

            Console.WriteLine("IBase");

            foreach (IBase array in allArrays)
            {
                Console.WriteLine($"Average: {array.FindAverage()} \n");

                array.Print();

                Console.WriteLine();

                array.Refill();

                Console.WriteLine("Refilled array\n");

                array.Print();

                Console.WriteLine();
            }
            IPrinter[] printers = new IPrinter[4];
       
            printers[0] = onedimarray;
            
            printers[1] = twodimarray;
            
            printers[2] = jaggedarray;

            Week week = new();
            printers[3] = week;

            Console.WriteLine("IPrinter");

            foreach (IPrinter printer in printers)
            {
                printer.Print();
            }
        }
    }
}
