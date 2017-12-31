using System;

namespace T7
{
    class T7_Cake_ingredients
    {
        static void Main(string[] args)
        {
            var ingredient = Console.ReadLine();
            int count = 0;
            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
                count++;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
