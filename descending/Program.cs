using System;
using System.Linq;

namespace descending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(array);
            Console.WriteLine(String.Join(" ", array));
            // LINQ OrderByDescending
            Array.Reverse(array);
            Console.WriteLine(String.Join(" ", array));

        }
    }
}
