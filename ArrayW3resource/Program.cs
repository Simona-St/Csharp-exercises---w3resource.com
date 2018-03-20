using System;

namespace ArrayW3resource
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 10 elements in the array: ");
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine()); // int.Parse(Console.ReadLine());
            }
            Console.Write("Elements in array are: ");
            Console.Write(string.Join(" ", array));
            Console.WriteLine();
        }
    }
}
