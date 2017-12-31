using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    class CompareChar
    {
        static void Main(string[] args)
        {
            var text1 = Console.ReadLine().Split(' ').ToArray();
            var text2 = Console.ReadLine().Split(' ').ToArray();
            bool text1First = false;

            for (int i = 0; i < Math.Min(text1.Length,text2.Length); i++)
            {
                if (Convert.ToChar(text1[0]) < Convert.ToChar(text2[0]))
                {
                     text1First = true;
                    break;
                }
                if (Convert.ToChar(text1[i]) == Convert.ToChar(text2[i]))
                {
                    if (Convert.ToChar(text1[i]) < Convert.ToChar(text2[i]))
                    {
                        text1First = true;
                        break;
                    }
                }
            }
            if (text1First)
            {
                if (text1.Length <= text2.Length)
                {
                    for (int i = 0; i < text1.Length; i++)
                    {
                        Console.Write(text1[i]);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < text2.Length; i++)
                    {
                        Console.Write(text2[i]);
                    }
                    Console.WriteLine();
                } 
            }
            else
            {
                if (text1.Length < text2.Length)
                {
                    for (int i = 0; i < text1.Length; i++)
                    {
                        Console.Write(text1[i]);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < text2.Length; i++)
                    {
                        Console.Write(text2[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                        for (int i = 0; i < text2.Length; i++)
                        {
                            Console.Write(text2[i]);
                        }
                        Console.WriteLine();
                        for (int i = 0; i < text1.Length; i++)
                        {
                            Console.Write(text1[i]);
                        }
                        Console.WriteLine();
                }
            }
        }
    }
}
