using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_97
{
    class Program
    {
        public static void Func(int N)
        {
            double X1 = 1;
            double Y1 = 1;
            double rez = 0;

            for (int i = 1; i <= N; i++)
            {
                if (i == 1)
                {
                    rez += 0.5;
                }

                else
                {
                    double Xi = 0.3 * X1;
                    double Yi = X1 + Y1;

                    rez += Xi / (1 + Math.Abs(Yi));

                    X1 = Xi;
                    Y1 = Yi;
                }
            }

            Console.WriteLine("Результат = " + rez);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 97: ");

            Console.Write("Введите n: ");

            var n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Func(n);

            Console.ReadLine();
        }
    }
}
