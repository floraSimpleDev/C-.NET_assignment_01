using System;

namespace DoWhile9
{
    public class DoWhileClass
    {
        public static void DoWhileMethod()
        {
            string name;
            do
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();

                if (name.ToLower() != "q")
                {
                    Console.WriteLine($"{name} has been inputed.");
                }
            } while (name.ToLower() != "q");

            Console.WriteLine("You have exited the input loop by entering 'q'.");
        }
    }
}
