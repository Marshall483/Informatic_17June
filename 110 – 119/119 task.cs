using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task119
{
    class Program
    {
        static void Main(string[] args)
        {
            double e;

            Console.Write("e: "); e = double.Parse(Console.ReadLine());
            Console.WriteLine("a) " + A(e));

            Console.Write("e: "); e = double.Parse(Console.ReadLine());
            Console.WriteLine("б) " + B(e));

            Console.Write("e: "); e = double.Parse(Console.ReadLine());
            Console.WriteLine("в) " + C(e));

            Console.Write("e: "); e = double.Parse(Console.ReadLine());
            Console.WriteLine("г) " + D(e));

            Console.Write("e: "); e = double.Parse(Console.ReadLine());
            Console.WriteLine("д) " + E(e));

            Console.Write("e: "); e = double.Parse(Console.ReadLine());
            Console.WriteLine("е) " + F(e));
        }

        static double A(double e)
        {
            var sum = 0.0;
            var i = 1.0;

            while(true)
            {
                var temp = 1 / (i * i);
                if (Math.Abs(temp) < e)
                    return sum;
                sum += temp;
                i++;
            }
        }

        static double B(double e)
        {
            var sum = 0.0;
            var i = 1.0;

            while (true)
            {
                var temp = 1 / ((i + 1) * i);
                if (Math.Abs(temp) < e)
                    return sum;
                sum += temp;
                i++;
            }
        }

        static double C(double e)
        {
            var sum = 0.0;
            var i = 1.0;

            while (true)
            {
                var temp = Math.Pow(-1, i) / Fact((int)i);
                if (Math.Abs(temp) < e)
                    return sum;
                sum += temp;
                i++;
            }
        }

        static double D(double e)
        {
            var sum = 0.0;
            var i = 0.0;

            while (true)
            {
                var temp = Math.Pow(-2, i) / Fact((int)i);
                if (Math.Abs(temp) < e)
                    return sum;
                sum += temp;
                i++;
            }
        }

        static double E(double e)
        {
            var sum = 0.0;
            var i = 1.0;

            while (true)
            {
                var temp = Math.Pow(-1, i + 1) / (i * (i + 1) * (i + 2));
                if (Math.Abs(temp) < e)
                    return sum;
                sum += temp;
                i++;
            }
        }

        static double F(double e)
        {
            var sum = 0.0;
            var i = 1.0;

            while (true)
            {
                var temp = 1 / (Math.Pow(4, i) + Math.Pow(5, i + 2));
                if (Math.Abs(temp) < e)
                    return sum;
                sum += temp;
                i++;
            }
        }

        static int Fact(int number)
        {
            var fact = number;
            if (number == 0)
                return 1;

            for (var i = number - 1; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
