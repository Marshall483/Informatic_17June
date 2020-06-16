using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApp21
{
    class Program
    {
        // Если че меняй переменные ЛОЛ, и я не сделал, так шобы все переменные были разные!!!111

        public static void Func(int N)
        {
            Random rnd = new Random();

            double[,] mas = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mas[i, j] = rnd.Next(1, 100) + Math.Round(rnd.NextDouble(), 2);

                    Console.Write("\t" + mas[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            int iMax = 0;
            int jMax = 0;


            // Идем по главной диагонали

            for (int i = 0; i < N; i++)
            {
                if (mas[i, i] > mas[iMax, jMax])
                {
                    iMax = i; jMax = i;
                }
            }


            // Идем по побочной диагонали

            for (int i = 0; i < N; i++)
            {
                if (mas[i, N - 1 - i] > mas[iMax, jMax])
                {
                    iMax = i;
                    jMax = N - 1 - i;
                }
            }


            // Меняем местами

            int MiddleIndex = (N - 1) / 2;

            double TempElement = mas[MiddleIndex, MiddleIndex];

            mas[MiddleIndex, MiddleIndex] = mas[iMax, jMax];

            mas[iMax, jMax] = TempElement;


            // Вывод результат, то есть измененной матрицы

            Console.WriteLine("Матрица после: ");

            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("\t" +  mas[i, j]);
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Задание номер 685");

            Console.Write("Введите число N - это размер матрицы NxN = ");

            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (N % 2 != 0)
            {
                Func(N);
            }

            else
            {
                Console.WriteLine("Нет решения, так как матрица четная!");
            }

            Console.ReadLine();
        }
    }
}
