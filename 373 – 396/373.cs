using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Ar_Matrix
    {
        public static void Mat(int[,] w)
        {
            double count = 0;
            int num = 1;
            for (int j = 0; j < w.GetLength(1); j++)
            {
                for (int i = 0; i < w.GetLength(0); i++)
                {
                    count = count + w[i, j];
                }
                Console.WriteLine(count / w.GetLength(0) + " " + num);
                count = 0;
                num++;
            }
        }

        public static void MatChet(int[,] w)
        {
            double count = 0;
            int c = 0;
            int num = 1;
            for (int j = 0; j < w.GetLength(1); j++)
            {
                for (int i = 0; i < w.GetLength(0); i++)
                {
                    if (j % 2 != 0)
                    {
                        count = count + w[i, j];
                        c = 1;
                    }
                }
                if (c == 1)
                {
                    Console.WriteLine(count / w.GetLength(0) + " " + num);
                }
                count = 0;
                num++;
                c = 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 373

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] w = new int[n, 9];
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
            Ar_Matrix.Mat(w);
            Ar_Matrix.MatChet(w);
        }
    }
}
