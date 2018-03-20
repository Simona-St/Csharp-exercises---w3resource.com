using System;
using System.Collections.Generic;

namespace frequency_of_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements to be stored in the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {n} elements:");

            int[] array = new int[10];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Frequency of all elements: ");
            List<int> container = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int counter = 1;

                if (container.Contains(array[i]) == false)
                {
                    for (int j = i + 1; j < n - 1; j++)
                    {
                        if (array[i] == array[j])
                        {
                            counter++;
                            container.Add(array[i]);
                        }
                    }
                    Console.WriteLine($"Element {array[i]} appears {counter} times");
                }
            }
        }

    }
}
