using System;

namespace CopyElementsFromOneArrayToAnother
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray  = new int[n];

            for (int i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
                secondArray[i] = firstArray[i];
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));

        }
    }
}
