using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Specify the coordinates of the first vertex of the triangle");
            Console.Write("x: ");
            double xFirst = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            double yFirst = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Specify the coordinates of the second vertex of the triangle");
            Console.Write("x: ");
            double xSecond = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            double ySecond = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Specify the coordinates of the third vertex of the triangle");
            Console.Write("x: ");
            double xThird = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            double yThird = Convert.ToDouble(Console.ReadLine());

            double abSide = Math.Sqrt(Math.Pow(xSecond - xFirst, 2) + Math.Pow(ySecond - yFirst, 2));
            double bcSide = Math.Sqrt(Math.Pow(xThird - xSecond, 2) + Math.Pow(yThird - ySecond, 2));
            double caSide = Math.Sqrt(Math.Pow(xThird - xFirst, 2) + Math.Pow(yThird - yFirst, 2));

            double perimeter = abSide + bcSide + caSide;
            double semiPerimeter = perimeter / 2;

            double square = Math.Sqrt(semiPerimeter *(semiPerimeter - abSide) * (semiPerimeter - bcSide) * (semiPerimeter - caSide));

            Console.WriteLine($"Triangle coordinates: ({xFirst} , {yFirst}), ({xSecond} , {ySecond}), ({xThird} , {yThird})");
            Console.WriteLine($"Triangle perimeter = {perimeter}");
            Console.WriteLine($"Triangle square = {square}");


            Console.ReadKey();
        }
    }
}
