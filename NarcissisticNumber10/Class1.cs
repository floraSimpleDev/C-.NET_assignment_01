using System;

namespace NarcissisticNumber10
{
    public class NarcissisticNumberClass
    {
        public static void CheckNumber()
        {
            Console.WriteLine("All the narcissistic numbers between 0 and 1000 are: ");

            for (int number = 100; number < 999; number++)
            {
                int hundreds = number / 100;
                int tens = (number / 10) % 10;
                int units = number % 10;

                int sumOfCubes = (hundreds * hundreds * hundreds) + (tens * tens * tens) + (units * units * units);

                if (sumOfCubes == number)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
