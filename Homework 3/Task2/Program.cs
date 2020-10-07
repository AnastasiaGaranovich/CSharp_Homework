using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matr1 = new Matrix(3, 3);
            Matrix matr2 = new Matrix(3, 5);
            Matrix matr3 = new Matrix(4, 4);

            matr1.InitMatrix();
            Console.WriteLine();
            matr2.InitMatrixRandom();
            Console.WriteLine();
            Console.WriteLine("Enter the elements of Matrix");
            matr3.UserInitMatrix();
            Console.WriteLine();
            Console.WriteLine($"Column count of matr2 {matr2.Column}");
            Console.WriteLine($"Line count of mart2 {matr2.Line}");

            Console.WriteLine($"Max element of matr3 {matr3.Max}");
            Console.WriteLine($"Min element of matr3 {matr3.Min}");

            Console.WriteLine($"Summ of first column in matr2 {matr2.SummFirstColumn}");
            Console.WriteLine($"Summ of first line in matr2 {matr2.SummFirstLine}");

            Console.WriteLine($"Copy of matr1 {Matrix.MakeCopy(matr1)}");
            Console.WriteLine($"matr2 multiplied by itself {matr2 *= matr2}");

            Console.WriteLine($"Copy of matr2 {matr2.Transpose()}");
            Console.WriteLine($"Copy of matr3 {matr3.ChangingDiagonals()}");
            Console.WriteLine($"Sort by columns of matr2 {matr2.SortByColumn()}");

            Console.ReadKey();
        }
    }
}
