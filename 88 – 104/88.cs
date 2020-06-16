using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class ChechNum
    {
        public static bool Three(int n)
        {
            while (n > 0)
            {
                if (n % 10 == 3)
                {
                    return true;
                }
                n = n / 10;

            }
            return false;
        }

        public static int Sequence(int n)
        {
            string s = n.ToString();
            string s1 = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                s1 = s1 + s[i];
            }
            return Convert.ToInt32(s1);
        }

        public static int Swap(int n)
        {
            string s = n.ToString();
            char s0 = s[0];
            char s_last = s[s.Length - 1];
            StringBuilder stringBuilder = new StringBuilder(s);
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    s1 = s1 + s_last;
                    continue;
                }
                if (i == s.Length - 1)
                {
                    s1 = s1 + s0;
                }
                else
                {
                    s1 = s1 + s[i];
                }
            }
            return Convert.ToInt32(s1);
        }

        public static int Add(int n)
        {
            string s = 1 + n.ToString() + 1;
            return Convert.ToInt32(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 88

            Console.WriteLine();
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ChechNum.Three(n));
            Console.WriteLine(ChechNum.Sequence(n));
            Console.WriteLine(ChechNum.Swap(n));
            Console.WriteLine(ChechNum.Add(n));
        }
    }
}
