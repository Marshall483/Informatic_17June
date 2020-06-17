using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _693
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 693
            int n = 2;
            double[,] matrix = new double[2 * n, 2 * n];
            double[,] result = new double[2 * n, 2 * n];
            for (int i = 0; i < 2 * n; i++)
                for (int j = 0; j < 2 * n; j++)
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < 2 * n; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            double temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i + n, j + n];
                    matrix[i + n, j + n] = temp;
                }
            }
            for (int i = n; i < 2 * n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
            for (int i = 0; i < 2 * n; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
