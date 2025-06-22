using System;
using System.Collections.Generic;

namespace IfElsePractice5
{
    public class IfElsePracticeClass
    {
        public static void IfElseJudgment()
        {
            Dictionary<string, string> userData = new Dictionary<string, string>()
            {
                { "admin", "88888" },
            };

            Console.Write("Please enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();

            if (userData.ContainsKey(username))
            {
                if (userData[username] == password)
                {
                    Console.WriteLine("Login successful!");
                }
                else
                {
                    Console.WriteLine("Incorrect password.");
                }
            }
            else
            {
                Console.WriteLine("Username not found.");
            }
        }
    }
}
