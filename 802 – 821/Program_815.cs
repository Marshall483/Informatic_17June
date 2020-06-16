using System;
using System.Linq;

namespace ConsoleApp8
{
    //ДЛЯ ФЕРЗЯ: 
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(' ').Select(number => int.Parse(number) - 1).ToArray();
            var n = nm[0];
            var m = nm[1];
            var matrix = new string[8, 8];
            matrix[n, m] = "ф";
            var counter = 1; // расстояние от ферзя
            for (var i = 0; i < 8; i++)
            {
                // горизонталь
                if (matrix[n, i] != "ф")
                    matrix[n, i] = "*";
                // вертикаль
                if (matrix[i, m] != "ф")
                    matrix[i, m] = "*";
                // Диагональ
                if (n + counter <= 7)
                {
                    if (m + counter <= 7)
                    {
                        matrix[n + counter, m + counter] = "*";
                    }

                    if (m - counter >= 0)
                    {
                        matrix[n + counter, m - counter] = "*";
                    }
                }
                if (n - counter >= 0)
                {
                    if (m + counter <= 7)
                    {
                        matrix[n - counter, m + counter] = "*";
                    }
                    if (m - counter >= 0)
                    {
                        matrix[n - counter, m - counter] = "*";
                    }
                }
                counter++;
            }

            for (var i = 7; i >= 0; i--)
            {
                for (var i1 = 0; i1 < 8; i1++)
                {
                    if (matrix[i, i1] != "*" && matrix[i, i1] != "ф")
                        matrix[i, i1] = "0";
                    Console.Write(matrix[i, i1]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

    //ДЛЯ КОНЯ:
    class Program1 //еденицы из названия класса и метода мэйн убрать потом
    {
        static void Main1(string[] args)
        {
            var nm = Console.ReadLine().Split(' ').Select(number => int.Parse(number) - 1).ToArray();
            var n = nm[0];
            var m = nm[1];
            var matrix = new string[8, 8];
            matrix[n, m] = "ф";
            ToFillInMatrix(n, m, matrix);

            for (var i = 7; i >= 0; i--)
            {
                for (var i1 = 0; i1 < 8; i1++)
                {
                    if (matrix[i, i1] != "*" && matrix[i, i1] != "ф")
                        matrix[i, i1] = "0";
                    Console.Write(matrix[i, i1]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static void ToFillInMatrix(int n, int m, string[,] matrix)
        {
            if (n + 2 <= 7)
            {
                if (m + 1 <= 7)
                    matrix[n + 2, m + 1] = "*";
                if (m - 1 >= 0)
                    matrix[n + 2, m - 1] = "*";
            }
            if (n - 2 >= 0)
            {
                if (m + 1 <= 7)
                    matrix[n - 2, m + 1] = "*";
                if (m - 1 >= 0)
                    matrix[n - 2, m - 1] = "*";
            }
            if (m + 2 <= 7)
            {
                if (n + 1 <= 7)
                    matrix[n + 1, m + 2] = "*";
                if (n - 1 >= 0)
                    matrix[n - 1, m + 2] = "*";
            }
            if (m - 2 >= 0)
            {
                if (n + 1 <= 7)
                    matrix[n + 1, m - 2] = "*";
                if (n - 1 >= 0)
                    matrix[n - 1, m - 2] = "*";
            }
        }
    }

}

