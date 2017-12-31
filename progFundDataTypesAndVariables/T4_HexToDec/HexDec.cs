using System;

namespace T4_HexToDec
{
    class HexDec
    {
        static void Main(string[] args)
        {
            var string1 = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(string1,16));
        }
    }
}
