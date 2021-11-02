using System;

namespace MIC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = CreateArray(8);
            printArray(arr);
            Console.WriteLine();

            Console.WriteLine($"Min element indexec is: {GetMinElementIndexes(arr).ToString()}");
            Console.WriteLine($"Max element indexec is: {GetMaxElementIndexes(arr).ToString()}");

            Console.WriteLine();
            Console.WriteLine("Swap min and max elements");
            SwapMinAndMax(arr);
            printArray(arr);

            Console.ReadKey();



        }

        /// <summary>
        /// Creat Matrix with given dimension
        /// </summary>
        /// <param name="dimension">Matrix dimension</param>
        /// <returns>Create Matrix with random Int32 numbers</returns>
        public static int[,] CreateArray(int dimension)
        {
            int[,] result = new int[dimension, dimension];
            Random random = new Random();
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    result[i, j] = random.Next(0, 999);
                }
            }
            return result;
        }

        /// <summary>
        /// Print given array
        /// </summary>
        /// <param name="arr">Array to print in Console</param>
        public static void printArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static (int, int) GetMinElementIndexes(int[,] arr)
        {
            (int rowIndex, int columnIndex) index = (0, 0);
            int min = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                        index.rowIndex = i;
                        index.columnIndex = j;
                    }
                }
            }
            return index;
        }
        public static (int, int) GetMaxElementIndexes(int[,] arr)
        {
            (int rowIndex, int columnIndex) index = (0, 0);
            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        index.rowIndex = i;
                        index.columnIndex = j;
                    }
                }
            }
            return index;
        }

        /// <summary>
        /// Swap min and max array elements
        /// </summary>
        /// <param name="arr">given array</param>
        public static void SwapMinAndMax(int[,] arr)
        {

            int min_I = GetMinElementIndexes(arr).Item1;
            int min_J = GetMinElementIndexes(arr).Item2;
            int max_I = GetMaxElementIndexes(arr).Item1;
            int max_J = GetMaxElementIndexes(arr).Item2;

            int temp = arr[min_I, min_J];
            arr[min_I, min_J] = arr[max_I, max_J];
            arr[max_I, max_J] = temp;
        }

        /// <summary>
        /// Get minimum element of array
        /// </summary>
        /// <param name="arr">gven aaray</param>
        /// <returns></returns>
        public static int GetMin(int[,] arr)
        {
            int min = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;
        }

        /// <summary>
        /// Get maximum element of array
        /// </summary>
        /// <param name="arr">given array</param>
        /// <returns></returns>
        public static int GetMax(int[,] arr)
        {
            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }
    }
}
