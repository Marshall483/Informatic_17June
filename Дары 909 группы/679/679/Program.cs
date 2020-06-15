using System;
using System.Linq;

namespace _679
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 679 A");
            Task679A();
            Console.WriteLine("Task 679 Б");
            Task679B();


        }

        public static void Task679B()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var matrix1 = GetMatrix(n);
            Console.WriteLine();
            var matrix2 = GetMatrix(n);
            Console.WriteLine();
            var res = GetResult(matrix1, matrix2, n);
            WriteResult(res, n);
        }

        public static double[][] GetMatrix(int n)
        {
            var matrix = new double[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[n];
                var input = Console.ReadLine().Split().Select(i => double.Parse(i)).ToArray();
                matrix[i] = input;
            }

            return matrix;
        }

        public static double[][] GetResult(double[][] matrix1, double[][] matrix2, int n)
        {
            var matrixRes = new double[n][];
            var lines = new double[n];

            for (var i = 0; i < n; i++)
            {
                var c = 0.0;
                for (var j = 0; j < n; j++)
                {
                    c += matrix2[i][j];
                }
                lines[i] = c;
            }

            for (var i = 0; i < n; i++)
            {
                matrixRes[i] = new double[n];
                for (var j = 0; j < n; j++)
                {
                    matrixRes[i][j] = matrix1[i][j] + lines[j];
                }
            }
            return matrixRes;
        }

        public static void WriteResult(double[][] matrix, int n)
        {
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                    Console.Write(matrix[i][j] + " ");
                Console.WriteLine(" ");
            }
        }

    






    private static void Task679A()
        {
            Console.WriteLine("Введите число n:");
            var n = int.Parse(Console.ReadLine());
            var matrix1 = CreateMatrix(n);
            var matrix2 = CreateMatrix(n);
            var matrixNew = new double[n, n];
            for (var i = 0; i < n; i++)
            {
                var max = matrix2[i, 0];
                for (var j = 0; j < n; j++)
                    max = Math.Max(matrix2[i, j], max);
                for (var j = 0; j < n; j++)
                    matrixNew[i, j] = matrix1[i, j] * max;
            }
            WriteTwoArray(matrixNew, n);

        }

        private static void WriteTwoArray(double[,] matrix, int n) //вывод массива на консоль
        {
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                    Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine(" ");
            }
        }


        private static double[,] CreateMatrix(int n)
        {
            var matrix = new double[n, n];
            Console.WriteLine("Введите строки матрицы(числа разделять пробелом)");
            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                    matrix[i, j] = double.Parse(str[j].ToString());
            }
            return matrix;
        }

    }
}
