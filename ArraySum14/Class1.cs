using System;

namespace ArraySum14
{
    public class ArraySumClass
    {
        public static int GetSum(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            return sum;
        }

        public static void Method()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Calculating the sum of the array: ");
            foreach (int num in array) 
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int sum = GetSum(array);
            Console.WriteLine($"The sum of the array elements is: {sum}");
        }
    }
}
