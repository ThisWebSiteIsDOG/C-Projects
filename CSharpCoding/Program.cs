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
                Console.WriteLine(" You Won! ", answer);
                break;
            }
            else if (guess < answer)
            {
                Console.WriteLine(" You Lost! ");
            }

            else if (guess > answer)
            {
                Console.WriteLine(" Wrong" );
            }
        }



    }

    public static void ProblemFive()
    {
        Console.Write("Enter 8 numbers, seperated by commas: ");

        var userInput = Console.ReadLine();

        var numbers = userInput.Split(',');

        var max = Convert.ToInt32(numbers[0]);

        foreach (var str in numbers)
        {
            var number = Convert.ToInt32(str);
            if (number > max)
                max = number;
        }

        Console.WriteLine("Max is " + max);

    }
}




