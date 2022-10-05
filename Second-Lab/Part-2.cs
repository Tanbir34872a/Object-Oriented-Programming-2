using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeeSharpo
{
    class Program
    {
        static void input(int[,] arr)
        {
            int order = arr.GetLength(0);
            for (int r = 0; r < order; r++)
            {
                for (int c = 0; c < order; c++)
                {
                    Console.Write("Enter value of row {0}, column {1} : ", r + 1, c + 1);
                    arr[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void reader(int[,] arr)
        {
            int order = arr.GetLength(0);
            for (int r = 0; r < order; r++)
            {
                for (int c = 0; c < order; c++)
                {
                    Console.Write("{0}\t",arr[r,c]);
                }
                Console.WriteLine();
            }
        }

        static int[,] multiply(int[,] arr1, int[,] arr2)
        {
            int o = arr1.GetLength(0);
            int[,] arrN = new int [o, o];

            for (int r = 0; r < o; r++)
            {
                for (int c = 0; c < o; c++)
                {
                    arrN[r,c] = 0;
                    for (int a = 0; a < o; a++)
                    {
                        arrN[r,c] += arr1[r,a] * arr2[a,c];
                    }
                }
            }
            return arrN;
        }

       
        static void Main(string[] args)
        {
            Console.Write("Enter the order of Matrices: ");
            int o = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[o, o];
            int[,] arr2 = new int[o, o];
            int[,] arr3 = new int[o, o];

            Console.WriteLine("For First Matrix: ");
            input(arr1);
            Console.Clear();
            Console.WriteLine("The First Matrix: ");
            reader(arr1);
            Console.WriteLine("For Second Matrix: ");
            input(arr2);
            Console.Clear();
            Console.WriteLine("The First Matrix: ");
            reader(arr1);
            Console.WriteLine("The Second Matrix: ");
            reader(arr2);
            Console.WriteLine("For Third Matrix: ");
            input(arr3);
            Console.Clear();
            Console.WriteLine("The First Matrix: ");
            reader(arr1);
            Console.WriteLine("\nThe Second Matrix: ");
            reader(arr2);
            Console.WriteLine("\nThe Third Matrix: ");
            reader(arr2);

            int[,] arr = multiply(arr1, arr2);
            arr = multiply(arr, arr3);

            Console.WriteLine("\n\nThe Multiplication of all 3 Matrices: ");
            reader(arr);
        }
    }
}
