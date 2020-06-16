using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Matrix
    {
        public static void Mat_STR(int[,] w)
        {
            //перестановка строк

            int m0 = w.GetLength(0) - 1;
            int m1 = 0;
            int[,] m = new int[6, 9];
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {
                    m[m0, m1] = w[i, j];
                    m1++;
                }
                m1 = 0;
                m0--;
            }

            Console.WriteLine();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + " ");
                    if (j == m.GetLength(1) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
        class Program
    {
        static void Main(string[] args)
        {
            //Exercise 676

            int[,] w = new int[6, 9];
            Random rnd = new Random();
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {
                    w[i, j] = rnd.Next(0, 10);
                }
            }
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {
                    Console.Write(w[i, j] + " ");
                    if (j == w.GetLength(1) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }

            Matrix.Mat_STR(w);
            Matrix.Mat_STB(w);
        }
    }
}
