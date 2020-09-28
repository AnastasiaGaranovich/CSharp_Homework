using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the temperature value in Fahrenheit: ");
            double temperatureF = Convert.ToDouble(Console.ReadLine());
            double temperatureC = (temperatureF - 32) * 5 / 9;
            Console.WriteLine($"Temperature in Fahrenheit {temperatureF} = {temperatureC} Temperature in Celsius");

            Console.ReadKey();
        }
    }
}
