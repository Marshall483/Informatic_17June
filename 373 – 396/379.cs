using System;

namespace _379
{
    class Program
    {
        static double[] Func_of_Lines(double[,] matrix, Func<double, double, double> func)
        {
            double[] b = new double[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                b[i] = matrix[i, 0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    b[i] = func(b[i], matrix[i, j]);
                }
            }
            return b;
        }
        static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[m,n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (double)rnd.Next(0,10);
                }
            }
            PrintMatrix(matrix);
            double[] b = Func_of_Lines(matrix, (t, p) => t + p);
            Console.WriteLine("a)");
            foreach(var i in b)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            b = Func_of_Lines(matrix, (t, p) => t * p);
            Console.WriteLine("б)");
            foreach (var i in b)
            {
                Console.Write(i + " ");
            }
            b = Func_of_Lines(matrix, (t, p) => Math.Min(t,p));
            Console.WriteLine();
            Console.WriteLine("в)");
            foreach (var i in b)
            {
                Console.Write(i + " ");
            }
            b = Func_of_Lines(matrix, (t, p) => t+p);
            Console.WriteLine();
            Console.WriteLine("г)");
            foreach (var i in b)
            {
                Console.Write(i/matrix.GetLength(1) + " ");
            }
            b = Func_of_Lines(matrix, (t, p) => Math.Max(t,p));
            var a = Func_of_Lines(matrix, (t, p) => Math.Min(t, p));
            Console.WriteLine();
            Console.WriteLine("д)");
            for(int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] - a[i]+" ");
            }
        }
    }
}
