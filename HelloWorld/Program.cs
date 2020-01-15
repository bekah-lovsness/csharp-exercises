using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("WHat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
        }
    }
}
