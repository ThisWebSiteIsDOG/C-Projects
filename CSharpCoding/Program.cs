using System;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {

        ProblemOne();


        ProblemTwo();


        ProblemThree();


        ProblemFour();

        ProblemFive();
    }
    public static void ProblemOne()
    {

        int count = 0;

        for (int i = 1; i <= 100; i++)
        {

            if (i % 3 == 0)
                count++;
        }
        //display 
        Console.WriteLine("Count of numbers: " + count);
    }
    public static void ProblemTwo()
    {

        string input;

        int number, total = 0;

        while (true)
        {

            Console.Write("Enter a number or ok to exit: ");

            input = Console.ReadLine();

            if (input == "ok")
                break;

            number = Convert.ToInt32(input);

            total = total + number;
        }
        //display 
        Console.WriteLine("Total: " + total);
    }
    public static void ProblemThree()
    {

        int n;
  
        long fact = 1;

        Console.Write("Enter a number: ");

        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {

            fact = fact * i;
        }

        Console.WriteLine("Factorial: " + fact);
    }

    public static void ProblemFour()
    {
        int answer = 0;
        int guess = 0;

        Random random = new Random();
        
        answer = random.Next(0,10);
        for(int i = 0;i < 4; i++)
        {
            Console.WriteLine("Enter Guess");
            guess = Convert.ToInt32(Console.ReadLine());
            if (i>= 4)
            {
                Console.WriteLine(" Game Over Answer is: " , answer);
            }
            else if (guess == answer )
            {
                Console.WriteLine(" Answer is correct ", answer);
                break;
            }
            else if (guess < answer)
            {
                Console.WriteLine(" Wrong ");
            }

            else if (guess > answer)
            {
                Console.WriteLine(" Wrong" );
            }
        }



    }

    public static void ProblemFive()
    {
        int[] num1 = new int[8];
        int max, min;
        Console.WriteLine(" Enter 8 Numbers ");
        for (int i = 0 ; i < 8; i++)
        {
            Console.WriteLine(" \nEnter number here:\n ");
            num1[i] = Convert.ToInt32(Console.ReadLine());

        }
        max = num1[0];
        min = num1[0];
        for (int i=0; i<num1.Length;i++) 
        {



            if (num1[i] > max)
            {
                max = num1[i];
            }

            if (num1[i] < min)
            {
                min = num1[i];
            }
            Console.Write("\n{0}  \n", num1[i] );
        }




        Console.WriteLine(" Maximum nuber is: {0} ", max);
        Console.WriteLine(" Minimum nuber is: {0}", min);
    }

}
