using System;

namespace _699
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[,]
           {
                { 1,2,3 },
                { 2,3,4 },
                { 3,4,5 }
           };
            var b = new int[,]
            {
                { 1,2,3 },
                { 2,1,4 },
                { 3,4,1 }
            };

            var x = Task699(a, b);

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] Task699(int[,] A, int[,] B)
        {
            int[,] x = new int[A.GetLength(0), A.GetLength(0)];
            int[,] AB = new int[A.GetLength(0), A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    for (int k = 0; k < B.GetLength(0); k++)
                    {
                        AB[i, j] += A[i, k] * B[k, j];
                    }
                }
            int[,] BA = new int[A.GetLength(0), A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    for (int k = 0; k < B.GetLength(0); k++)
                    {
                        BA[i, j] += B[i, k] * A[k, j];
                    }
                }
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    x[i, j] = AB[i, j] - BA[i, j];
                }
            return x;
        }
    }
}
