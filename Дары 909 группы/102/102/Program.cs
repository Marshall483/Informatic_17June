using System;

namespace _102
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0 = 1;
            double x = 0;
            while (true)
            {
                x = (2 - x0 * x0 * x0) / 5;
                if (Math.Abs(x - x0) < 0.00001)
                    break;
                x0 = x;
            }
            Console.WriteLine("Член для которого верно условие: " + x);
        }
    }
}
