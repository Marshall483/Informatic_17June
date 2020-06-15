using System;
using System.Linq;

namespace _680
{
    class Program
    {
        static void Main(string[] args)
        { //A
            Console.WriteLine("Введите количество строк в матрице");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в матрице");
            var m = int.Parse(Console.ReadLine());
            var matrix = new double[n][];
            Console.WriteLine("Введите строки матрицы (числа разделять пробелом)");
            for (var i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(double.Parse).ToArray();
                if (matrix[i].Length != m)
                {
                    Console.WriteLine("Введенная строка имеет неверную длину");
                    return;
                }
            }
            Console.WriteLine();
            var x = matrix[1];
            matrix[1] = matrix[n - 2];
            matrix[n - 2] = x;
            for (var h = 0; h < n; h++)
            {
                for (var w = 0; w < m; w++)
                    Console.Write("{0,3} ", matrix[h][w]);
                Console.WriteLine();
            }

        }
    }
}
