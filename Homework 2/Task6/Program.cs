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

            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;
            int max4 = int.MinValue;
            int max5 = int.MinValue;

            for (int i = 0; i < 5; i++)
            {
                if (max1 < array2D[i, 0])
                {
                    max1 = array2D[i, 0];
                }
                if (max2 < array2D[i, 1])
                {
                    max2 = array2D[i, 1];
                }
                if (max3 < array2D[i, 2])
                {
                    max3 = array2D[i, 2];
                }
                if (max4 < array2D[i, 3])
                {
                    max4 = array2D[i, 3];
                }
                if (max5 < array2D[i, 4])
                {
                    max5 = array2D[i, 4];
                }
            }

            Console.WriteLine($"Maximum value in a column 1: {max1}");
            Console.WriteLine($"Maximum value in a column 2: {max2}");
            Console.WriteLine($"Maximum value in a column 3: {max3}");
            Console.WriteLine($"Maximum value in a column 4: {max4}");
            Console.WriteLine($"Maximum value in a column 5: {max5}");

            Console.ReadKey();
        }
    }
}
