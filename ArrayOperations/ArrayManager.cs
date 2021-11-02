using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    class ArrayManager
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public ArrayManager(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public int[,] Create()
        {
            int[,] result = new int[Rows, Columns];
            Random random = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    result[i, j] = random.Next(0, 99);
                }
            }
            return result;
        }

        public int[] Swap(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxIndex = i;
                }

                if (min > arr[i])
                {
                    min = arr[i];
                    minIndex = i;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[maxIndex];
            arr[maxIndex] = temp;
            return arr;

        }



        public int GetMax(int[,] arr)
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

        public int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min < arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public int GetMin(int[,] arr)
        {
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (min < arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;
        }

        public int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
