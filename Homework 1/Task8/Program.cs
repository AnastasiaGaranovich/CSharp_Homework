using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The perfect numbers 1 and 10000 are: ");
            int perfectNumber = 1;
            int currentNumber = 1; 
            int sum = 0;

            while(perfectNumber <= 10000)
            {
                while(currentNumber <= 10000)
                {
                    if (currentNumber < perfectNumber)
                    {
                        if (perfectNumber % currentNumber == 0)
                        {
                            sum += currentNumber;
                        } 
                    }
                    currentNumber++;
                }
                if (sum == perfectNumber)
                {
                    Console.Write($"{perfectNumber} ");
                }
                perfectNumber++;
                currentNumber = 1;
                sum = 0;
            }
            Console.ReadKey();
        }
    }
}
