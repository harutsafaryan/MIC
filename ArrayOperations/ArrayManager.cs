using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    class ArrayManager
    {
        public int[,] Create(int row, int column)
        {
            int[,] result = new int[row, column];
            Random random = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    result[i, j] = random.Next(0, 99);
                }
            }
            return result;
        }

        public int[] Create(int n)
        {
            int[] result = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                result[i] = random.Next(0, 99);
            }
            return result;
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

        public void Swap(int[] arr)
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
        }

        public void Swap(int[,] arr)
        {
            int max = arr[0, 0];
            int min = arr[0, 0];
            (int, int) indexMin = (0, 0);
            (int, int) indexMax = (0, 0);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        indexMax = (i, j);
                    }

                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                        indexMin = (i, j);
                    }
                }

            }
                int temp = arr[indexMin.Item1, indexMin.Item2];
                arr[indexMin.Item1, indexMin.Item2] = arr[indexMax.Item1, indexMax.Item2];
                arr[indexMax.Item1, indexMax.Item2] = temp;
        }
    }
}
