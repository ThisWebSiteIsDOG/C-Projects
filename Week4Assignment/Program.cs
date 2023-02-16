using System;


namespace Week4Assignment
{
    public class rectangle
    {
        public int width, lenght;
        public rectangle(int W, int L)
        {
            width = W;
            lenght = L;
        }

    }

    static class Utilty
    {

        static int length, width, Area, Perimeter;
        public static void getParameters(int Area, int Perimeter)
        {
            Area = Area;
            Perimeter = Perimeter;
        }

        public static void MakeRectangle(int min, int max, out int lenght, out int width, out int area, out int perimiter)
        {

            Random rnd = new Random();
            lenght = Convert.ToInt32(rnd.Next(min, max));
            width = Convert.ToInt32(rnd.Next(min, max));
            rectangle rec = new rectangle(lenght, width);
            area = lenght * width;
            perimiter = 2 * (area + width);
        }


    }


    public class Program
    {
        public static void Main()
        {
            int min, max, length, width, Area, Perimeter;
            Console.Write("Enter the minimum value: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the minimum value: ");
            max = Convert.ToInt32(Console.ReadLine());
            Utilty.MakeRectangle(min, max, out length, out width, out Area, out Perimeter);
            Console.Write("\nLength: " + length);
            Console.Write("\nWidth: " + width);
            Console.Write("\nArea: " + Area);
            Console.Write("\nPerimeter: " + Perimeter);
        }
    }
}
