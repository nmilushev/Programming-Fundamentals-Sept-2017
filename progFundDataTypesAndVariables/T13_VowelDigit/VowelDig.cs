using System;

namespace T13_VowelDigit
{
    class VowelDig
    {
        static void Main(string[] args)
        {
            var charInput = char.Parse(Console.ReadLine());
            if ((int)charInput >= 40 && (int)charInput <= 57)
            {
                Console.WriteLine("digit");
            }
            else if (charInput == 'a' || charInput == 'o' || charInput == 'u' || charInput == 'e' || charInput == 'i')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
