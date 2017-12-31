using System;
using System.Linq;

namespace _01.LargestCommonEnd
{
    class LGE
    {
        static void Main(string[] args)
        {
            string[] wordArrays = Console.ReadLine().Split(' ');
            string[] wordArrays2 = Console.ReadLine().Split(' ');
            int count = 0;
            if (wordArrays[0] == wordArrays2[0])
            {
                for (int i = 0; i < Math.Min(wordArrays.Length, wordArrays2.Length); i++)
                {
                    if (wordArrays[i] == wordArrays2[i])
                    {
                        count++;
                    }
                }
            }
            else if (wordArrays[wordArrays.Length-1] == wordArrays2[wordArrays2.Length-1])
            {
                string[] rev1 = wordArrays.Reverse().ToArray();
                string[] rev2 = wordArrays2.Reverse().ToArray();
                for (int i = 0; i < Math.Min(rev1.Length, rev2.Length); i++)
                {
                    if (rev1[i] == rev2[i])
                    {
                        count++;
                    }
                }
            }
            else
            {
                count = 0;
            }
            Console.WriteLine(count);
        }
    }
}
