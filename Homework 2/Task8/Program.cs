using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text in russian language: ");
            string rusText = Console.ReadLine();
            string[] rusTextArray = rusText.Split(' ');
            int countWord = 0;

            for(int i = 0; i < rusTextArray.Length; i++)
            {
                
                
            }

            Console.WriteLine($"The number of words ending with a vowel: {countWord}");
            Console.ReadKey();
        }
    }
}
