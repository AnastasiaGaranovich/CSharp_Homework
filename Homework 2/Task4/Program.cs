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
            Console.WriteLine("Enter a sentence: ");
            string[] sentenceArray;
            string sentence = Console.ReadLine();
            sentenceArray = sentence.Split(' ');
            Console.WriteLine($"Number of words in a sentence: {sentenceArray.Length}");

            Console.ReadKey();
        }
    }
}
