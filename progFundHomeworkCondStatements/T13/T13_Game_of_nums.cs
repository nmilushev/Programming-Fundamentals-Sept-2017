using System;

namespace T12
{
    class T12_Test_numbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int sum = 0, count = 0;
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    sum = i + j;
                    count++;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {sum}");
                        break;
                    }
                    if (sum == magicNum)
                    {
                        break;
                    }
                }
                if (sum == magicNum)
                {
                    break;
                }
            }
            if (sum != magicNum)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}
