﻿using System;
    class Program
{
    static void Main(string[] args)
    {
        int i, j;
        int[,] a = new int[2, 2] { { 1, 2 }, { 3, 4 } };
        int[,] b = new int[2, 2] { { 1, 2 }, { 3, 4 } };
        int[,] c = new int[2, 2];

        Console.WriteLine("Matrix A:");
        for (i = 0; i < 2; i++)
        {

            for (j = 0; j < 2; j++)
            {
                Console.Write("\t" + a[i, j]);

            }
            Console.WriteLine();

        }
        Console.WriteLine("Matrix B: ");
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write("\t" + b[i, j]);
            }
            Console.WriteLine();
        }
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                c[i, j] = a[i, j] + b[i, j];
            }
        }
        Console.WriteLine("Resultant matrix: ");
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write("\t" + c[i, j]);
            }
            Console.WriteLine();
        }

    }
}