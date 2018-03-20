using System;

namespace Letter_Or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a symbol");
            char symbol = char.Parse(Console.ReadLine());

            if (char.IsLetter(symbol) == true)

            {
                if (char.IsLower(symbol) == true)
                {
                    Console.WriteLine("The character is lowercase.");
                }

                else
                {
                    Console.WriteLine("The character is uppercase.");
                }
            }

            else
            {
                Console.WriteLine("Not a letter.");
            }

        }
    }
}
