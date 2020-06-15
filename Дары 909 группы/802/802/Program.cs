using System;

namespace _802
{
    class Program
    {
        static void Main(string[] args)
        {
            Task802();
        }
        public static void Task802()
        {
            var count = 0;
            var max = 0;
            var str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    count++;

                if (!char.IsDigit(str[i]) || i == str.Length - 1)
                {
                    max = Math.Max(max, count);
                    count = 0;
                }
            }

            Console.WriteLine(max);
        }
    }
}
