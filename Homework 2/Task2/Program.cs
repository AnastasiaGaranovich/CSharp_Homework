using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Enter the size of arrayM: ");
            int sizeM = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the size of arrayN: ");
            int sizeN = Convert.ToInt32(Console.ReadLine());

            int[] arrayM = new int[sizeM];
            Console.WriteLine("ArrayM");
            for(int i = 0; i < sizeM; i++)
            {
                arrayM[i] = random.Next(1, 11);
                Console.Write($"{arrayM[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("ArrayN");
            int[] arrayN = new int[sizeN];
            for (int i = 0; i < sizeN; i++)
            {
                arrayN[i] = random.Next(1, 11);
                Console.Write($"{arrayN[i]} ");
            }
            Console.WriteLine();

            int sizeB = sizeM + sizeN;
            int[] arrayB = new int[sizeB];
            int indexB = 0;
            for (int i = 0; i < sizeM; i++)
            {
                bool exists = false;
                for (int j = 0; j < indexB; j++)
                {
                    if (arrayB[j] == arrayM[i])
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    arrayB[indexB] = arrayM[i];
                    indexB++;
                }
            }

            for (int i = 0; i < sizeN; i++)
            {
                bool exists = false;
                for (int j = 0; j < indexB; j++)
                {
                    if(arrayB[j] == arrayN[i])
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    arrayB[indexB] = arrayN[i];
                    indexB++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("ArrayB");
            for (int i = 0; i < indexB; i++)
            {
                Console.Write($"{arrayB[i]} ");
            }

            Console.ReadKey();
        }
    }
}
