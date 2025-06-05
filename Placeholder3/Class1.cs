using System;

namespace Placeholder3
{
    public class PlaceholderClass
    {
        public static void Method()
        {
            Console.Write("Please input the number of days: ");
            string inputDays = Console.ReadLine();

            if (int.TryParse(inputDays, out int totalDays))
            {
                int weeks = totalDays / 7;
                int days = totalDays % 7;
                Console.WriteLine($"{totalDays} days is equal to {weeks} weeks and {days} days.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number of days.");
            }
        }
    }
}
