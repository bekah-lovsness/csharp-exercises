using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas have you used?");
            int gallonsOfGas = int.Parse(Console.ReadLine());
            int milesPerGallon = miles / gallonsOfGas;
            Console.WriteLine("Your can gets " + milesPerGallon + " miles per gallon.");
        }
    }
}
