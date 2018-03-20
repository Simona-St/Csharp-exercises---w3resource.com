using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sorted = new List<int>();
            List<int> unsorted = new List<int>();

        //    List<int> array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine("Enter Nums for the sorted List");
            sorted.Add(int.Parse(Console.ReadLine()));
            sorted.Add(int.Parse(Console.ReadLine()));
            sorted.Add(int.Parse(Console.ReadLine()));
            sorted.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter Nums for the unsorted List");
            unsorted.Add(int.Parse(Console.ReadLine()));
            unsorted.Add(int.Parse(Console.ReadLine()));
            unsorted.Add(int.Parse(Console.ReadLine()));
            unsorted.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the value to be inserted in the sorted list:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Position where the value should be inserted: ");
            int position = int.Parse(Console.ReadLine());
            sorted.Insert(position, num);
            Console.WriteLine("Enter the value to be inserted in the unsorted list:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Position where the value should be inserted: ");
            position = int.Parse(Console.ReadLine());
            unsorted.Insert(position, num);

            sorted.Sort();

            Console.WriteLine(string.Join(" ", sorted));
            Console.WriteLine(string.Join(" ", unsorted));

        }
    }
}
