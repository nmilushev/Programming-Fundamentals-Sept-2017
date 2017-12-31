using System;
using System.Linq;

namespace _07.BombNums
{
    class Bomb
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToList();

            var bombArgs = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] == bombArgs[0])
                {
                    for (int j = i - bombArgs[1]; j <= bombArgs[1]+ i; j++)
                    {
                        if (j >= 0 && j <= number.Count - 1)
                        {
                            number[j] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(number.Sum());
        }
    }
}
