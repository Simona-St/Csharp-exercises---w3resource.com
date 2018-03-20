using System;
using System.Linq;

namespace separate_odd_and_even_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] odd = new int[arr.Length];
            int[] even = new int[arr.Length];
            int counterEven = 0;
            int counterOdd = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 1)
                {
                    odd[counterOdd] = arr[i];
                    counterOdd++;
                }

                else
                {
                    even[counterEven] = arr[i];
                    counterEven++;
                }
            }

            Console.WriteLine("The Even elements are: ");

            foreach (int evenNum in even)
            {
                if (evenNum != 0)
                {
                    Console.Write(evenNum + " ");
                }

            }
            Console.WriteLine();

            Console.WriteLine("The Odd elements are: ");

            foreach (int oddNum in odd)
            {
                if (oddNum != 0)
                {
                    Console.Write(oddNum + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
