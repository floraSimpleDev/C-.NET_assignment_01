using System;

namespace RefPractice16
{
    public class RefPracticeClass
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Method()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before swap: num1 = {num1}, num2 = {num2}");
            Swap(ref num1, ref num2);
            Console.WriteLine($"After swap: num1 = {num1}, num2 = {num2}");
        }
    }
}
