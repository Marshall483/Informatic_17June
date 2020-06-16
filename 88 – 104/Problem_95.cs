using System;

namespace Problem_95
{

    class Program
    {

        public static void Solution()
        {
            double a0 = 1;
            double a1 = a0;
            double a2 = 1;

            double final = 1;

            for(int i = 2; i < 14; i++)
            {

                if (i % 2 == 0)
                {
                    a2 = a0 + a1 / Math.Pow(2, i - 1);
                    final *= a2;
                    a0 = a2;
                }

                else
                {
                    a1 = a1 + a2 / Math.Pow(2, i - 1);
                    final *= a1;
                }

            }

            Console.WriteLine(final);

        }

        static void Main(string[] args)
        {
            Solution();

        }
    }
}
