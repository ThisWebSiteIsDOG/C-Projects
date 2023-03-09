using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a file path:");
            string filePath = @"" + Console.ReadLine();

            // Use Regex to verify that the file path is in a valid format
            string pattern = @"^[A-Za-z]:\\(.*?)\\[A-Za-z0-9]+\.txt$";
            Match match = Regex.Match(filePath, pattern);

            if (!match.Success)
            {
                Console.WriteLine("File path is not valid.");
                return;
            }
            Console.WriteLine("File path is valid");

            try
            {
                // Test that the file exists
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist.");
                    return;
                }

                Console.WriteLine("Opening the file...");

                // Open the file and count the number of words
                int wordCount = 0;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    Console.WriteLine("Contents of the file:");
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        wordCount += line.Split().Length;
                    }
                }

                Console.WriteLine("There are " + wordCount + " words in the file");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}

