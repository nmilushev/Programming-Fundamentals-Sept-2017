using System;

namespace _05.Fibonacci
{
    class Fibonacci
    {
        static int Fib(int n)
        {
            int num1 = 1;
            int num2 = 1;
            int fib = 1;
            for (int i = 2; i <= n; i++)
            {
                fib = num1 + num2;
                num2 = num1;
                num1 = fib;
            }
            return fib;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
    }
}
