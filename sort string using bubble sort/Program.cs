using System;

namespace sort_string_using_bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }

            for (int i = 1; i < n; i++)
            {
                int caseSensitiveResult = string.Compare(arr[i - 1], arr[i], false);

                if (caseSensitiveResult > 0) // value -1 indicates that arr[i-1] is “less than” arr[i]  
                {
                    string temp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp;
                }

            }
                Console.WriteLine(String.Join(" ", arr));
        }
    }
}
