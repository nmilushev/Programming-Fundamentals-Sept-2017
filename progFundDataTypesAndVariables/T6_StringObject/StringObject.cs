using System;

namespace T6_StringObject
{
    class StringObject
    {
        static void Main(string[] args)
        {
            string string1 = "Hello";
            string string2 = "World";
            object temp = string1 + " " + string2;
            string string3 = (string)temp;
            Console.WriteLine(string3);
        }
    }
}
