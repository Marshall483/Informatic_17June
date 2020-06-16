using System;

namespace _678
{
    class Program
    {
        static void Main(string[] args)
        {

            var matrix = new double[3, 3] {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}};
            Task678(matrix);
        }
        public static double[,] Task678(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[,] result = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = matrix[j, i];
            return result;
        }

    }
}
