using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _378
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 378 а)
            double[] x = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] y = { 1, 1, 1, 1, 1, 1, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    y[j] = y[j] * x[j];
                    Console.Write(y[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
