using System;

namespace AliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without " +
                "pictures or conversation?'";

            Console.WriteLine("Search for: ");
            string searchTerm = Console.ReadLine();

            firstSentence = firstSentence.ToLower();
            searchTerm = searchTerm.ToLower();
            bool searchSentence = firstSentence.Contains(searchTerm);
            Console.WriteLine(searchSentence);
        }
    }
}
