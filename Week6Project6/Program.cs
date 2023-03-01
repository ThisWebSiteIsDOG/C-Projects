
using System;
using System.Collections.Generic;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine().ToLower();

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (letterCount.ContainsKey(c))
                    {
                        letterCount[c]++;
                    }
                    else
                    {
                        letterCount.Add(c, 1);
                    }
                }
            }

            Console.WriteLine("Letter Count:");
            foreach (KeyValuePair<char, int> letter in letterCount)
            {
                Console.WriteLine(letter.Key + ": " + letter.Value);
            }
            Console.ReadLine();
        }
    }
}