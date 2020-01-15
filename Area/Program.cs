using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            double radius = double.Parse(Console.ReadLine());
            
            //validation
            while (radius < 0)
            {
                Console.WriteLine("Enter a positive radius: ");
                radius = double.Parse(Console.ReadLine());
            }
            double area = 3.14 * radius * radius;
            Console.WriteLine("The area of a circle with radius " + radius + " is: " + area);
            Console.ReadLine();
        }
    }
}
