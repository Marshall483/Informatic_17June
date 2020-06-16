using System;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        public static void Main() //вызов всех методов
        {
            var a = new double[3, 3] { { 2, 1, 3 }, { 4, 5, 11 }, { 7, 8, 9 } };
            WriteToArray(a, 3, 3);
            Console.WriteLine();

            WriteToArray(A(a, 3), 3, 3);
            Console.WriteLine();

            WriteToArray(B(a, 3), 3, 3);
            Console.WriteLine();
        }

        public static void WriteToArray(double[,] matrix, int width, int height) //вывод массива на консоль
        {
            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine(" ");
            }
        }
        public static double[,] A(double[,] matrix, int n)
        {
            var indexi = 0;
            var indexj = 0;
            double max = matrix[0, 0];
            for (var i = 0; i < n; i++)
                for (var j = 0; j < n; j++)
                    if (Math.Abs(matrix[i, j]) > max)
                    {
                        max = matrix[i, j];
                        indexi = i;
                        indexj = j;
                    }
            if (indexj == 0 && indexi == 0)
                return matrix;
            else
            {
                for (var k = 0; k < n; k++)
                {
                    var t = matrix[indexi, k];
                    matrix[indexi, k] = matrix[0, k];
                    matrix[0, k] = t;
                }
                for (var k = 0; k < n; k++)
                {
                    var t = matrix[k, indexj];
                    matrix[k, indexj] = matrix[k, 0];
                    matrix[k, 0] = t;
                }
            }
            return matrix;
        }
        public static double[,] B(double[,] matrix, int n)
        {
            var indexi = n - 1;
            var indexj = n - 1;
            double min = matrix[n - 1, n - 1];
            for (var i = 0; i < n; i++)
                for (var j = 0; j < n; j++)
                    if (Math.Abs(matrix[i, j]) < min)
                    {
                        min = matrix[i, j];
                        indexi = i;
                        indexj = j;
                    }
            if (indexj == n - 1 && indexi == n - 1)
                return matrix;
            else
            {
                for (var k = 0; k < n; k++)
                {
                    var t = matrix[indexi, k];
                    matrix[indexi, k] = matrix[n - 1, k];
                    matrix[n - 1, k] = t;
                }
                for (var k = 0; k < n; k++)
                {
                    var t = matrix[k, indexj];
                    matrix[k, indexj] = matrix[k, 0];
                    matrix[k, 0] = t;
                }
            }
            return matrix;
        }
    }
}

