﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_sum_of_right_diagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the square matrix :");

            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int [n, n];
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
