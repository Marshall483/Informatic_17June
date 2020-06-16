using System;

namespace Ex679
{
    class Ex_679
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядок матриц");
            int n = int.Parse(Console.ReadLine());


            double[,] matrix1 = new double[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix1[i, j] = double.Parse(Console.ReadLine());

            double[,] matrix2 = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix2[i, j] = double.Parse(Console.ReadLine());

            //А
            double[,] NewMatrixA = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                double max = matrix2[i, 0];

                for (int j = 1; j < n; j++)
                {
                    if (matrix2[i, j] > max)
                        max = matrix2[i, j];
                }

                for (int j = 0; j < n; j++)
                {
                    NewMatrixA[i, j] = matrix1[i, j] * max;
                }

            }



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(String.Format("{0,3}", NewMatrixA[i, j]));
                Console.WriteLine();
            }

            //Б
            double[,] NewMatrixB = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                double mult = 1;

                for (int j = 0; j < n; j++)
                {
                    
                    mult *= matrix2[i, j];
                }

                for (int j = 0; j < n; j++)
                {
                    NewMatrixB[i, j] = matrix1[j, i] + mult;
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(String.Format("{0,3}", NewMatrixB[j, i]));
                Console.WriteLine();
            }
        }
    }
}
