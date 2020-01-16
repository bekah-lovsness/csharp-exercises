using System;

namespace ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordList = "Hello Hello Hello Hello Hello";
            PrintWord(wordList);

        }
        static void PrintWord(string wordList)
        {
            for (int i = 0; i < wordList.Length; i += 5) {

                Console.WriteLine(wordList[i]);
            }
            
        }
    }
}
