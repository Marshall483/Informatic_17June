using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Sum_a
    {
        public static double AW(int i1, int j1)
        {
            double s1 = 0;
            double s2 = 0;
            double s3 = 0;
            double s4 = 0;
            for (double i = 1; i < i1; i++)
            {
                for (double j = 1; j < j1; j++)
                {
                    s1 = s1 + 1 / (i + j * j);
                    s2 = s2 + Math.Sin(i * i * i + j * j * j * j);
                    s3 = s3 + (j - i + 1) / (i + j);
                    s4 = s4 + 1 / (2 * j + i);
                }
            }
            Console.WriteLine(s1 + " " + s2 + " " + s3 + " " + s4 + " ");
            return 0;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 334

            Console.Write("i: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("j: ");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum_a.AW(i, j));
        }
    }
}
