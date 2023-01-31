using System;

namespace Week_2_Assignment_2_Assignment
{

    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 7;
            


            myVar =  - 1 + 4 * myVar;

            Console.WriteLine(myVar);

            myVar = (35 + 5);

            myVar %=  7;

            Console.WriteLine(myVar);

            myVar = 14 + -4 * 6 / 12;

            Console.WriteLine(myVar);

            myVar = 2 + 12 / 6 * 1 - myVar % 2;
           

            Console.WriteLine(myVar);


            if (myVar * myVar < 10) 
            {
                Console.WriteLine("myVar is less than 4");
            }
            else
            {
                Console.WriteLine("myVar is greater than 4");
            }
        }


    }














}