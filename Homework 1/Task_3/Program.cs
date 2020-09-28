using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static int GetDigit(int number, int index)
        {
            return (number / (int)Math.Pow(10, index)) % 10;
        }

        static void Main(string[] args)
        {
            
            string[] array0_19 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", 
                "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] array20_90 = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };


            Console.Write("Enter the number between 100 and 999: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 100 && number <= 999)
            {
                int hundreds = GetDigit(number, 2);
                int tens = GetDigit(number, 1);
                int ones = GetDigit(number, 0);

                string description = array0_19[hundreds] + " hundred ";

                if (tens == 1)
                {
                    description += array0_19[ones + 10];
                }
                else
                {
                    description += array20_90[tens] + " " + array0_19[ones];
                }

                Console.WriteLine(description);
            }
            else
            {
                Console.WriteLine("Invalid number!");
                Console.ReadKey();
                return;
            }

            Console.ReadKey();
        }
    }
}
