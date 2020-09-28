using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static Random random = new Random();
        static double[] arrayA = new double[5];
        static double[,] arrayB = new double[3, 4];
        static void FillArrays()
        {
            Console.WriteLine("Fill the array with 5 type double elements: ");
            for (int i = 0; i < 5; i++)
            {
                arrayA[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arrayB[i, j] = random.NextDouble();
                }
            }
        }

        static void PrintArrays()
        {
            Console.WriteLine("Array A");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{arrayA[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Array B");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{arrayB[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void FindMax()
        {
            double maxElementA = double.MinValue;
            for (int i = 0; i < 5; i++)
            {
                if (arrayA[i] > maxElementA)
                {
                    maxElementA = arrayA[i];
                }
            }

            double maxElementB = double.MinValue;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (arrayB[i, j] > maxElementB)
                    {
                        maxElementB = arrayB[i, j];
                    }
                }
            }

            Console.WriteLine($"Max element in ArrayA: {maxElementA}");
            Console.WriteLine($"Max element in ArrayB: {maxElementB}");
        }

        static void FindMin()
        {
            double minElementA = double.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                if (arrayA[i] < minElementA)
                {
                    minElementA = arrayA[i];
                }
            }

            double minElementB = double.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (arrayB[i, j] < minElementB)
                    {
                        minElementB = arrayB[i, j];
                    }
                }
            }

            Console.WriteLine($"Min element in ArrayA: {minElementA}");
            Console.WriteLine($"Min element in ArrayB: {minElementB}");
            if(minElementA < minElementB)
            {
                Console.WriteLine($"Common min element in Arrays: {minElementA}");
            }
            else
            {
                Console.WriteLine($"Common min element in Arrays: {minElementB}");
            }
        }

        static void Summ()
        {
            double summA = 0;
            for (int i = 0; i < 5; i++)
            {
                summA += arrayA[i];
            }

            double summB = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    summB += arrayB[i, j];
                }
            }

            Console.WriteLine($"Summ of elements ArrayA: {summA}");
            Console.WriteLine($"Summ of elements ArrayB: {summB}");
        }

        static void Product()
        {
            double productA = 1;
            for (int i = 0; i < 5; i++)
            {
                productA *= arrayA[i];
            }

            double productB = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    productB *= arrayB[i, j];
                }
            }

            Console.WriteLine($"Product of elements ArrayA: {productA}");
            Console.WriteLine($"Product of elements ArrayB: {productB}");
        }

        static void EvenSumm()
        {
            double summA = 0;
            for (int i = 0; i < 5; i++)
            { 
                if(i % 2 == 0)
                {
                    summA += arrayA[i];
                }
            }
            Console.WriteLine($"Summ of even elements ArrayA: {summA}");
        }

        static void OddColumnSumm()
        {
            double summB = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(j % 2 != 0)
                    {
                        summB += arrayB[i, j];
                    }
                }
            }
            Console.WriteLine($"Summ of odd columns ArrayB: {summB}");
        }

        static void Main(string[] args)
        {
            FillArrays();
            PrintArrays();
            FindMax();
            FindMin();
            Summ();
            Product();
            EvenSumm();
            OddColumnSumm();

            Console.ReadKey();
        }
    }
}
