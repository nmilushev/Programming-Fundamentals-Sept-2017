using System;

namespace T9
{
    class T9_Count_the_integers
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {
                while (count <= 100) //while out of the loop generates runtime error in judge
                {
                    int n = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{count}");
            }
        }

        //int count = 0;
        //bool stopper = true;
        //while (stopper)
        //    try
        //    {
        //        var n = int.Parse(Console.ReadLine());
        //        count++;
        //    }
        //    catch (FormatException)
        //    {
        //        stopper = false;
        //    }
        //Console.WriteLine($"{count}");

    }
}

