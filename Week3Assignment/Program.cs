using System;
using System.Diagnostics.Metrics;
using System.Transactions;
using System.Xml.Linq;

namespace Week3Assignment
{
    class car
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "Your Speed Limit  is " + limit );
            Console.WriteLine("*******************");

            Console.WriteLine(" Enter Car model1 ");
            string carmodel1 = Console.ReadLine();
            Console.WriteLine(" Enter Car model2 ");
            string carmodel2 = Console.ReadLine();
            Console.WriteLine(" Enter Car model3 ");
            string carmodel3 = Console.ReadLine();
            Console.WriteLine("*******************");

            Console.WriteLine( carmodel1 + " Enter speed ");
            int Speed1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(carmodel2 + " Enter speed ");
            int Speed2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(carmodel3 + " Enter speed ");
            int Speed3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");

            int demeritpoints = 0;

            if ( Speed1 < limit )
            {

                Console.WriteLine(" OK ");
            }
            else
            {
                int speedDifference = Speed1 - limit;
                for (int counter = 5; counter <= speedDifference; counter += 1) 
                { 
                if ( counter %5 == 0 )
                    {
                        demeritpoints++;
                    }
                }

            }
            Console.WriteLine(carmodel1);
            Console.Write("Demerit points :");
            Console.WriteLine(demeritpoints);

            if (demeritpoints >= 10)
            {
                Console.WriteLine("Your license is suspended");
            }
            else
            {
                Console.WriteLine("You are not suspened");
            }

            if (Speed2 < limit)
            {

                Console.WriteLine(" OK ");
            }
            else
            {
                int speedDifference = Speed2 - limit;
                for (int counter = 5; counter <= speedDifference; counter += 1)
                {
                    if (counter % 5 == 0)
                    {
                        demeritpoints++;
                    }
                }

            }
            Console.WriteLine(carmodel2);
            Console.Write("Demerit points :");
            Console.WriteLine(demeritpoints);

            if (demeritpoints >= 10)
            {
                Console.WriteLine("Your license is suspended");
            }
            else
            {
                Console.WriteLine("You are not suspened");
            }



            if (Speed3 < limit)
            {

                Console.WriteLine(" OK ");
            }
            else
            {
                int speedDifference = Speed3 - limit;
                for (int counter = 5; counter <= speedDifference; counter += 1)
                {
                    if (counter % 5 == 0)
                    {
                        demeritpoints++;
                    }
                }

            }
            Console.WriteLine(carmodel3);
            Console.Write("Demerit points :");
            Console.WriteLine(demeritpoints);

            if (demeritpoints >= 10)
            {
                Console.WriteLine("Your license is suspended");
            }
            else
            {
                Console.WriteLine("You are not suspened");
            }





        }

        
    }





}