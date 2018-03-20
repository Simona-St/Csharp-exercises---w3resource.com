using System;

namespace extract_a_substring
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the string:");

            string str = Console.ReadLine();
            Console.WriteLine("Enter the position to start extraction");

            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of substring:");

            int length = int.Parse(Console.ReadLine());

            string sub = str.Substring(start, length);

            Console.WriteLine(sub);

        }
    }
}
