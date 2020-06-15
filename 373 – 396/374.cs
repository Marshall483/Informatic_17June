using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _374
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите n");
            int n = int.Parse(Console.ReadLine());
            int kol = 0;
            int kol1 = 0;
            int kol2 = 0;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                {
                    if (Math.Sin(i + ((double)j / 2)) > 0)
                        kol++;
                    if (Math.Cos((i*i)+n) > 0)
                        kol1++;
                    if (Math.Sin((double)((i * i) - (j * j))/ n) > 0)
                        kol2++;

                }
            Console.WriteLine("Положительных чисел под буквой (а) =  " + kol);
            Console.WriteLine("Положительных чисел под буквой (б) =  " + kol1);
            Console.WriteLine("Положительных чисел под буквой (в) =  " + kol2);
        }
    }
}
