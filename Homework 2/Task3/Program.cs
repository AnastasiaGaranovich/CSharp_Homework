using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static bool IsPolindrom(string word)
        {
            int lenght = word.Length;
            for(int i = 0; i < lenght / 2; i++)
            {
                if (word[i] != word[lenght - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word, which you want to check: ");
            string userWord = Console.ReadLine();

            if(IsPolindrom(userWord))
            {
                Console.WriteLine("Word is a polindrom");
            }
            else
            {
                Console.WriteLine("Word is not a polindrom");
            }

            Console.ReadKey();
        }
    }
}
