using System;

namespace MaxTwo13
{
    public class MaxTwoClass
    {
        public static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }

        public static void Method()
        {
            Console.Write("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int max = GetMax(num1, num2);
            Console.WriteLine($"The maximum number is: {max}");
        }
    }
}
