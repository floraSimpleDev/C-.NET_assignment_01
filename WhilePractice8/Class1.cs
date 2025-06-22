using System;

namespace WhilePractice8
{
    public class WhilePracticeClass
    {
        public static void Method()
        {
            int maxAttempts = 10;
            int count = 0;
            string answer = "";

            while (answer.ToLower() != "y" && count < maxAttempts)
            {
                Console.Write("Tutor: Have I made you sense? (y/n): ");
                answer = Console.ReadLine();
                count++;

                if (answer.ToLower() == "y")
                {
                    Console.WriteLine($"Great! You've understood at the {maxAttempts - count} attempts left.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Tutor: Ok! Let's try again.");
                }
            }
            if (answer.ToLower() != "y")
            {
                Console.WriteLine("It's time to stop. Class over.");
            }
        }
    }
}
