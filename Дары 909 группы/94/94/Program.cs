using System;

namespace _94
{
    class Program
    {
        static void Main(string[] args)
        {
            Task94(5);
        }
        public static double Task94(int n)
        {
            double u1 = 0, u2 = 0, v1 = 0, v2 = 0;
            for (int i = 2; i < n; i++)
            {
                double u_ = (u2 - u1 * v2 - v1) / (1 + u2 * u2 + v2 * v2);
                double v_ = (u2 - v2) / (Math.Abs(u1 + v2) + 2);
                u1 = u2; u2 = u_;
                v1 = v2; v2 = v_;
            }
            return v2;
        }

    }
}
