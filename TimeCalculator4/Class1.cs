using System;

namespace TimeCalculator4
{
    public class TimeCalculatorClass
    {
        public static void Calculator()
        {
            Console.Write("Please input the number of seconds: ");
            if (int.TryParse(Console.ReadLine(), out int totalSeconds))
            {
                int days = totalSeconds / 86400; // 1 day = 86400 seconds
                int remainingAfterDays = totalSeconds % 86400;

                int hours = remainingAfterDays / 3600; // 1 hour = 3600 seconds
                int remainingAfterHours = remainingAfterDays % 3600;

                int minutes = remainingAfterHours / 60; // 1 minute = 60 seconds
                int seconds = remainingAfterHours % 60; // Remaining seconds

                Console.WriteLine($"{totalSeconds} seconds is equal to {days} days, {hours} hours, {minutes} minutes, and {seconds} seconds.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number of seconds.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
