using System;

namespace Ex377
{
    class Ex_377
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[12, 12];
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 12; j++)
                    matrix[i, j] = rnd.Next(-50, 50);


            for (int i = 0; i < 12; i++)
                for (int j = i; j < 12; j++)
                    matrix[i, j] = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                    Console.Write(String.Format("{0,3}", matrix[i, j]));
                Console.WriteLine();
            }
        }
    }
}
