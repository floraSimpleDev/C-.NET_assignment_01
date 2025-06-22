using System;

namespace MultiplicationTable11
{
    public class MultiplicationTableClass
    {
        public static void PrintMultiplicationTable()
        {
            Console.WriteLine("Multiplication Table from 1 to 9:");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
