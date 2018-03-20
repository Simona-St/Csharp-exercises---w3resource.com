using System;
using System.Text;

namespace insert_a_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the original string: ");

            string inputStr = Console.ReadLine();
            Console.WriteLine("Enter the string to be found:");

            string substr = Console.ReadLine();
            Console.WriteLine("Enter the string to be inserted:");

            string newStr = Console.ReadLine();

            int position = inputStr.IndexOf(substr);

            StringBuilder sb = new StringBuilder();
            sb.Append(inputStr);


            sb.Insert(position - 1, " " + newStr);
            Console.WriteLine(sb);

        }
    }
}
