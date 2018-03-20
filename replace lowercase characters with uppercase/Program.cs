using System;

namespace replace_lowercase_characters_with_uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the string:");

            var str = Console.ReadLine().ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                char letter = str[i];

                if (char.IsLower(letter))
                {
                    letter = char.ToUpper(letter);
                }

                else if (char.IsUpper(letter))
                {
                    letter = char.ToLower(letter);
                }

                str[i] = letter;
            }

            Console.WriteLine("After conversion, the string is: ");
            Console.WriteLine(String.Join("", str));

        }
    }
}
