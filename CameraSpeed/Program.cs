using System;


public class Car
{
    public string make;
    public string model;
    public int speed;













    void Check_car(int limit)
    {
        int demerits;
        if (speed < limit)
        {
            Console.WriteLine(make + " " + model + " " + speed + "mph : OK");
            return;
        }
        else
        {
            demerits = (speed - limit) / 5;
            if (demerits >= 10)
            {


                Console.WriteLine(make + " " + model + " " + speed + "mph : " + demerits.ToString() + "demerits <LICENSE SUSPENDED>");
                return;
            }
            else
            {
                Console.WriteLine(make + " " + model + " " + speed + "mph : " + demerits.ToString() + "demerits");
                return;
            }
        }

    }


    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the speed Limit");
        string speed_limit = Console.ReadLine();
        int speed_limit_int = Convert.ToInt32(speed_limit);


        Car car1 = new Car();
        Console.WriteLine("Enter Car make 1");
        car1.make = Console.ReadLine();
        Console.WriteLine("Enter Car model 1");
        car1.model = Console.ReadLine();
        Console.WriteLine("Enter Car speed 1");
        car1.speed = Convert.ToInt32(Console.ReadLine());

        Car car2 = new Car();
        Console.WriteLine("Enter Car make 1");
        car2.make = Console.ReadLine();
        Console.WriteLine("Enter Car model 1");
        car2.model = Console.ReadLine();
        Console.WriteLine("Enter Car speed 1");
        car2.speed = Convert.ToInt32(Console.ReadLine());

        Car car3 = new Car();
        Console.WriteLine("Enter Car make 1");
        car3.make = Console.ReadLine();
        Console.WriteLine("Enter Car model 1");
        car3.model = Console.ReadLine();
        Console.WriteLine("Enter Car speed 1");
        car3.speed = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n");

        car1.Check_car(speed_limit_int);
        car2.Check_car(speed_limit_int);
        car3.Check_car(speed_limit_int);


    }

}
