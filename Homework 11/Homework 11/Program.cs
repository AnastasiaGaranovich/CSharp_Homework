using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExchangeRates rates = new ExchangeRates();
            Console.Write("Enter currency char code: ");
            string charCode = Console.ReadLine();
            rates.FindExchangeRate(charCode);

            Console.ReadKey();
        }
    }
}
