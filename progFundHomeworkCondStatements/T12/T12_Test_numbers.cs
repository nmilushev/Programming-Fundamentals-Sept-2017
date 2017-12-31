using System;

namespace T12
{
    class T12_Test_numbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0, count = 0;
            for (int i = a; i >= 1; i--)
            {   
                for (int j = 1; j <= b; j++)
                {
                    sum += (i * j)*3;
                    count++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        break;
                    }
                }
                if (sum >= maxSum)
                {
                    break;
                }
            }
            if (sum < maxSum)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
