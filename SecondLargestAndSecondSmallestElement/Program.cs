using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestAndSecondSmallestElement
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(array);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[array.Length-2]);

        }
    }
}
