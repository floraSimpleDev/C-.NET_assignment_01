using System;

namespace ArraySort12
{
    public class ArraySortClass
    {
        public static void SortArray()
        {
            int[] array = { 1, 4, 3, 9, 6, 8, 11 };

            Console.WriteLine("Original array: ");
            PrintArray(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array: ");
            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
