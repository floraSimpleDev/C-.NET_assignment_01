using System;
using System.Collections.Generic;

namespace SwitchJudement6
{
    public class SwitchJudementClass
    {
        public static void Method()
        {
            int salary = 5000;

            Console.Write("Please enter the salary performance rating A, B, C, D, E：");
            string input = Console.ReadLine();

            // 转为大写（忽略大小写）
            string rating = input.ToUpper();

            switch (rating)
            {
                case "A":
                    salary += 500;
                    break;
                case "B":
                    salary += 200;
                    break;
                case "C":
                    break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    return;
            }

            Console.WriteLine($"The salary rating is: {salary}.");
        }
    }
}
