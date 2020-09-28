using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int count = 0;
            int summ = 0;
            Console.WriteLine("Enter the numbers");
            while(true)
            {
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }

                count++;
                summ += number;
            }
            Console.WriteLine($"You entered {count} numbers");
            Console.WriteLine($"Their sum = {summ}");
            Console.WriteLine($"Their average = {(double)summ / count}");

            Console.ReadKey();
        }
    }
}
