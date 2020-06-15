using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _677
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n для матриц");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Исходная матрица");
            double[,] a = new double[n,n];
            double[,] b = new double[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToDouble(rand.Next(10));
                    Console.Write(a[i, j] + " ");
                }
            }
            //a
            Console.WriteLine("\n\nЗадача A: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = 0;
                    for (int i1 = 0; i1 < n; i1++)
                        for (int j1 = 0; j1 < n; j1++)
                        {
                            if (i1 != i && j1 != j) b[i, j] = b[i, j] + a[i1, j1];
                        }
                    Console.Write(b[i, j] + " "); 
                }
            }
            
            Console.WriteLine("\n\nЗадача Б: ");
            //б      
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = 0;
                    for (int i1 = 0; i1 <= i; i1++)
                        for (int j1 = j; j1 < n; j1++)
                        { 
                             b[i, j] = b[i, j] + a[i1, j1];
                            
                        }
                   
                    Console.Write(b[i, j] + " ");
                }
            }
            Console.WriteLine("\n\nЗадача В: ");
            //В
            for (int j = 0; j < n; j++) // Начинаю от j, так как это задача обратная b
            {
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    b[i, j] = 0;
                    for (int i1 = j; i1 < n; i1++)
                        for (int j1 = 0; j1 <= i; j1++)
                        {
                            b[i, j] = b[i, j] + a[i1, j1];

                        }

                    Console.Write(b[i, j] + " ");
                }
            }
            Console.WriteLine("\n\nЗадача Г: ");
            //г
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = 0;
                    
                    for (int i1 = Math.Min(i,j); i1 <= Math.Max(i, j); i1++)
                        for (int j1 = Math.Min(i, j); j1 <= Math.Max(i, j); j1++)
                        {
                           b[i, j] = b[i, j] + a[i1, j1];
                        }
                    Console.Write(b[i, j] + " ");
                }
            }

        }
    }
}
