using System;

namespace T14
{
    class T14_Magic_letter
    {
        static void Main(string[] args)
        {
            var first = char.Parse(Console.ReadLine());
            var second = char.Parse(Console.ReadLine());
            var third = char.Parse(Console.ReadLine());
            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        string currentLetter = $"{i}{j}{k} ";
                        if (i != third && j != third && k != third)
                        {
                            Console.Write(currentLetter);
                        }
                    }
                }
            }
        }
    }
}
