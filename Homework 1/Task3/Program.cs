using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start number: ");
            uint numberStart = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Enter the end number: ");
            uint numberEnd = Convert.ToUInt32(Console.ReadLine());

            for(uint i = numberStart; i <= numberEnd; i++)
            {
                for(uint j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
