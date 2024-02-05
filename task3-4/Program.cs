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

            //More arrays
            IOneDimensional[] onedims = new IOneDimensional[2];

            OneDimensionalArray onedimarray2 = new();

            onedims[0] = onedimarray;
            onedims[1] = onedimarray2;

            foreach (IOneDimensional one in onedims)
            {
                PrintArray(one.GetArrayAbs100());

                PrintArray(one.GetArrayWithoutDuplicates());
            }

            ITwoDimensional[] twodims = new ITwoDimensional[2];

            TwoDimensionalArray twodimarray2 = new();

            twodims[0] = twodimarray;
            twodims[1] = twodimarray2;

            foreach (ITwoDimensional two in twodims)
            {
                two.GetMatrixDeterminant();
            }

            IJagged[] jaggeds = new IJagged[2];

            JaggedArray jaggedarray2 = new();

            jaggeds[0] = jaggedarray;
            jaggeds[1] = jaggedarray2;

            foreach (IJagged jagged in jaggeds)
            {
                PrintArray(jagged.GetAverageNumInNestedArrays());
                jagged.ChangeArray();

                jagged.ChangeArray();
                jagged.Print();
            }
        }

        public static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }

        public static void PrintArray(double[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
