using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89
{
    class Program
    {
        static void Main(string[] args)
        {
            // Евклид НОД
            Console.WriteLine("Введите m и n");
           int m = Convert.ToInt32(Console.ReadLine());
           int n = Convert.ToInt32(Console.ReadLine());
            int nokm = m;
            int nokn = n;
            int k;
            while (m != 0 && n!=0)
            {
                k = m; //Запоминаем m
                m = n;
                n = k % n;
            }
            Console.WriteLine("НОД: " + Math.Max(m,n)); //Можно поставить просто m
            Console.WriteLine("НОК: " + (nokm * nokn) / Math.Max(m, n));
        }
    }
}
