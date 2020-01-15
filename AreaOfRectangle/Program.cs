using System;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating the area of a rectangle:");
            Console.WriteLine("Length?");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Width?");
            int width = int.Parse(Console.ReadLine());
            int area = length * width;
            Console.WriteLine("The area is " + area);
        }
    }
}
