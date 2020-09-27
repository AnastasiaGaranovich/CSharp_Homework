using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static int GetDigit(int number, int index)
        {
            return (number / (int)Math.Pow(10, index)) % 10;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the tram ticket number: ");
            int tramNumber = Convert.ToInt32(Console.ReadLine());

            int sum1 = GetDigit(tramNumber, 0) + GetDigit(tramNumber, 1) + GetDigit(tramNumber, 2);
            int sum2 = GetDigit(tramNumber, 3) + GetDigit(tramNumber, 4) + GetDigit(tramNumber, 5);

            if(sum1 == sum2)
            {
                Console.WriteLine("Your ticket is lucky!");
            }
            else
            {
                Console.WriteLine("Your ticket is unlucky. Sorry :(");
            }

            Console.ReadKey();
        }
    }
}
