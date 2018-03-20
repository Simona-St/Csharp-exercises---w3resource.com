using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delete_an_element
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> listche = new List<int>();
            
            int position = int.Parse(Console.ReadLine());

            //Array is immutable class, you can't change it, all you can do is re-create it:
            //List<String> list = columns.ToList(); // <- to List which is mutable
            //list.RemoveAt(MY_INT_HERE);           // <- remove 
            //string[] columns = list.ToArray();    // <- back to array


            foreach (int num in arr)
            {
                listche.Add(num);
            }

            listche.RemoveAt(position);
            listche.Remove(position);
            arr = listche.ToArray();

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
