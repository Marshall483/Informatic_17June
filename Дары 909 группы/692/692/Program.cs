using System;

namespace _692
{
    class Program
    {
        static void Main(string[] args)
        {  //A
            Task692A();
            //Б
           Task692B();

            // Г
            var matrix = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (var k = 0; k < 3; k++)
            {
                for (var j = 0; j < 3; j++)
                    Console.Write(matrix[k, j]);
                Console.WriteLine();
            }
            Console.WriteLine(Task692G(matrix, 3));

        }
        public static void Task692A()
        {
            Console.WriteLine("Введите число n:");
            var n = int.Parse(Console.ReadLine());
            var matrix = new double[n, n];
            Console.WriteLine("Введите строки матрицы(числа разделять пробелом)");
            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                    matrix[i, j] = double.Parse(str[j]);
            }
            Console.WriteLine(TaskA(matrix, n));

        }

        private static double TaskA(double[,] matrix, int n) //задача А
        {
            var maxElem = matrix[0, 0];
            for (var i = 0; i < n; i++)
                for (var j = i; j < n; j++)
                    if (matrix[i, j] > maxElem)
                        maxElem = matrix[i, j];
            return maxElem;
        }

        public static void Task692B()
        {
            Console.WriteLine("Введите число строк:");
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            Console.WriteLine("Введите строки матрицы(числа разделять пробелом)");
            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine().Split(" ");
                for (int j = 0; j <= i; j++)
                    if (max < int.Parse(str[j]))
                        max = int.Parse(str[j]);
            }
            Console.WriteLine(max);

        }
        public static double Task692G(double[,] matrix, int n)
        {
            var max = matrix[0, 0];
            for (var i = 0; i <= n / 2; i++)
                for (var j = i; j < n - i; j++)
                    if (matrix[j, i] > max)
                        max = matrix[j, i];
            return max;
        }

    }
}
