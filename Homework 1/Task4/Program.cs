using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double startDeposit = 1000;
            int month = 0;

            Console.WriteLine($"Initial deposit in the bank is {startDeposit} rub");
            Console.Write("Enter the deposit percent: ");
            double percent = Convert.ToDouble(Console.ReadLine());

            while(true)
            {
                double amountPerMonth = startDeposit / 100 * percent;
                startDeposit += amountPerMonth;
                month++;
                if(startDeposit > 1100)
                {
                    break;
                }
            }

            Console.WriteLine($"Deposit with {percent} percent will exceed 1100 in {month} months");
            Console.WriteLine($"The total amount of the deposit = {startDeposit} rub");

            Console.ReadKey();
        }
    }
}
