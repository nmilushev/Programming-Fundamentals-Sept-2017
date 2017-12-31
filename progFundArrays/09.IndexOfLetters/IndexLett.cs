using System;

namespace _09.IndexOfLetters
{
    class IndexLett
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine($"{text[i]} -> {(int)text[i] - 97}");
            }
        }
    }
}
