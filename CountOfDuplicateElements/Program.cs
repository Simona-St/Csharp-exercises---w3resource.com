using System;
using System.Collections.Generic;

namespace CountOfDuplicateElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] array2 = new int[n];
            int counter = 0;
            List<int> found = new List<int>();

            for (int index = 0; index < n; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
                array2[index] = array[index];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    if (array[i] == array2[j] && (found.Contains(array[i]) == false))
                    {
                        found.Add(array[i]);
                        counter++;

                    }
                }
            }

            Console.WriteLine($"Total number of duplicate elements found in the array is : {counter} ");

        }
    }
}
