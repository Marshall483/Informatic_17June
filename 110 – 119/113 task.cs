using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

namespace Temp
{
    class Program
    {

        static void Loops()
        {
            int[] x = new int[101];
            double sum = 0;
            x[1] = 1;
            x[2] = 1;
            x[3] = 1;
            for (int i = 1; i <= 100; i++)
            {
                if (i < 4)
                {
                    x[i] = 1;
                }
                else
                {
                    x[1] = 1;
                    x[2] = 1;
                    x[3] = 1;

                    x[i] = x[i - 1] + x[i - 3];
                }
                sum += (x[i]) / (Math.Pow(2, i));
            }

            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Loops();
        }


    }
}
