using System;

namespace all_unique_elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                arr2[i] = arr1[i];
            }

            for (int i = 0; i < n; i++)
            {
                bool isUnique = false;

                for (int j = i + 1; j < n - 1; j++)
                {
                    if (arr2[j] != arr1[i])
                    {
                        isUnique = true;
                    }
                }

                if (isUnique == true)
                {
                    Console.WriteLine(arr1[i]);
                }
            }

        }
    }
}
