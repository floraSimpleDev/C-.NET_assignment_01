using System;

namespace VariablePractice1
{
    public class PrintVariablesClass
    {
        public static void Person()
        {
            string name = "John Doe";
            string gender = "Male";
            int age = 25;
            string telephone = "123-456-7890";

            Console.WriteLine($"I am {name}, a {age}-year-old {gender}. My telephone number is {telephone}.");
        }
    }
}
