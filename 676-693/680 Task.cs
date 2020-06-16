using System;

namespace _680_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Введите n : ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите m : ");
            m = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            float[,] matrix = new float[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = rnd.Next(0, 100);
            Console.WriteLine("Before : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
            //680-A

            //for (int j =0; j < m; j++)
            //{
            //    float temp = matrix[1, j];
            //    matrix[1, j] = matrix[n - 2, j];
            //    matrix[n - 2, j] = temp;
            //}
            //Console.WriteLine("After (a) : ");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //        Console.Write(matrix[i, j] + " ");
            //    Console.WriteLine();
            //}

            //680-B

            for(int i =0; i < n; i++)
            {
                float temp = matrix[i, 2];
                matrix[i, 2] = matrix[i, n - 3];
                matrix[i, n - 3] = temp;

            }
            Console.WriteLine("After (b) : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }




        }
    }
}
