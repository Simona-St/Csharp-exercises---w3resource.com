using System;

namespace Find_the_position_of_a_substring_within_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");

            string str = Console.ReadLine();

            Console.WriteLine("Enter the substring to be found: ");

            string subStr = Console.ReadLine();

            Console.WriteLine(str.IndexOf(subStr));

        }
    }
}
