using System;
using System.Linq;

namespace _06.SumReverse
{
    class SumRev
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine()
                .Split()
                .Select(a => int.Parse(new string(a.Reverse().ToArray())))
                .Sum());
        }
    }
}
