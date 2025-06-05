using System;

namespace MonthAndYear7
{
    public class MonthAndYearClass
    {
        public static void JudgmentMethod()
        {
            Console.Write("Please input the number of year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Please input the number of months(1-12): ");
            int month = int.Parse(Console.ReadLine());

            int days;
            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    days = isLeap ? 29 : 28;
                    break;
                default:
                    Console.WriteLine("Invalid month input. Please enter a number between 1 and 12.");
                    return;
            }
            Console.WriteLine($"The month {month} of the year {year} has {days} days.");

            if (month == 2)
            {
                Console.WriteLine($"{year} is the {(isLeap ? "leap" : "common")} year.");
            }
        }
    }
}
