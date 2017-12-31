using System;
using System.Linq;

namespace _05.MagicExchWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArgs = Console.ReadLine().Split(' ');
            string str1 = inputArgs[0];
            string str2 = inputArgs[1];

            var arr1 = str1.ToCharArray().Distinct().ToArray();
            var arr2 = str2.ToCharArray().Distinct().ToArray();

            bool exchangable = arr1.Length == arr2.Length;

            Console.WriteLine(exchangable.ToString().ToLower());
        }
    }
}
