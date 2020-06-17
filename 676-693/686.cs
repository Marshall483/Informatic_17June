using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _686
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int[,] result = new int[2 * n, 2 * n];
            for (int i = 0; i < 2 * n; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                {
                    if (i < n && j < n)     //     < <
                    {
                        result[i, j] = 1;
                        continue;
                    }
                    if (i >= n && j < n)     //     > <
                    {
                        result[i, j] = 2;
                        continue;
                    }
                    if (i < n && j >= n)     //     < > 
                    {
                        result[i, j] = 3;
                        continue;
                    }
                    if (i >= n && j >= n)     //    > >
                    {
                        result[i, j] = 4;
                        continue;
                    }
                }
            }

            for (int i = 0; i < 2 * n; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
