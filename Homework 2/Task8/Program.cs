using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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

            char[] arrayVowel = { 'а', 'е', 'о', 'э', 'я', 'и', 'ю', 'ы', 'у' };

            for (int i = 0; i < rusTextArray.Length; i++)
            {
                char vowelLetter = rusTextArray[i].Last();
                Console.WriteLine(rusTextArray[i]);
                Console.WriteLine(i);
                Console.WriteLine(vowelLetter);
                if (arrayVowel.Contains(vowelLetter))
                {
                    countWord++;
                }
            }

            Console.WriteLine($"The number of words ending with a vowel: {countWord}");
            Console.ReadKey();
        }
    }
}
