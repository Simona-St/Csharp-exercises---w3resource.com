using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x3Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //2D array size 3x3 

            Console.WriteLine("Enter elements in the matrix : ");
            int i;
            int j;
            int[][] matrix = new int[3][];

            for ( i = 0; i < 3; i++)
            {
                for ( j = 0; j < 3; j++)
                {
                    
                Console.WriteLine($"element - [{i}],[{j}]: ");
                    matrix[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine(string.Join(" ",matrix[0]));
            Console.WriteLine(string.Join(" ", matrix[1]));
            Console.WriteLine(string.Join(" ", matrix[2]));

        }
    }
}
