using System;

namespace _676
{
    class Program
    {
        static void Main(string[] args)
        {
            Task676B();
        }
        public static void Task676B()
        {
            var matrix = new int[6, 9];
            for (int i = 0; i < 6; i++)
            {
                var str = Console.ReadLine().Split(' ');
                for (int j = 0; j < 9; j++)
                    matrix[i, j] = int.Parse(str[j].ToString());
            }
            Task(matrix);
        }

        private static void Task(int[,] matrix)
        {
            var width = matrix.GetLength(0);
            var height = matrix.GetLength(1);
            Swap(matrix, width, height);
            WriteTwoArray(matrix, width, height);
        }
        private static void Swap(int[,] matrix, int width, int height)
        //поменять строки
        {
            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width / 2; j++)
                {
                    var curValue = matrix[j, i];
                    matrix[j, i] = matrix[width - j - 1, i];
                    matrix[width - j - 1, i] = curValue;
                }
            }
        }
        private static void WriteTwoArray(int[,] matrix, int width, int height) //вывод массива на консоль
        {
            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                    Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine(" ");
            }
        }
    }
}
