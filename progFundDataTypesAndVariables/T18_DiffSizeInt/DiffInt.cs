using System;

namespace T18_DiffSizeInt
{
    class DiffInt
    {
        static void Main(string[] args)
        {
            object n = " ";
            try
            {
               // Console.WriteLine($"{long.MaxValue}"); //9223372036854775807
                n = Console.ReadLine();
                if (!(Convert.ToInt64(n) < long.MinValue && Convert.ToInt64(n) > long.MaxValue))
                    Console.WriteLine($"{n} can fit in:");
                if (Convert.ToInt64(n) >= sbyte.MinValue && Convert.ToInt64(n) <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (Convert.ToInt64(n) >= byte.MinValue && Convert.ToInt64(n) <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (Convert.ToInt64(n) >= short.MinValue && Convert.ToInt64(n) <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (Convert.ToInt64(n) >= ushort.MinValue && Convert.ToInt64(n) <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (Convert.ToInt64(n) >= int.MinValue && Convert.ToInt64(n) <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (Convert.ToInt64(n) >= uint.MinValue && Convert.ToInt64(n) <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (Convert.ToInt64(n) >= long.MinValue && Convert.ToInt64(n) <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{n} can't fit in any type");
            }
        }
    }
}
