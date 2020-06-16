using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_92
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double v1 = 0.0;
            double v2 = 0.0;
            double v3 = 1.5;
            double v4 = 0.0;
            for (double i = 4; i <= n; i++)
            {
                v4 = (i + 1) / (i * i + 1) * v3 - v2 * v1;
                v1 = v2;
                v2 = v3;
                v3 = v4;
            }
            Console.WriteLine(v4);





            Console.ReadKey();



        }
    }
}
