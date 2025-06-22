using System;

namespace OutPractice15
{
    public class OutPracticeClass
    {
        private static bool Login(string username, string password, out string result)
        {
            if (username != "admin")
            {
                result = "Username not found.";
                return false;
            }
            else if (password != "88888")
            {
                result = "Incorrect password.";
                return false;
            }
            else
            {
                result = "Login successful!";
                return true;
            }
        }

        public static void Method()
        {
            Console.Write("Please input the username: ");
            string username = Console.ReadLine();

            Console.Write("Please input the password: ");
            string password = Console.ReadLine();

            bool isSucess = Login(username, password, out string result);

            Console.WriteLine(result);

            if (isSucess)
            {
                Console.WriteLine("Welcome to the system!");
            }
            else
            {
                Console.WriteLine("Please try again.");
            }
        }
    }
}
