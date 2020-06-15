using System;

namespace _101
{
    class Program
    {
        static void Main(string[] args)
        {
            Task101(4, 5, 6);
        }
        public static void Task101(double a, double x, double e)
        {
            double y0 = a;
            double y = 0;
            while (true)
            {
                y = 0.5 * (y0 + x / y0);
                if (Math.Abs(y * y - y0 * y0) < e)
                    break;
                y0 = y;
            }
            Console.WriteLine("Член для которого верно условие : " + y);
        }

    }
}
