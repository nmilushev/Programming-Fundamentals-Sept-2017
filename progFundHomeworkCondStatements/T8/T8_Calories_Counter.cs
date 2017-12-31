using System;

namespace T8
{
    class T8_Calories_Counter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCalories = 0;
            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese")
                {
                    totalCalories += 500;
                }
                if (ingredient == "tomato sauce")
                {
                    totalCalories += 150;
                }
                if (ingredient == "salami")
                {
                    totalCalories += 600;
                }
                if (ingredient == "pepper")
                {
                    totalCalories += 50;
                }
            }
                Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
