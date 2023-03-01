using System;
using System.Collections.Generic;

namespace FacebookLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            Console.WriteLine("Enter names of people who liked your post (press Enter without a name to stop):");
            while (true)
            {
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                names.Add(name);
            }

            int count = names.Count;
            if (count == 0)
            {
                Console.WriteLine("No one liked your post.");
            }
            else if (count == 1)
            {
                Console.WriteLine("{0} likes your post.", names[0]);
            }
            else if (count == 2)
            {
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            }
            else
            {
                Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], count - 2);
            }

            Console.ReadLine();
        }
    }
}
