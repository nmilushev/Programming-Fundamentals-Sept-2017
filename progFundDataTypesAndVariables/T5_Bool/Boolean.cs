using System;

namespace T5_Bool
{
    class Boolean
    {
        static void Main(string[] args)
        {
            var string1 = Console.ReadLine().ToLower();
            if (Convert.ToBoolean(string1) == true) //redundant true word
            {
                Console.WriteLine("Yes"); 
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
