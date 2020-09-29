using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] array2D = new int[5, 5];

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    array2D[i, j] = random.Next(-100, 101);
                    Console.Write($"{array2D[i, j]} ");
                }
                Console.WriteLine();
            }

            int index1D = 0;
            int[] array1D = new int[5*5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array1D[index1D] = array2D[i, j];
                    index1D++;
                }
            }

            int max = array1D.Max();
            int min = array1D.Min();

            int maxIndex = Array.IndexOf(array1D, max);
            int minIndex = Array.IndexOf(array1D, min);

            int summ = 0;
            if(minIndex > maxIndex)
            {
                (minIndex, maxIndex) = (maxIndex, minIndex);
            }

            for (int i = minIndex; i < maxIndex; i++)
            {
                summ += array1D[i];
            }

            Console.WriteLine($"Summ: {summ}");

            Console.ReadKey();
        }
    }
}
