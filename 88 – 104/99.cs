using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Program
    {
        //Задача №99
        static void Main(string[] args)
        {
            //Выбирай решение :)

            Loops();         //Решение через циклы
            Recursion();     //Решение через рекурсию (лучше использовать его, 
                             //т.к. он сказал на консультации такие задачи решать через рекурсию)
        }

        //Вычисление факториала
        static int Fact(int number)
        {
            var fact = number;
            for (var i = number - 1; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;
        }


        static void Loops()
        {
            Console.Write("u: ");
            var u = int.Parse(Console.ReadLine());
            Console.Write("v: ");
            var v = int.Parse(Console.ReadLine());
            Console.Write("n: ");
            var n = int.Parse(Console.ReadLine());

            var a = new int[n + 1]; a[1] = u;
            var b = new int[n + 1]; b[1] = v;

            var sum = 0;

            for (var k = 2; k <= n; k++)
            {
                a[k] = 2 * b[k - 1] + a[k - 1];
                b[k] = 2 * a[k - 1] * a[k - 1] + b[k - 1];

                sum += a[k] * b[k] / Fact(k + 1);
            }

            Console.WriteLine("\nresult: " + sum);
        }


        static void Recursion()
        {
            Console.Write("u: ");
            var u = int.Parse(Console.ReadLine());
            Console.Write("v: ");
            var v = int.Parse(Console.ReadLine());
            Console.Write("n: ");
            var n = int.Parse(Console.ReadLine());

            //Вычисление ak
            int GetA(int k)
            {
                if (k == 1)
                    return u;
                return 2 * GetB(k - 1) + GetA(k - 1);
            }

            //Вычисление bk
            int GetB(int k)
            {
                if (k == 1)
                    return v;
                return 2 * ((int)Math.Pow(GetA(k - 1), 2)) + GetB(k - 1);
            }

            var sum = 0;

            //Вычисление заданной суммы
            for (var k = 1; k <= n; k++)
            {
                sum += GetA(k) * GetB(k) / Fact(k + 1);
            }

            Console.WriteLine("\nresult: " + sum);
        }

    }
}
