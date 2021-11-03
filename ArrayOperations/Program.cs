using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayManager arrayManager = new ArrayManager();   
            PrinterManager printManager = new PrinterManager();
            int[,] arr1 = arrayManager.Create(7, 7); //create 7x7 matrix
            int[] arr2 = arrayManager.GetDiagonal(arr1);    // create diagonal of arr1

            Console.WriteLine("Print matrix");
            printManager.Print(arr1);
            Console.WriteLine();

            Console.WriteLine("Swap min and max elements");
            arrayManager.Swap(arr1);
            printManager.Print(arr1);

            Console.WriteLine();
            Console.WriteLine("Print diagonal");
            printManager.Print(arr2);

        }
    }
}
