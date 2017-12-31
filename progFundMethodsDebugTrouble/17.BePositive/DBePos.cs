using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());
        if (countSequences == 0)
        {
            Console.WriteLine("(empty)");
        }
        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            var numbers = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                if (!input[j].Equals(string.Empty))
                {
                    int num = Convert.ToInt32(input[j]);
                    numbers.Add(num);
                }
            }
            int go = 0;
            int dec = 1;
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    go = 1;
                }
                else
                {
                    go = 0;
                }
                dec *= go;
            }
            if (dec == 0)
            {
                bool found = false;
                for (int p = 0; p < numbers.Count; p++)
                {
                    int currentNum = numbers[p];
                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(currentNum);
                        if (p == numbers.Count - 1 || (p == numbers.Count - 2 && numbers[p + 1] < 0))
                        {
                            Console.WriteLine();
                        }
                        found = true;
                    }
                    else
                    {
                        if ((p + 1) < numbers.Count)
                        {
                            currentNum += numbers[p + 1];
                        }
                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(currentNum);
                            if ((p == numbers.Count - 1) || ((p == numbers.Count - 2)))
                            {
                                Console.WriteLine();
                            }
                            p++;
                            found = true;
                        }
                        else
                        {
                            if (p == numbers.Count-1 && numbers[p] <0)
                            {
                                break;
                            }
                            if (((p == numbers.Count - 1)) || ((p == numbers.Count - 2) && (numbers[p + 1] < 0)))
                            {
                                p++;
                                Console.WriteLine();
                                break;
                            }
                            p++;
                        }
                    }
                }
                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
            }
            else
            {
                    Console.WriteLine("(empty)");
            }
        }
    }
}