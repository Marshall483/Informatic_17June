using System;

namespace _91
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            var n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("n должно быть натуральным");
                return;
            }
            var a = 1;
            for (var i = 1; i <= n; i++)
                a = i * a + 1 / i;
            Console.WriteLine(a);

        }
    }
}
