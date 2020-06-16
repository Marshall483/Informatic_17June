using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace ConsoleApp7
{
    class Program
    {
        /* Примечаение 
         * В итоге задача сводится к складыванию числа с бесконечно малыми величинама(так же у нас происходит переполнение памяти, из-за 2^100 и т.д)
         * Первый вариант выполняет до 2^100, но с переполненной памятью
         * Второй вариант складывает до 2^64, без переполнения
         * Ответы немного различны(можно это понять, протестировав задачу)
         */
        static void Loops1()
        {

            ulong[] x = new ulong[101];
            double sum = 0;
            
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

        static void Loops()
            {
                int[] x = new int[101];
                double sum = 1.0 / 2 + 1.0 / 4 + 1.0 / 8;
                ulong powerOfTwo = 16;
                x[1] = 1;
                x[2] = 1;
                x[3] = 1;
                for (int i = 4; i < 64; i++, powerOfTwo *= 2)
                {

                    sum += (double)(x[i - 1] + x[i - 3]) / powerOfTwo;
                }

                Console.WriteLine(sum);
            }

            static void Main(string[] args)
        {
            Loops1();
            Loops();
        }
    }
}
