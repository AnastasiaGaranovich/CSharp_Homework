using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the rectangle length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the rectangle width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a symbol for the outline of the rectangle: ");
            char symbolOutline = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter a symbol to fill the rectangle: ");
            char symbolFill = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i <length; i++)
            {
                if(i == 0 || i == length - 1)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write($"{symbolOutline}");
                    }
                }
                else
                {
                    for (int j = 0; j < width; j++)
                    {
                        if(j == 0 || j == width - 1)
                        {
                            Console.Write($"{symbolOutline}");
                        }
                        else
                        {
                            Console.Write($"{symbolFill}");
                        }
                    }
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
 