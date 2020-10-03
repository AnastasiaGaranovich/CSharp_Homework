using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] array2D = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array2D[i, j] = random.Next(0, 101);
                    Console.Write($"{array2D[i, j]} ");
                }
                Console.WriteLine();
            }

            int[] max_array = new int[5];

            for (int i = 0; i < max_array.Length; i++)
            {
                max_array[i] = int.MinValue;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (max_array[j] < array2D[i, j])
                    {
                        max_array[j] = array2D[i, j];
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Maximum value in a column {i + 1}: {max_array[i]}");
            }

            Console.ReadKey();
        }
    }
}
