using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();

            Console.WriteLine("Enter a string: ");
            string sampleString = Console.ReadLine().ToLower().Trim();
 
            CountChar(characters, sampleString);

            foreach (KeyValuePair<char, int> c in characters)
            {
                Console.WriteLine(c.Key + ": " + c.Value);
            }
                Console.ReadLine();

        }
        static void CountChar (Dictionary<char, int> characters, string sampleString)
        {
            foreach (char c in sampleString)
            {
                int charCount = 0;
                for(int i =0; i < sampleString.Length; i++)
                {
                    if(sampleString[i] == c)
                    {
                        charCount++;
                    }
                }
                if (Char.IsLetter(c))
                {
                    if (!characters.ContainsKey(c))
                    {
                        characters.Add(c, charCount);
                    }
                    else
                    {
                        characters[c] = charCount;
                    }
                }
            }
        }
    }
}
