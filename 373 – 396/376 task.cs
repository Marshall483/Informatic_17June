using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

namespace Temp
{
    class Program
    {

        static void GetMatrix(out int[,] input, int[] vector) //376
        {
            input = new int[vector.Length, vector.Length];

            for (int i = 0; i < input.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < input.GetLength(1); j++)
                { input[i, j] = vector[j]; Console.Write(input[i, j] + " "); }

            Console.WriteLine();
        }
        static void MarkedString(int m) //376
        {
            int negative = 0;
            int[,] matrix;
            int[] vector = new int[m];

            Random rnd = new Random();

            for (int i = 0; i < m; i++)
                vector[i] = rnd.Next(-20, 20);

            GetMatrix(out matrix, vector);

            for (int i = 0; i < vector.Length; i++)
                if (vector[i] > 0) //Marced
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        if (matrix[i, j] < 0) { negative++; matrix[i, j] = -1; }
                        else if (matrix[i, j] > 0) matrix[i, j] = 1;

            for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");

            Console.WriteLine("Negative elements: " + negative);
        }
        static void Main() 
        {

            MarkedString(7);//376


            Console.ReadKey();
        }


    }
}
