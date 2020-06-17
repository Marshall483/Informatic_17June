using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _116
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 116 a)
            int n_2 = 4;
            double x = 3;
            double[] step = new double[n_2 + 1];
            step[1] = x;
            int[] fak = new int[n_2 + 1];
            fak[1] = 1;
            double sum = 3;
            for (int i = 2; i < n_2 + 1; i++)
            {
                step[i] = step[i - 1] * x;
                fak[i] = fak[i - 1] * i;
                sum += step[i] / fak[i];
            }
            Console.WriteLine(sum);

            Console.WriteLine();

            // Задача 116 б)
            int n_3 = 5;
            double x_1 = 3;
            double const_x = Math.Sqrt(Math.Abs(x_1));
            double[] fak_1 = new double[n_3 + 1];
            double sum_1 = const_x + 1;
            fak_1[1] = 1;
            for (int i = 2; i < n_3 + 1; i++)
            {

                fak_1[i] = fak_1[i - 1] * i;
                sum_1 += 1 / fak_1[i] + const_x;
            }
            Console.WriteLine(sum_1);
        }
    }
}
