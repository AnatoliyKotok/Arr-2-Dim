using System;

namespace Arr_2_Dim
{
    class Program
    {
        static void FillArrMatr(int[,] m)
        {
            Random rnd = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(-100, 100);
                }
            }
        }
        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"{m[i, j],-5}");
                }
            Console.WriteLine();
            }
            Console.WriteLine();

        }
        static int[] Sum(int[,] m)
        {
            
            int[] arr = new int[m.GetLength(0)];
            for (int i = 0; i <m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    arr[i] += m[i, j];
                }
            }
            return arr;
        }
        static int[] Copy(int[,] m)
        {
            int i = 0;
            int[] arr = new int[m.Length];
           foreach(var el in m)
            {
                arr[i] = el;
                i++;
            }
            return arr;
            
        }
        static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
        //static void MoveInUp(int[,]arr,int n)
        //{
        //    for (int k = 0; k < n; k++)
        //    {
        //        for (int i = 0; i < arr.GetLength(1); i++)
        //        {
        //            int tmp = arr[arr.GetLength(0), i];
        //            int j=0;
        //            for ( j = arr.GetLength(0); j >0; j--)
        //            {
        //                arr[j, i] = arr[j - 1, i];
        //            }
        //            arr[j, i] = tmp;
        //        }
        //    }
        //}
        static void MoveInDown(int[,] arr,int n)
        {
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    int t = arr[arr.GetLength(0)-1, i];
                    int j=0;
                    for (j = arr.GetLength(0)-1; j >0; j--)
                    {
                        arr[j, i] = arr[j - 1, i];
                    }
                    arr[j, i] = t;
                }
            }
        }
        static void Main(string[] args)
        {
            int rows = 3;
            int cols = 4;
            int[,] m = new int[rows, cols];
            FillArrMatr(m);
            PrintMatrix(m);
            int[] a = Copy(m);
            printArr(a);
            Console.WriteLine();
            int[] arr= Sum(m);
            printArr(arr);
            MoveInDown(m, 1);
            PrintMatrix(m);
        }
    }
}
