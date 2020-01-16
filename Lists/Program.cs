using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(SumOfEven(numList));
            Console.ReadLine();
        }
        static int SumOfEven (int[] numList)
        {
            int sum = 0;
            foreach (int i in numList)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
