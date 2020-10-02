using System;

namespace BrackeyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            int wordCount = CountWords(sentence);

            Console.WriteLine("There are " + wordCount + " words in that sentence.");
            
            // Wait for user input to exit.
            Console.ReadKey();
        }
        static int CountWords(string sentence)
        {
            int wordCount = sentence.Split(' ').Length;

            return wordCount;
        }
    }
}
