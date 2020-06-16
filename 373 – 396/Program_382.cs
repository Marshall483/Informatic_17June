using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int m = 9;
            var matrix = new double[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[m];
                var input = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                    matrix[i][j] = double.Parse(input[j]);

            }
            Console.WriteLine();
            var min = matrix[0][0];
            var max = matrix[0][0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] < min)
                    {
                        min = matrix[i][j];
                    }
                    if (matrix[i][j] > max)
                    {
                        max = matrix[i][j];
                    }
                }
            }
            Console.WriteLine("Ср.арифметическое max и min:" + (min + max) / 2);
        }
    }
}

